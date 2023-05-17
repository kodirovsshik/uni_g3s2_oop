namespace WindowsFormsApp1
{
    partial class FormPatientTable
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
            this.listBoxPatients = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearchFIO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDataF = new System.Windows.Forms.TextBox();
            this.textBoxDataI = new System.Windows.Forms.TextBox();
            this.textBoxDataO = new System.Windows.Forms.TextBox();
            this.labelDataF = new System.Windows.Forms.Label();
            this.labelDataI = new System.Windows.Forms.Label();
            this.labelDataO = new System.Windows.Forms.Label();
            this.labelDataBD = new System.Windows.Forms.Label();
            this.labelBDD = new System.Windows.Forms.Label();
            this.labelBDM = new System.Windows.Forms.Label();
            this.labelBDY = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBoxDBM = new System.Windows.Forms.ComboBox();
            this.textBoxDataY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSearchPatientID = new System.Windows.Forms.TextBox();
            this.textBoxDataID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRollback = new System.Windows.Forms.Button();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSearchProcedureID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxPatients
            // 
            this.listBoxPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBoxPatients.FormattingEnabled = true;
            this.listBoxPatients.ItemHeight = 16;
            this.listBoxPatients.Location = new System.Drawing.Point(12, 184);
            this.listBoxPatients.Name = "listBoxPatients";
            this.listBoxPatients.Size = new System.Drawing.Size(279, 276);
            this.listBoxPatients.TabIndex = 0;
            this.listBoxPatients.SelectedIndexChanged += new System.EventHandler(this.listBoxPatients_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAdd.Location = new System.Drawing.Point(23, 475);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(115, 30);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск по ФИО";
            // 
            // textBoxSearchFIO
            // 
            this.textBoxSearchFIO.Location = new System.Drawing.Point(12, 33);
            this.textBoxSearchFIO.Name = "textBoxSearchFIO";
            this.textBoxSearchFIO.Size = new System.Drawing.Size(279, 20);
            this.textBoxSearchFIO.TabIndex = 3;
            this.textBoxSearchFIO.EnabledChanged += new System.EventHandler(this.textBoxSearchFIO_EnabledChanged);
            this.textBoxSearchFIO.TextChanged += new System.EventHandler(this.textBoxSearchFIO_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(9, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Список пациентов";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDelete.Location = new System.Drawing.Point(159, 475);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(115, 30);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(325, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Редактирование информации";
            // 
            // textBoxDataF
            // 
            this.textBoxDataF.Enabled = false;
            this.textBoxDataF.Location = new System.Drawing.Point(325, 64);
            this.textBoxDataF.Name = "textBoxDataF";
            this.textBoxDataF.Size = new System.Drawing.Size(147, 20);
            this.textBoxDataF.TabIndex = 7;
            this.textBoxDataF.TextChanged += new System.EventHandler(this.textBoxDataF_TextChanged);
            // 
            // textBoxDataI
            // 
            this.textBoxDataI.Enabled = false;
            this.textBoxDataI.Location = new System.Drawing.Point(325, 107);
            this.textBoxDataI.Name = "textBoxDataI";
            this.textBoxDataI.Size = new System.Drawing.Size(147, 20);
            this.textBoxDataI.TabIndex = 8;
            this.textBoxDataI.TextChanged += new System.EventHandler(this.textBoxDataI_TextChanged);
            // 
            // textBoxDataO
            // 
            this.textBoxDataO.Enabled = false;
            this.textBoxDataO.Location = new System.Drawing.Point(485, 107);
            this.textBoxDataO.Name = "textBoxDataO";
            this.textBoxDataO.Size = new System.Drawing.Size(147, 20);
            this.textBoxDataO.TabIndex = 9;
            this.textBoxDataO.TextChanged += new System.EventHandler(this.textBoxDataO_TextChanged);
            // 
            // labelDataF
            // 
            this.labelDataF.AutoSize = true;
            this.labelDataF.Enabled = false;
            this.labelDataF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDataF.Location = new System.Drawing.Point(325, 45);
            this.labelDataF.Name = "labelDataF";
            this.labelDataF.Size = new System.Drawing.Size(70, 17);
            this.labelDataF.TabIndex = 10;
            this.labelDataF.Text = "Фамилия";
            // 
            // labelDataI
            // 
            this.labelDataI.AutoSize = true;
            this.labelDataI.Enabled = false;
            this.labelDataI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDataI.Location = new System.Drawing.Point(325, 87);
            this.labelDataI.Name = "labelDataI";
            this.labelDataI.Size = new System.Drawing.Size(35, 17);
            this.labelDataI.TabIndex = 11;
            this.labelDataI.Text = "Имя";
            // 
            // labelDataO
            // 
            this.labelDataO.AutoSize = true;
            this.labelDataO.Enabled = false;
            this.labelDataO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDataO.Location = new System.Drawing.Point(482, 87);
            this.labelDataO.Name = "labelDataO";
            this.labelDataO.Size = new System.Drawing.Size(71, 17);
            this.labelDataO.TabIndex = 12;
            this.labelDataO.Text = "Отчество";
            // 
            // labelDataBD
            // 
            this.labelDataBD.AutoSize = true;
            this.labelDataBD.Enabled = false;
            this.labelDataBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDataBD.Location = new System.Drawing.Point(325, 154);
            this.labelDataBD.Name = "labelDataBD";
            this.labelDataBD.Size = new System.Drawing.Size(111, 17);
            this.labelDataBD.TabIndex = 13;
            this.labelDataBD.Text = "Дата рождения";
            // 
            // labelBDD
            // 
            this.labelBDD.AutoSize = true;
            this.labelBDD.Enabled = false;
            this.labelBDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBDD.Location = new System.Drawing.Point(326, 182);
            this.labelBDD.Name = "labelBDD";
            this.labelBDD.Size = new System.Drawing.Size(42, 17);
            this.labelBDD.TabIndex = 14;
            this.labelBDD.Text = "День";
            // 
            // labelBDM
            // 
            this.labelBDM.AutoSize = true;
            this.labelBDM.Enabled = false;
            this.labelBDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBDM.Location = new System.Drawing.Point(396, 182);
            this.labelBDM.Name = "labelBDM";
            this.labelBDM.Size = new System.Drawing.Size(50, 17);
            this.labelBDM.TabIndex = 15;
            this.labelBDM.Text = "Месяц";
            // 
            // labelBDY
            // 
            this.labelBDY.AutoSize = true;
            this.labelBDY.Enabled = false;
            this.labelBDY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBDY.Location = new System.Drawing.Point(522, 182);
            this.labelBDY.Name = "labelBDY";
            this.labelBDY.Size = new System.Drawing.Size(32, 17);
            this.labelBDY.TabIndex = 16;
            this.labelBDY.Text = "Год";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(326, 202);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // comboBoxDBM
            // 
            this.comboBoxDBM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDBM.Enabled = false;
            this.comboBoxDBM.FormattingEnabled = true;
            this.comboBoxDBM.Items.AddRange(new object[] {
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
            this.comboBoxDBM.Location = new System.Drawing.Point(399, 200);
            this.comboBoxDBM.Name = "comboBoxDBM";
            this.comboBoxDBM.Size = new System.Drawing.Size(106, 21);
            this.comboBoxDBM.TabIndex = 19;
            this.comboBoxDBM.SelectedIndexChanged += new System.EventHandler(this.comboBoxDBM_SelectedIndexChanged);
            // 
            // textBoxDataY
            // 
            this.textBoxDataY.Enabled = false;
            this.textBoxDataY.Location = new System.Drawing.Point(525, 200);
            this.textBoxDataY.Name = "textBoxDataY";
            this.textBoxDataY.Size = new System.Drawing.Size(67, 20);
            this.textBoxDataY.TabIndex = 20;
            this.textBoxDataY.TextChanged += new System.EventHandler(this.textBoxDataY_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(23, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "ID пациента";
            // 
            // textBoxSearchPatientID
            // 
            this.textBoxSearchPatientID.Location = new System.Drawing.Point(23, 116);
            this.textBoxSearchPatientID.Name = "textBoxSearchPatientID";
            this.textBoxSearchPatientID.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchPatientID.TabIndex = 22;
            this.textBoxSearchPatientID.TextChanged += new System.EventHandler(this.textBoxSearchPatientID_TextChanged);
            // 
            // textBoxDataID
            // 
            this.textBoxDataID.Enabled = false;
            this.textBoxDataID.Location = new System.Drawing.Point(492, 272);
            this.textBoxDataID.Name = "textBoxDataID";
            this.textBoxDataID.Size = new System.Drawing.Size(100, 20);
            this.textBoxDataID.TabIndex = 23;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Enabled = false;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID.Location = new System.Drawing.Point(492, 254);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 17);
            this.labelID.TabIndex = 24;
            this.labelID.Text = "ID";
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(305, 475);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(167, 30);
            this.buttonSave.TabIndex = 25;
            this.buttonSave.Text = "Сохранить изменения";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRollback
            // 
            this.buttonRollback.Enabled = false;
            this.buttonRollback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRollback.Location = new System.Drawing.Point(485, 475);
            this.buttonRollback.Name = "buttonRollback";
            this.buttonRollback.Size = new System.Drawing.Size(167, 30);
            this.buttonRollback.TabIndex = 26;
            this.buttonRollback.Text = "Сбросить изменения";
            this.buttonRollback.UseVisualStyleBackColor = true;
            this.buttonRollback.Click += new System.EventHandler(this.buttonRollback_Click);
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Enabled = false;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.comboBoxGender.Location = new System.Drawing.Point(325, 271);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGender.TabIndex = 27;
            this.comboBoxGender.SelectedIndexChanged += new System.EventHandler(this.comboBoxGender_SelectedIndexChanged);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Enabled = false;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGender.Location = new System.Drawing.Point(329, 252);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(34, 17);
            this.labelGender.TabIndex = 28;
            this.labelGender.Text = "Пол";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(156, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "ID исследования";
            // 
            // textBoxSearchProcedureID
            // 
            this.textBoxSearchProcedureID.Location = new System.Drawing.Point(159, 116);
            this.textBoxSearchProcedureID.Name = "textBoxSearchProcedureID";
            this.textBoxSearchProcedureID.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchProcedureID.TabIndex = 30;
            this.textBoxSearchProcedureID.TextChanged += new System.EventHandler(this.textBoxSearchProcedureID_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Поиск по ID";
            // 
            // FormPatientTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 517);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxSearchProcedureID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.buttonRollback);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxDataID);
            this.Controls.Add(this.textBoxSearchPatientID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDataY);
            this.Controls.Add(this.comboBoxDBM);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelBDY);
            this.Controls.Add(this.labelBDM);
            this.Controls.Add(this.labelBDD);
            this.Controls.Add(this.labelDataBD);
            this.Controls.Add(this.labelDataO);
            this.Controls.Add(this.labelDataI);
            this.Controls.Add(this.labelDataF);
            this.Controls.Add(this.textBoxDataO);
            this.Controls.Add(this.textBoxDataI);
            this.Controls.Add(this.textBoxDataF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSearchFIO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxPatients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPatientTable";
            this.Text = "FormPatientTable";
            this.Load += new System.EventHandler(this.FormPatientTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPatients;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearchFIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDataF;
        private System.Windows.Forms.TextBox textBoxDataI;
        private System.Windows.Forms.TextBox textBoxDataO;
        private System.Windows.Forms.Label labelDataF;
        private System.Windows.Forms.Label labelDataI;
        private System.Windows.Forms.Label labelDataO;
        private System.Windows.Forms.Label labelDataBD;
        private System.Windows.Forms.Label labelBDD;
        private System.Windows.Forms.Label labelBDM;
        private System.Windows.Forms.Label labelBDY;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBoxDBM;
        private System.Windows.Forms.TextBox textBoxDataY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSearchPatientID;
        private System.Windows.Forms.TextBox textBoxDataID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRollback;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSearchProcedureID;
        private System.Windows.Forms.Label label8;
    }
}