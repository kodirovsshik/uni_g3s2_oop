using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Windows.Forms.VisualStyles;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1
{
	using FieldList = System.Collections.ArrayList;
	using TextBox = System.Windows.Forms.TextBox;

	public partial class FormPatientTable : Form
	{
		DataStore data;
		Patient editee;
		ulong editeeID = ulong.MaxValue;
		int editeeIndex = -1;
		bool editeeModified = false;
		bool preventSetEditeeModified = false;
		bool selectionChangePending = false;

        List<ulong> tablePatientsSlice = new List<ulong>();

		public FormPatientTable(DataStore data)
		{
			InitializeComponent();

			this.data = data;

			this.rebuildCurrentTableSlice();
			this.displayCurrentTable();
		}

		public void rebuildCurrentTableSlice()
		{
			this.tablePatientsSlice.Clear();
			foreach (var pair in data.tablePatients)
				this.tablePatientsSlice.Add(pair.Key);

			var newSlice = new List<ulong>();
			if (this.textBoxSearchPatientID.Text.Length > 0)
			{
				ulong id;
				if (ulong.TryParse(this.textBoxSearchPatientID.Text, out id) && this.tablePatientsSlice.Contains(id))
					newSlice.Add(id);

				this.tablePatientsSlice = newSlice;
				return;
			}
			if (this.textBoxSearchProcedureID.Text.Length > 0) 
			{
				var oldSLice = this.tablePatientsSlice;
				this.tablePatientsSlice = newSlice;

				ulong id;
				if (!ulong.TryParse(this.textBoxSearchProcedureID.Text, out id))
					return;
				if (!this.data.tableUSPs.ContainsKey(id))
					return;
				ulong patientId = this.data.tableUSPs[id].patientId;
				if (!oldSLice.Contains(patientId))
					return;
				newSlice.Add(patientId);
				return;
			}
			if (this.textBoxSearchFIO.Text.Length > 0)
			{
				var words = this.textBoxSearchFIO.Text.Split(' ');
				lowerize(ref words);

				foreach (ulong id in this.tablePatientsSlice)
				{
					var creds = this.data.tablePatients[id].getFIOstring().Split(' ');
					lowerize(ref creds);
					if (setMatches(words, creds))
						newSlice.Add(id);
				}

				this.tablePatientsSlice = newSlice;
			}
		}
		public static void lowerize(ref string[] words)
		{
			for (int i = 0; i < words.Length; ++i)
				words[i] = words[i].ToLower();
		}

		public static bool setMatches(string[] matchees, string[] set)
		{
			foreach (var matchee in matchees)
			{
				bool found = false;
				foreach (var s in set)
				{
					if (s.Contains(matchee))
					{
						found = true;
						break;
					}
				}
				if (!found)
					return false;
			}
			return true;
		}

		public void actionConditionallyEnableSearchModeElements()
		{
			List<TextBox> textBoxes = new List<TextBox> {
				this.textBoxSearchFIO,
				this.textBoxSearchPatientID,
				this.textBoxSearchProcedureID
			};

			bool has_nonempty = false;
			foreach (var textBox in textBoxes)
				has_nonempty |= textBox.Text.Length > 0;

			if (has_nonempty)
			{
				foreach (var tb in textBoxes)
				{
					if (tb.Text.Length == 0)
						tb.Enabled = false;
					else if (tb.Enabled == false)
						tb.Enabled = true;
				}
			}
			else
			{
				foreach (var tb in textBoxes)
					tb.Enabled = true;
			}
			this.buttonAdd.Enabled = !has_nonempty;
		}
		public void actionApplySearchMode()
		{
			this.actionConditionallyEnableSearchModeElements();
			this.rebuildCurrentTableSlice();
			this.displayCurrentTable();
		}

		public void displayCurrentTable()
		{
			var lastEditeeID = this.editeeID;

			this.listBoxPatients.ClearSelected();
			this.listBoxPatients.Items.Clear();
			foreach (var id in this.tablePatientsSlice)
			{
				var patient = this.data.tablePatients[id];
				this.listBoxPatients.Items.Add(
					new ListBoxItem(patient.getFIOstring(), id)
				);
			}

			if (lastEditeeID == ulong.MaxValue)
				return;

			for (int idx = 0; idx < this.listBoxPatients.Items.Count; ++idx)
			{
				var item = (ListBoxItem)this.listBoxPatients.Items[idx];
				if (item.id == lastEditeeID)
				{
					this.listBoxPatients.SelectedIndex = idx;
					return;
				}
			}
		}

		public void setDataFieldsEnabled(bool enabled)
		{
			this.labelDataF.Enabled = enabled;
			this.labelDataI.Enabled = enabled;
			this.labelDataO.Enabled = enabled;
			this.labelDataBD.Enabled = enabled;
			this.labelBDD.Enabled = enabled;
			this.labelBDM.Enabled = enabled;
			this.labelBDY.Enabled = enabled;
			this.labelGender.Enabled = enabled;
			this.labelID.Enabled = enabled;

			this.textBoxDataF.Enabled = enabled;
			this.textBoxDataI.Enabled = enabled;
			this.textBoxDataO.Enabled = enabled;
			this.numericUpDown1.Enabled = enabled;
			this.comboBoxDBM.Enabled = enabled;
			this.textBoxDataY.Enabled = enabled;
			this.comboBoxGender.Enabled = enabled;

			
			if (!enabled)
			{
				this.preventSetEditeeModified = true;
				this.textBoxDataF.Text = "";
				this.textBoxDataI.Text = "";
				this.textBoxDataO.Text = "";
				this.numericUpDown1.Value = 1;
				this.comboBoxDBM.SelectedIndex = -1;
				this.textBoxDataY.Text = "";
				this.comboBoxGender.SelectedIndex = -1;
				this.preventSetEditeeModified = false;

				this.setEditeeModified(false);
				this.buttonDelete.Enabled = false;
			}
		}

		private void FormPatientTable_Load(object sender, EventArgs e)
		{
		}

		private bool checkUnsavedSafe()
		{
			if (!this.editeeModified)
				return true;

			var dialogResult = MessageBox.Show(
	this, "Имеются несохранённые изменения текущего пациента.\n" +
	"Желаете сохранить их?", "Внимание", MessageBoxButtons.YesNoCancel);

			if (dialogResult == DialogResult.Yes)
				return this.actionEditeeSave();
			if (dialogResult == DialogResult.No)
			{
				this.actionEditeeDiscard();
				return true;
			}
			return false;
		}

		void actionHandleSelectedIndexChanged()
        {
			int newSelection = this.listBoxPatients.SelectedIndex;
			bool should_continue = this.checkUnsavedSafe();
            this.listBoxPatients.SelectedIndex = newSelection;
            if (!should_continue)
                return;

            if (this.editeeIndex != -1 && this.editeeID == ulong.MaxValue)
                this.listBoxPatients.Items.RemoveAt(this.editeeIndex);

            actionLoadEditeeUnchecked(newSelection);
        }
		private void listBoxPatients_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.selectionChangePending)
				return;

			if (this.listBoxPatients.SelectedIndex == -1)
			{
				this.editee = null;
				this.editeeID = ulong.MaxValue;
				this.editeeIndex = -1;
				this.setDataFieldsEnabled(false);
				return;
			}
			
			if (this.listBoxPatients.SelectedIndex == this.editeeIndex)
				return;
			
			this.selectionChangePending = true;
			this.actionHandleSelectedIndexChanged();
			this.selectionChangePending = false;
		}
		
		void setEditeeModified(bool modified)
		{
			if (modified && this.preventSetEditeeModified)
				return;

			this.editeeModified = modified;
			this.buttonSave.Enabled = modified;
			this.buttonRollback.Enabled = modified;

			if (modified)
			{
				this.textBoxSearchFIO.Enabled = !modified;
				this.textBoxSearchPatientID.Enabled = !modified;
				this.textBoxSearchProcedureID.Enabled = !modified;
			}
			else
				this.actionConditionallyEnableSearchModeElements();

		}

		FieldList getDataFields()
		{
			var fieldList = new FieldList();
			fieldList.Add(this.textBoxDataF);
			fieldList.Add(this.textBoxDataI);
			fieldList.Add(this.textBoxDataO);
			fieldList.Add(this.numericUpDown1);
			fieldList.Add(this.comboBoxDBM);
			fieldList.Add(this.textBoxDataY);
			fieldList.Add(this.comboBoxGender);
			return fieldList;
		}


		void actionLoadEditeeUnchecked(int listBoxIndex)
		{
			var item = (ListBoxItem)this.listBoxPatients.Items[listBoxIndex];
			this.editeeIndex = listBoxIndex;
			this.editeeID = item.id;
			if (this.editeeID != ulong.MaxValue)
				this.editee = this.data.tablePatients[item.id];
			else
				this.editee = new Patient();

			var fieldList = this.getDataFields();
			this.preventSetEditeeModified = true;
			this.editee.disassemble(fieldList);
			this.preventSetEditeeModified = false;

			this.textBoxDataID.Text = item.id != ulong.MaxValue ? item.id.ToString() : "";

			this.setDataFieldsEnabled(true);
			this.setEditeeModified(false);
			this.buttonDelete.Enabled = true;
		}

		bool actionEditeeSave()
		{
			try
			{
				this.editee.assemble(this.getDataFields());
			}
			catch (Exception e)
			{
				MessageBox.Show(this, e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			this.setEditeeModified(false);

			var currentItem = (ListBoxItem)this.listBoxPatients.Items[this.editeeIndex];
			currentItem.displayedString = this.editee.getFIOstring();

			if (this.editeeID == ulong.MaxValue)
            {
                this.editeeID = currentItem.id = this.data.newPatientID();
                this.textBoxDataID.Text = currentItem.id.ToString();
                this.data.tablePatients.Add(this.editeeID, this.editee);
				this.data.tablePatientsToUSPs.Add(this.editeeID, new List<ulong>());
            }

			this.data.dataModified = true;

            this.rebuildCurrentTableSlice();
            this.displayCurrentTable();

            return true;
		}
		void actionEditeeDiscard()
		{
			this.actionLoadEditeeUnchecked(this.editeeIndex);
		}


		private void buttonDelete_Click(object sender, EventArgs e)
		{
			this.setEditeeModified(false);
			if (this.editeeID != ulong.MaxValue)
			{
				this.data.tablePatients.Remove(this.editeeID);
				this.data.tablePatientsToUSPs.Remove(this.editeeID);
			}
			this.listBoxPatients.Items.RemoveAt(this.editeeIndex);

			int new_idx = this.editeeIndex;
			if (new_idx >= this.listBoxPatients.Items.Count)
				new_idx = this.listBoxPatients.Items.Count - 1;
			if (new_idx >= 0)
			{
				this.listBoxPatients.SelectedIndex = new_idx;
				this.actionLoadEditeeUnchecked(new_idx);
			}
			else
			{
				this.editee = null;
				this.editeeIndex = -1;
				this.editeeID = ulong.MaxValue;
			}
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (!this.checkUnsavedSafe())
				return;

			var idx = this.listBoxPatients.Items.Count;
			this.listBoxPatients.Items.Add(new ListBoxItem("(новый пациент)", ulong.MaxValue));
			this.listBoxPatients.SelectedIndex = idx;
		}

		private void textBoxDataF_TextChanged(object sender, EventArgs e)
		{
			this.setEditeeModified(true);
		}

		private void textBoxDataI_TextChanged(object sender, EventArgs e)
		{
			this.setEditeeModified(true);
		}

		private void textBoxDataO_TextChanged(object sender, EventArgs e)
		{
			this.setEditeeModified(true);
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			this.setEditeeModified(true);
		}

		private void comboBoxDBM_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.setEditeeModified(true);
		}

		private void textBoxDataY_TextChanged(object sender, EventArgs e)
		{
			this.setEditeeModified(true);
		}

		private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.setEditeeModified(true);
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			this.actionEditeeSave();
		}

		private void buttonRollback_Click(object sender, EventArgs e)
		{
			this.actionEditeeDiscard();
		}

		private void textBoxSearchFIO_TextChanged(object sender, EventArgs e)
		{

			this.actionApplySearchMode();
		}

		private void textBoxSearchPatientID_TextChanged(object sender, EventArgs e)
		{
			this.actionApplySearchMode();
		}

		private void textBoxSearchProcedureID_TextChanged(object sender, EventArgs e)
		{
			this.actionApplySearchMode();
		}

        private void textBoxSearchFIO_EnabledChanged(object sender, EventArgs e)
        {
        }
    }
}
