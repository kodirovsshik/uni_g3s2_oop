namespace WindowsFormsApp1
{
    partial class FormProcedureTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonDetele = new System.Windows.Forms.Button();
            this.textBoxDataPatientID = new System.Windows.Forms.TextBox();
            this.textBoxDataProcedureID = new System.Windows.Forms.TextBox();
            this.labelDataPatientID = new System.Windows.Forms.Label();
            this.labelDataProcedureID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDataFIO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDataDateM = new System.Windows.Forms.ComboBox();
            this.textBoxDataDateY = new System.Windows.Forms.TextBox();
            this.textBoxDataDateD = new System.Windows.Forms.TextBox();
            this.textBoxDataFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxDataKind = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxDataType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(12, 33);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(309, 20);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID пациента или ФИО";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(309, 229);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonNew.Location = new System.Drawing.Point(38, 322);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(100, 44);
            this.buttonNew.TabIndex = 3;
            this.buttonNew.Text = "Создать";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonDetele
            // 
            this.buttonDetele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDetele.Location = new System.Drawing.Point(193, 322);
            this.buttonDetele.Name = "buttonDetele";
            this.buttonDetele.Size = new System.Drawing.Size(105, 44);
            this.buttonDetele.TabIndex = 4;
            this.buttonDetele.Text = "Удалить";
            this.buttonDetele.UseVisualStyleBackColor = true;
            this.buttonDetele.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxDataPatientID
            // 
            this.textBoxDataPatientID.Location = new System.Drawing.Point(336, 83);
            this.textBoxDataPatientID.Name = "textBoxDataPatientID";
            this.textBoxDataPatientID.ReadOnly = true;
            this.textBoxDataPatientID.Size = new System.Drawing.Size(120, 20);
            this.textBoxDataPatientID.TabIndex = 0;
            this.textBoxDataPatientID.TabStop = false;
            // 
            // textBoxDataProcedureID
            // 
            this.textBoxDataProcedureID.Location = new System.Drawing.Point(473, 83);
            this.textBoxDataProcedureID.Name = "textBoxDataProcedureID";
            this.textBoxDataProcedureID.ReadOnly = true;
            this.textBoxDataProcedureID.Size = new System.Drawing.Size(125, 20);
            this.textBoxDataProcedureID.TabIndex = 0;
            this.textBoxDataProcedureID.TabStop = false;
            // 
            // labelDataPatientID
            // 
            this.labelDataPatientID.AutoSize = true;
            this.labelDataPatientID.Location = new System.Drawing.Point(336, 64);
            this.labelDataPatientID.Name = "labelDataPatientID";
            this.labelDataPatientID.Size = new System.Drawing.Size(68, 13);
            this.labelDataPatientID.TabIndex = 8;
            this.labelDataPatientID.Text = "ID пациента";
            // 
            // labelDataProcedureID
            // 
            this.labelDataProcedureID.AutoSize = true;
            this.labelDataProcedureID.Location = new System.Drawing.Point(473, 64);
            this.labelDataProcedureID.Name = "labelDataProcedureID";
            this.labelDataProcedureID.Size = new System.Drawing.Size(93, 13);
            this.labelDataProcedureID.TabIndex = 9;
            this.labelDataProcedureID.Text = "ID исследования";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ФИО пациента";
            // 
            // textBoxDataFIO
            // 
            this.textBoxDataFIO.Location = new System.Drawing.Point(336, 33);
            this.textBoxDataFIO.Name = "textBoxDataFIO";
            this.textBoxDataFIO.ReadOnly = true;
            this.textBoxDataFIO.Size = new System.Drawing.Size(262, 20);
            this.textBoxDataFIO.TabIndex = 0;
            this.textBoxDataFIO.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Дата проведения исследования";
            // 
            // comboBoxDataDateM
            // 
            this.comboBoxDataDateM.FormattingEnabled = true;
            this.comboBoxDataDateM.Items.AddRange(new object[] {
            "01 Январь",
            "02 Февраль",
            "03 Март",
            "04 Апрель",
            "05 Май",
            "06 Июнь",
            "07 Июль",
            "08 Август",
            "09 Сентяррь",
            "10 Октябрь",
            "11 Ноябрь",
            "12 Декабрь"});
            this.comboBoxDataDateM.Location = new System.Drawing.Point(383, 148);
            this.comboBoxDataDateM.Name = "comboBoxDataDateM";
            this.comboBoxDataDateM.Size = new System.Drawing.Size(111, 21);
            this.comboBoxDataDateM.TabIndex = 6;
            // 
            // textBoxDataDateY
            // 
            this.textBoxDataDateY.Location = new System.Drawing.Point(500, 148);
            this.textBoxDataDateY.Name = "textBoxDataDateY";
            this.textBoxDataDateY.Size = new System.Drawing.Size(53, 20);
            this.textBoxDataDateY.TabIndex = 7;
            // 
            // textBoxDataDateD
            // 
            this.textBoxDataDateD.Location = new System.Drawing.Point(336, 148);
            this.textBoxDataDateD.Name = "textBoxDataDateD";
            this.textBoxDataDateD.Size = new System.Drawing.Size(41, 20);
            this.textBoxDataDateD.TabIndex = 5;
            // 
            // textBoxDataFile
            // 
            this.textBoxDataFile.Location = new System.Drawing.Point(336, 199);
            this.textBoxDataFile.Name = "textBoxDataFile";
            this.textBoxDataFile.Size = new System.Drawing.Size(237, 20);
            this.textBoxDataFile.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Файл с данными";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(580, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.AddExtension = false;
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "All files|*";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSave.Location = new System.Drawing.Point(370, 322);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(196, 41);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Сохранить изменения";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Исследования";
            // 
            // comboBoxDataKind
            // 
            this.comboBoxDataKind.FormattingEnabled = true;
            this.comboBoxDataKind.Items.AddRange(new object[] {
            "УЗИ брюшной полости",
            "УЗИ грудных желёз",
            "УЗИ мочевого пузыря",
            "УЗИ почек",
            "УЗИ надпочечников",
            "УЗИ молочных желёз",
            "УЗИ печени",
            "УЗИ поджелудочной железы",
            "УЗИ матки",
            "УЗИ органов малого таза",
            "УЗИ щитовидной железы",
            "УЗИ суставов",
            "УЗИ мягких тканей",
            "УЗИ лимфатических узлов",
            "УЗИ слюнных желез",
            "УЗИ плевральных полостей",
            "УЗИ яичников",
            "УЗИ плода"});
            this.comboBoxDataKind.Location = new System.Drawing.Point(336, 252);
            this.comboBoxDataKind.Name = "comboBoxDataKind";
            this.comboBoxDataKind.Size = new System.Drawing.Size(158, 21);
            this.comboBoxDataKind.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Вид исследования";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(497, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Тип исследования";
            // 
            // comboBoxDataType
            // 
            this.comboBoxDataType.FormattingEnabled = true;
            this.comboBoxDataType.Items.AddRange(new object[] {
            "2D",
            "3D",
            "3D во времени"});
            this.comboBoxDataType.Location = new System.Drawing.Point(500, 252);
            this.comboBoxDataType.Name = "comboBoxDataType";
            this.comboBoxDataType.Size = new System.Drawing.Size(109, 21);
            this.comboBoxDataType.TabIndex = 11;
            // 
            // FormProcedureTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 376);
            this.Controls.Add(this.comboBoxDataType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxDataKind);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDataFile);
            this.Controls.Add(this.textBoxDataDateD);
            this.Controls.Add(this.textBoxDataDateY);
            this.Controls.Add(this.comboBoxDataDateM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDataFIO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDataProcedureID);
            this.Controls.Add(this.labelDataPatientID);
            this.Controls.Add(this.textBoxDataProcedureID);
            this.Controls.Add(this.textBoxDataPatientID);
            this.Controls.Add(this.buttonDetele);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "FormProcedureTable";
            this.Text = "Таблица исследований";
            this.Load += new System.EventHandler(this.FormProcedureTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonDetele;
        private System.Windows.Forms.TextBox textBoxDataPatientID;
        private System.Windows.Forms.TextBox textBoxDataProcedureID;
        private System.Windows.Forms.Label labelDataPatientID;
        private System.Windows.Forms.Label labelDataProcedureID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDataFIO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDataDateM;
        private System.Windows.Forms.TextBox textBoxDataDateY;
        private System.Windows.Forms.TextBox textBoxDataDateD;
        private System.Windows.Forms.TextBox textBoxDataFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxDataKind;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxDataType;
    }
}