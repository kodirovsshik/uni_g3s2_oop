using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormProcedureTable : Form
    {
        DataStore data;
        List<ulong> procedures;
        USP editee;
        ulong currentPatientID = ulong.MaxValue;
        ulong currentProcedureID = ulong.MaxValue;

        public FormProcedureTable(DataStore data)
        {
            InitializeComponent();
            this.data = data;
            this.procedures = new List<ulong>();
        }

        private void FormProcedureTable_Load(object sender, EventArgs e)
        {

        }

        private void clearCurrentProcedure()
        {
            this.editee = null;
            this.currentProcedureID = ulong.MaxValue;
            this.textBoxDataDateD.Clear();
            this.comboBoxDataDateM.SelectedIndex = -1;
            this.textBoxDataDateY.Clear();
            this.textBoxDataFile.Clear();
            this.comboBoxDataType.SelectedIndex = -1;
            this.comboBoxDataKind.SelectedIndex = -1;
            this.textBoxDataProcedureID.Clear();
        }

        private void loadById(ulong id)
        {
            this.clearCurrentProcedure();

            if (this.data.tablePatientsToUSPs.ContainsKey(id))
            {
                this.procedures = this.data.tablePatientsToUSPs[id];
                this.textBoxDataPatientID.Text = id.ToString();
                this.textBoxDataFIO.Text = this.data.tablePatients[id].getFIOstring();
            }
            else
            {
                this.procedures = new List<ulong>();
                this.textBoxDataPatientID.Clear();
                this.textBoxDataFIO.Clear();
            }

            this.currentPatientID = id;
        }

        private bool tryFindLoadByID()
        {
            ulong id;
            if (!ulong.TryParse(this.textBoxSearch.Text, out id))
                return false;
            loadById(id);
            return true;
        }

        private void clearState()
        {
            this.clearCurrentProcedure();
            this.currentPatientID = ulong.MaxValue;
            this.textBoxDataFIO.Clear();
            this.textBoxDataPatientID.Clear();
            this.listBox1.Items.Clear();
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            this.clearState();
            if (!tryFindLoad())
                return;
            displayTable();
        }
        ListBoxItem createListBoxItem(ulong id)
        {
            USP proc = this.data.tableProcedures[id];
            string procType = this.comboBoxDataType.Items[proc.type].ToString();
            string procKind = this.comboBoxDataKind.Items[proc.kind].ToString();
            string date = proc.procedureDate.ToString("dd.MM.yyyy");
            return new ListBoxItem(date + " " + procType + " " + procKind, id);
        }

        private void displayTable()
        {
            this.clearCurrentProcedure();
            this.listBox1.Items.Clear();
            foreach (var id in this.procedures)
                this.listBox1.Items.Add(createListBoxItem(id));
        }

        private bool tryFindLoad()
        {
            this.clearCurrentProcedure();
            if (tryFindLoadByID())
                return true;
            return false;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            this.clearCurrentProcedure();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (this.currentProcedureID == ulong.MaxValue || this.currentPatientID == ulong.MaxValue)
                return;

            this.procedures.Remove(this.currentProcedureID);
            this.data.tableProcedures.Remove(this.currentProcedureID);
            this.data.tablePatientsToUSPs[this.currentPatientID].Remove(this.currentProcedureID);
            this.clearCurrentProcedure();
            this.displayTable();
        }

        private void pickProcedure(ulong id)
        {
            this.currentProcedureID = id;
            this.editee = this.data.tableProcedures[id];

            this.textBoxDataDateD.Text = editee.procedureDate.Day.ToString();
            this.comboBoxDataDateM.SelectedIndex = editee.procedureDate.Month - 1;
            this.textBoxDataDateY.Text = editee.procedureDate.Year.ToString();
            this.textBoxDataFile.Text = editee.dataFile;
            this.comboBoxDataType.SelectedIndex = editee.type;
            this.comboBoxDataKind.SelectedIndex = editee.kind;
            this.textBoxDataProcedureID.Text = id.ToString();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex == -1)
            {
                this.clearCurrentProcedure();
                return;
            }
            var item = (ListBoxItem)this.listBox1.SelectedItem;
            pickProcedure(item.id);
        }

        private void actionSave()
        {
            if (this.editee == null)
            {
                if (this.currentPatientID == ulong.MaxValue)
                    return;
            }

            DateTime date;
            try
            {
                date = new DateTime(
                    int.Parse(this.textBoxDataDateY.Text),
                    this.comboBoxDataDateM.SelectedIndex + 1,
                    int.Parse(this.textBoxDataDateD.Text)
                );
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Некорректная дата", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (date.Year < 1900)
                    throw new Exception("Некорректная дата");
                if (this.comboBoxDataKind.SelectedIndex == -1)
                    throw new Exception("Выберите вид исследования");
                if (this.comboBoxDataType.SelectedIndex == -1)
                    throw new Exception("Выберите тип исследования");
                if (date < this.data.tablePatients[this.currentPatientID].birthdate)
                    throw new Exception("Указанная дата предшествует рождению пациента");
                if (date.AddDays(2) >= DateTime.Today)
                    throw new Exception("Указанная дата ещё не наступила");
            }
            catch (Exception excp)
            {
                MessageBox.Show(this, excp.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.editee == null)
                this.editee = new USP();

            this.editee.procedureDate = date;
            this.editee.dataFile = this.textBoxDataFile.Text;
            this.editee.patientId = this.currentPatientID;
            this.editee.kind = this.comboBoxDataKind.SelectedIndex;
            this.editee.type = this.comboBoxDataType.SelectedIndex;

            this.data.dataModified = true;

            int newDisplayIndex;
            if (this.currentProcedureID == ulong.MaxValue)
            {
                this.currentProcedureID = this.data.newProcedureID();
                this.data.tableProcedures.Add(this.currentProcedureID, this.editee);
                this.data.tablePatientsToUSPs[this.currentPatientID].Add(this.currentProcedureID);
                newDisplayIndex = this.listBox1.Items.Count;
            }
            else
            {
                newDisplayIndex = this.listBox1.SelectedIndex;
            }
            this.displayTable();
            this.listBox1.SelectedIndex = newDisplayIndex;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.actionSave();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog(this) == DialogResult.OK)
                this.textBoxDataFile.Text = this.openFileDialog.FileName;
        }
    }
}
