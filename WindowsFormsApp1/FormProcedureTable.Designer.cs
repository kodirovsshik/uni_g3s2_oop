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
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxDataPatientID = new System.Windows.Forms.TextBox();
            this.textBoxDataProcedureID = new System.Windows.Forms.TextBox();
            this.labelDataPatientID = new System.Windows.Forms.Label();
            this.labelDataProcedureID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
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
            this.textBoxSearch.Size = new System.Drawing.Size(212, 20);
            this.textBoxSearch.TabIndex = 0;
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
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 225);
            this.listBox1.TabIndex = 3;
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonNew.Location = new System.Drawing.Point(12, 322);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(100, 44);
            this.buttonNew.TabIndex = 4;
            this.buttonNew.Text = "Создать";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(119, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBoxDataPatientID
            // 
            this.textBoxDataPatientID.Enabled = false;
            this.textBoxDataPatientID.Location = new System.Drawing.Point(253, 83);
            this.textBoxDataPatientID.Name = "textBoxDataPatientID";
            this.textBoxDataPatientID.Size = new System.Drawing.Size(100, 20);
            this.textBoxDataPatientID.TabIndex = 6;
            // 
            // textBoxDataProcedureID
            // 
            this.textBoxDataProcedureID.Enabled = false;
            this.textBoxDataProcedureID.Location = new System.Drawing.Point(390, 82);
            this.textBoxDataProcedureID.Name = "textBoxDataProcedureID";
            this.textBoxDataProcedureID.Size = new System.Drawing.Size(100, 20);
            this.textBoxDataProcedureID.TabIndex = 7;
            // 
            // labelDataPatientID
            // 
            this.labelDataPatientID.AutoSize = true;
            this.labelDataPatientID.Location = new System.Drawing.Point(253, 64);
            this.labelDataPatientID.Name = "labelDataPatientID";
            this.labelDataPatientID.Size = new System.Drawing.Size(68, 13);
            this.labelDataPatientID.TabIndex = 8;
            this.labelDataPatientID.Text = "ID пациента";
            // 
            // labelDataProcedureID
            // 
            this.labelDataProcedureID.AutoSize = true;
            this.labelDataProcedureID.Location = new System.Drawing.Point(390, 63);
            this.labelDataProcedureID.Name = "labelDataProcedureID";
            this.labelDataProcedureID.Size = new System.Drawing.Size(93, 13);
            this.labelDataProcedureID.TabIndex = 9;
            this.labelDataProcedureID.Text = "ID исследования";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ФИО пациента";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(253, 33);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(237, 20);
            this.textBox4.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 119);
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
            this.comboBoxDataDateM.Location = new System.Drawing.Point(300, 135);
            this.comboBoxDataDateM.Name = "comboBoxDataDateM";
            this.comboBoxDataDateM.Size = new System.Drawing.Size(98, 21);
            this.comboBoxDataDateM.TabIndex = 15;
            // 
            // textBoxDataDateY
            // 
            this.textBoxDataDateY.Location = new System.Drawing.Point(405, 135);
            this.textBoxDataDateY.Name = "textBoxDataDateY";
            this.textBoxDataDateY.Size = new System.Drawing.Size(53, 20);
            this.textBoxDataDateY.TabIndex = 16;
            // 
            // textBoxDataDateD
            // 
            this.textBoxDataDateD.Location = new System.Drawing.Point(253, 135);
            this.textBoxDataDateD.Name = "textBoxDataDateD";
            this.textBoxDataDateD.Size = new System.Drawing.Size(41, 20);
            this.textBoxDataDateD.TabIndex = 17;
            // 
            // textBoxDataFile
            // 
            this.textBoxDataFile.Location = new System.Drawing.Point(253, 186);
            this.textBoxDataFile.Name = "textBoxDataFile";
            this.textBoxDataFile.Size = new System.Drawing.Size(218, 20);
            this.textBoxDataFile.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Файл с данными";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(481, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSave.Location = new System.Drawing.Point(275, 322);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(196, 41);
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "Сохранить изменения";
            this.buttonSave.UseVisualStyleBackColor = true;
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
            this.comboBoxDataKind.Location = new System.Drawing.Point(253, 239);
            this.comboBoxDataKind.Name = "comboBoxDataKind";
            this.comboBoxDataKind.Size = new System.Drawing.Size(158, 21);
            this.comboBoxDataKind.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Вид исследования";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 220);
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
            this.comboBoxDataType.Location = new System.Drawing.Point(417, 239);
            this.comboBoxDataType.Name = "comboBoxDataType";
            this.comboBoxDataType.Size = new System.Drawing.Size(93, 21);
            this.comboBoxDataType.TabIndex = 28;
            // 
            // FormProcedureTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 376);
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
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDataProcedureID);
            this.Controls.Add(this.labelDataPatientID);
            this.Controls.Add(this.textBoxDataProcedureID);
            this.Controls.Add(this.textBoxDataPatientID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "FormProcedureTable";
            this.Text = "FormProcedureTable";
            this.Load += new System.EventHandler(this.FormProcedureTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxDataPatientID;
        private System.Windows.Forms.TextBox textBoxDataProcedureID;
        private System.Windows.Forms.Label labelDataPatientID;
        private System.Windows.Forms.Label labelDataProcedureID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
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