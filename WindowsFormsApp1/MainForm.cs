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
			this.menuItemFileClose.Enabled = false;
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
				return false;
			}
			
			var serializer = new XmlSerializer(typeof(DataStore));
			serializer.Serialize(writer, this.data);
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
				return false;
			}
			var serializer = new XmlSerializer(typeof(DataStore));
			this.data = (DataStore)serializer.Deserialize(reader);
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

		private void actionSwitchFile(string fname) {

			this.data.currentFilePath = fname;
			this.labelFileName.Text = fname.Substring(1 + fname.LastIndexOf('\\'));
		}
		private bool actionSwitchFileAndSave(string fname) {
			fname = cannonicalize(fname);
			if (!this.actionWriteDataToFile(this.data.currentFilePath))
				return false;
			actionSwitchFile(fname);
			return true;
		}
		private bool actionSwitchFileAndRead(string fname) {
			fname = cannonicalize(fname);
			if (!this.actionReadDataFromFile(this.data.currentFilePath))
				return false;
			actionSwitchFile(fname);
			return true;
		}

		private void menuItemFileSave_Click(object sender, EventArgs e) {
			this.menuItemFileSave_Action();
		}
		private bool menuItemFileSave_Action() {
			return this.actionWriteDataToFile(this.data.currentFilePath);
		}

		private bool menuItemFileSaveAs_Action(object sender, EventArgs e) {
			if (this.saveFileDialog1.ShowDialog(this) != DialogResult.OK)
				return false;
			return this.actionSwitchFileAndSave(this.saveFileDialog1.FileName);
		}
		private void menuItemFileSaveAs_Click(object sender, EventArgs e) {
		}

		private bool actionSaveUnchecked() {
			if (!this.data.dataModified)
				return true;

			var promptResult = MessageBox.Show(this, "Внимание",
					"Имеются несохранённые изменения.\nЖелаете сохранить их?",
					MessageBoxButtons.YesNoCancel);

			if (promptResult != DialogResult.OK)
				return false;

			return this.menuItemFileSave_Action();
		}

		private void menuItemFileOpen_Click(object sender, EventArgs e) {
			if (!this.actionSaveUnchecked())
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
			if (!this.actionSaveUnchecked())
				return;
			this.actionNewFileUnchecked();
		}

		private void buttonOpenTablePatient_Click(object sender, EventArgs e)
		{
			var f = new FormPatientTable(this.data);
			this.Hide();
			f.ShowDialog();
			this.Show();
		}

		private void buttonOpenTablePrcedure_Click(object sender, EventArgs e)
		{
			var f = new FormProcedureTable(this.data);
			this.Hide();
			f.ShowDialog();
			this.Show();
		}
	}
}
