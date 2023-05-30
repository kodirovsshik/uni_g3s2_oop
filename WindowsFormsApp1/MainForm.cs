using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            this.InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.actionNewFileUnchecked();
        }

        private void resetFormElements()
        {
            this.labelFileName.Text = "(новый файл)";
            this.labelPatientCount.Text = "0";
            this.labelProcedureCount.Text = "0";
            this.buttonClose.Enabled = false;
            this.buttonSave.Enabled = false;
            this.menuItemFileClose.Enabled = false;
            this.menuItemFileSave.Enabled = false;

        }

        private void updateFormElements()
        {
            this.labelFileName.Text = this.data.currentFilePath;
            if (this.labelFileName.Text.Length == 0)
                this.labelFileName.Text = "(новый файл)";

            this.labelPatientCount.Text = this.data.tablePatients.Count.ToString();
            this.labelProcedureCount.Text = this.data.tableProcedures.Count.ToString();
            this.buttonClose.Enabled = this.data.currentFilePath.Length != 0;
            this.buttonSave.Enabled = this.data.dataModified;
            this.menuItemFileClose.Enabled = this.buttonClose.Enabled;
            this.menuItemFileSave.Enabled = this.buttonSave.Enabled;
        }

        private void menuItemAbout_Click(object sender, EventArgs e) {
            MessageBox.Show(this,
                "Данная программа была разработана в рамках курса\n" +
                "\"Объектно-ориентированное программирование\"\n" +
                "студентом группы А01ИСТ2\nЕгоровым Станиславом Сергеевичем",
                "О программе");
        }

        private void menuItemExit_Click(object sender, EventArgs e) {
            this.Close();
        }


        private DataStore data;

        private bool actionWriteDataToFile(string fname) {
            TextWriter writer;
            try
            {
                writer = new StreamWriter(fname);
            }
            catch (System.UnauthorizedAccessException)
            {
                MessageBox.Show(this, "Не удалось открыть файл для записи:\n" + fname, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            var serializer = new XmlSerializer(typeof(DataStore));
            serializer.Serialize(writer, this.data);
            writer.Close();
            return true;
        }

        private bool actionReadDataFromFile(string fname)
        {
            TextReader reader;
            try
            {
                reader = new StreamReader(fname);
            }
            catch (System.UnauthorizedAccessException)
            {
                MessageBox.Show(this, "Не удалось открыть файл для чтения:\n" + fname, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            var serializer = new XmlSerializer(typeof(DataStore));
            this.data = (DataStore)serializer.Deserialize(reader);
            this.data.dataModified = false;
            this.data.currentFilePath = fname;
            reader.Close();
            return true;
        }


        private void actionNewFileUnchecked() {
            this.data = new DataStore();
            this.resetFormElements();
        }

        static private bool checkExtension(string fname, string desired) {
            return fname.Substring(fname.IndexOf(".") + 1) == desired;
        }
        static private string cannonicalize(string fname) {
            fname = fname.Trim();
            if (!checkExtension(fname, "xml"))
                fname += ".xml";
            return fname;
        }

        private void actionSwitchFilename(string fname) {
            this.data.currentFilePath = fname;
            this.labelFileName.Text = fname.Substring(1 + fname.LastIndexOf('\\'));
        }
        private bool actionSwitchFileAndSave(string fname) {
            fname = cannonicalize(fname);
            if (!this.actionWriteDataToFile(fname))
                return false;

            actionSwitchFilename(fname);
            this.data.dataModified = false;
            updateFormElements();
            return true;
        }
        private bool actionSwitchFileAndRead(string fname) {
            fname = cannonicalize(fname);
            if (!this.actionReadDataFromFile(fname))
                return false;
            actionSwitchFilename(fname);
            updateFormElements();
            return true;
        }

        private void menuItemFileSave_Click(object sender, EventArgs e) {
            this.actionSaveCurrent();
        }
        private bool hasSaveFilename()
        {
            return this.data.currentFilePath.Length != 0;
        }

        private bool actionSaveCurrent() {
            if (!this.hasSaveFilename())
                return this.actionSaveCurrentAs();

            bool writeOk = this.actionWriteDataToFile(this.data.currentFilePath);
            if (writeOk)
            {
                this.data.dataModified = false;
                updateFormElements();
            }

            return writeOk;
        }

        private bool actionSaveCurrentAs() {
            this.saveFileDialog1.FileName = "";
            if (this.saveFileDialog1.ShowDialog(this) != DialogResult.OK)
                return false;
            return this.actionSwitchFileAndSave(this.saveFileDialog1.FileName);
        }
        private void menuItemFileSaveAs_Click(object sender, EventArgs e) {
            this.actionSaveCurrentAs();
        }

        private bool promptSaveIfModified() {
            if (!this.data.dataModified)
                return true;

            var promptResult = MessageBox.Show(this,
                "Имеются несохранённые изменения.\nЖелаете сохранить их?",
                "Внимание",
                MessageBoxButtons.YesNoCancel
            );

            if (promptResult == DialogResult.OK)
                return this.actionSaveCurrent();

            if (promptResult == DialogResult.No)
                return true;

            return false;
        }

        private void menuItemFileOpen_Click(object sender, EventArgs e) {
            if (!this.promptSaveIfModified())
                return;

            if (this.openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            this.actionSwitchFileAndRead(this.openFileDialog1.FileName);
        }

        private void menuItemFileSaveCopyAs_Click(object sender, EventArgs e) {
            if (this.saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            this.actionWriteDataToFile(this.saveFileDialog1.FileName);
        }

        private void menuItemFileNew_Click(object sender, EventArgs e) {
            if (!this.promptSaveIfModified())
                return;
            this.actionNewFileUnchecked();
        }

        private void buttonOpenTablePatient_Click(object sender, EventArgs e)
        {
            var f = new FormPatientTable(this.data);
            this.Hide();
            f.ShowDialog();
            updateFormElements();
            this.Show();
        }

        private void buttonOpenTablePrcedure_Click(object sender, EventArgs e)
        {
            var f = new FormProcedureTable(this.data);
            this.Hide();
            f.ShowDialog();
            updateFormElements();
            this.Show();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.actionSaveCurrent();
        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            this.actionSaveCurrentAs();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (!this.promptSaveIfModified())
                return;
            this.data = new DataStore();
            updateFormElements();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (!this.promptSaveIfModified())
                return;
            this.openFileDialog1.FileName = "";
            if (this.openFileDialog1.ShowDialog(this) != DialogResult.OK)
                return;
            actionSwitchFileAndRead(this.openFileDialog1.FileName);
        }
    }
}
