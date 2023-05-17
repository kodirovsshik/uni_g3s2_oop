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
        private DataStore data;
        ulong[] procedures;
        ulong currentPatient = ulong.MaxValue;
        ulong currentProcedure = ulong.MaxValue;

        public FormProcedureTable(DataStore data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void FormProcedureTable_Load(object sender, EventArgs e)
        {

        }

        private void clearCurrentProcedure()
        {
            this.currentProcedure = ulong.MaxValue;
            this.textBoxDataDateD.Clear();
            this.comboBoxDataDateM.SelectedIndex = -1;
            this.textBoxDataDateY.Clear();
            this.textBoxDataFile.Clear();
            this.comboBoxDataType.SelectedIndex = -1;
            this.comboBoxDataKind.SelectedIndex = -1;
            this.textBoxDataProcedureID.Clear();
        }

        private void LoadById(ulong id)
        {
            this.clearCurrentProcedure();

            if (this.data.tablePatientsToUSPs.ContainsKey(id))
            {
                this.procedures = this.data.tablePatientsToUSPs[id];
                this.textBoxDataPatientID.Text = id.ToString();
            }
            else
            {
                this.procedures = null;
                this.textBoxDataPatientID.Clear();
            }

            this.currentPatient = id;
        }

        private bool tryFindLoadByID()
        {
            ulong id;
            if (!ulong.TryParse(this.textBoxSearch.Text, out id))
                return false;
            LoadById(id);
            return true;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!tryFindLoad())
                return;
            displayTable();
        }
        ListBoxItem createListBoxItem(ulong id)
        {
            return new ListBoxItem("???", ulong.MaxValue);
            //TODO
        }

        private void displayTable()
        {
            this.clearCurrentProcedure();
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
    }
}
