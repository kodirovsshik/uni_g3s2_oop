
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.labelTextFileName = new System.Windows.Forms.Label();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItemFile = new System.Windows.Forms.MenuItem();
            this.menuItemFileNew = new System.Windows.Forms.MenuItem();
            this.menuItemFileOpen = new System.Windows.Forms.MenuItem();
            this.menuItemFileClose = new System.Windows.Forms.MenuItem();
            this.menuItemFileSave = new System.Windows.Forms.MenuItem();
            this.menuItemFileSaveAs = new System.Windows.Forms.MenuItem();
            this.menuItemFileSaveCopyAs = new System.Windows.Forms.MenuItem();
            this.menuItemAbout = new System.Windows.Forms.MenuItem();
            this.menuItemExit = new System.Windows.Forms.MenuItem();
            this.labelFileName = new System.Windows.Forms.Label();
            this.labelTextPatientCount = new System.Windows.Forms.Label();
            this.labelTextProcedureCount = new System.Windows.Forms.Label();
            this.labelPatientCount = new System.Windows.Forms.Label();
            this.labelProcedureCount = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonOpenTablePatient = new System.Windows.Forms.Button();
            this.buttonOpenTablePrcedure = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "XML files|*.xml";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xml";
            this.saveFileDialog1.Filter = "XML files|*.xml";
            this.saveFileDialog1.InitialDirectory = ".";
            // 
            // labelTextFileName
            // 
            this.labelTextFileName.AutoSize = true;
            this.labelTextFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextFileName.Location = new System.Drawing.Point(12, 9);
            this.labelTextFileName.Name = "labelTextFileName";
            this.labelTextFileName.Size = new System.Drawing.Size(209, 20);
            this.labelTextFileName.TabIndex = 0;
            this.labelTextFileName.Text = "Текущий файл с данными:";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFile,
            this.menuItemAbout,
            this.menuItemExit});
            // 
            // menuItemFile
            // 
            this.menuItemFile.Index = 0;
            this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFileNew,
            this.menuItemFileOpen,
            this.menuItemFileClose,
            this.menuItemFileSave,
            this.menuItemFileSaveAs,
            this.menuItemFileSaveCopyAs});
            this.menuItemFile.Text = "Файл";
            // 
            // menuItemFileNew
            // 
            this.menuItemFileNew.Index = 0;
            this.menuItemFileNew.Text = "Новый";
            this.menuItemFileNew.Click += new System.EventHandler(this.menuItemFileNew_Click);
            // 
            // menuItemFileOpen
            // 
            this.menuItemFileOpen.Index = 1;
            this.menuItemFileOpen.Text = "Открыть";
            this.menuItemFileOpen.Click += new System.EventHandler(this.menuItemFileOpen_Click);
            // 
            // menuItemFileClose
            // 
            this.menuItemFileClose.Index = 2;
            this.menuItemFileClose.Text = "Закрыть";
            // 
            // menuItemFileSave
            // 
            this.menuItemFileSave.Index = 3;
            this.menuItemFileSave.Text = "Сохранить";
            this.menuItemFileSave.Click += new System.EventHandler(this.menuItemFileSave_Click);
            // 
            // menuItemFileSaveAs
            // 
            this.menuItemFileSaveAs.Index = 4;
            this.menuItemFileSaveAs.Text = "Сохранить как";
            this.menuItemFileSaveAs.Click += new System.EventHandler(this.menuItemFileSaveAs_Click);
            // 
            // menuItemFileSaveCopyAs
            // 
            this.menuItemFileSaveCopyAs.Index = 5;
            this.menuItemFileSaveCopyAs.Text = "Сохранить копию";
            this.menuItemFileSaveCopyAs.Click += new System.EventHandler(this.menuItemFileSaveCopyAs_Click);
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Index = 1;
            this.menuItemAbout.Text = "О программе";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Index = 2;
            this.menuItemExit.Text = "Выход";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFileName.Location = new System.Drawing.Point(227, 9);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(21, 20);
            this.labelFileName.TabIndex = 1;
            this.labelFileName.Text = "...";
            // 
            // labelTextPatientCount
            // 
            this.labelTextPatientCount.AutoSize = true;
            this.labelTextPatientCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextPatientCount.Location = new System.Drawing.Point(12, 124);
            this.labelTextPatientCount.Name = "labelTextPatientCount";
            this.labelTextPatientCount.Size = new System.Drawing.Size(189, 20);
            this.labelTextPatientCount.TabIndex = 2;
            this.labelTextPatientCount.Text = "Количество пациентов:";
            // 
            // labelTextProcedureCount
            // 
            this.labelTextProcedureCount.AutoSize = true;
            this.labelTextProcedureCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextProcedureCount.Location = new System.Drawing.Point(12, 164);
            this.labelTextProcedureCount.Name = "labelTextProcedureCount";
            this.labelTextProcedureCount.Size = new System.Drawing.Size(180, 20);
            this.labelTextProcedureCount.TabIndex = 3;
            this.labelTextProcedureCount.Text = "Количество процедур:";
            // 
            // labelPatientCount
            // 
            this.labelPatientCount.AutoSize = true;
            this.labelPatientCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatientCount.Location = new System.Drawing.Point(207, 124);
            this.labelPatientCount.Name = "labelPatientCount";
            this.labelPatientCount.Size = new System.Drawing.Size(21, 20);
            this.labelPatientCount.TabIndex = 4;
            this.labelPatientCount.Text = "...";
            // 
            // labelProcedureCount
            // 
            this.labelProcedureCount.AutoSize = true;
            this.labelProcedureCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProcedureCount.Location = new System.Drawing.Point(198, 164);
            this.labelProcedureCount.Name = "labelProcedureCount";
            this.labelProcedureCount.Size = new System.Drawing.Size(21, 20);
            this.labelProcedureCount.TabIndex = 5;
            this.labelProcedureCount.Text = "...";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen.Location = new System.Drawing.Point(16, 42);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(102, 34);
            this.buttonOpen.TabIndex = 6;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(232, 42);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(102, 34);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(340, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 34);
            this.button3.TabIndex = 8;
            this.button3.Text = "Сохранить как";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(124, 42);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(102, 34);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(464, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Сохранить копию";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonOpenTablePatient
            // 
            this.buttonOpenTablePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenTablePatient.Location = new System.Drawing.Point(263, 118);
            this.buttonOpenTablePatient.Name = "buttonOpenTablePatient";
            this.buttonOpenTablePatient.Size = new System.Drawing.Size(261, 34);
            this.buttonOpenTablePatient.TabIndex = 11;
            this.buttonOpenTablePatient.Text = "Открыть таблицу пациентов";
            this.buttonOpenTablePatient.UseVisualStyleBackColor = true;
            this.buttonOpenTablePatient.Click += new System.EventHandler(this.buttonOpenTablePatient_Click);
            // 
            // buttonOpenTablePrcedure
            // 
            this.buttonOpenTablePrcedure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenTablePrcedure.Location = new System.Drawing.Point(263, 158);
            this.buttonOpenTablePrcedure.Name = "buttonOpenTablePrcedure";
            this.buttonOpenTablePrcedure.Size = new System.Drawing.Size(261, 34);
            this.buttonOpenTablePrcedure.TabIndex = 12;
            this.buttonOpenTablePrcedure.Text = "Открыть таблицу процедур";
            this.buttonOpenTablePrcedure.UseVisualStyleBackColor = true;
            this.buttonOpenTablePrcedure.Click += new System.EventHandler(this.buttonOpenTablePrcedure_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(619, 223);
            this.Controls.Add(this.buttonOpenTablePrcedure);
            this.Controls.Add(this.buttonOpenTablePatient);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.labelProcedureCount);
            this.Controls.Add(this.labelPatientCount);
            this.Controls.Add(this.labelTextProcedureCount);
            this.Controls.Add(this.labelTextPatientCount);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.labelTextFileName);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labelTextFileName;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItemFile;
        private System.Windows.Forms.MenuItem menuItemFileOpen;
        private System.Windows.Forms.MenuItem menuItemFileSave;
        private System.Windows.Forms.MenuItem menuItemAbout;
        private System.Windows.Forms.MenuItem menuItemExit;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.MenuItem menuItemFileNew;
        private System.Windows.Forms.MenuItem menuItemFileSaveAs;
        private System.Windows.Forms.Label labelTextPatientCount;
        private System.Windows.Forms.Label labelTextProcedureCount;
        private System.Windows.Forms.Label labelPatientCount;
        private System.Windows.Forms.Label labelProcedureCount;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuItem menuItemFileClose;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.MenuItem menuItemFileSaveCopyAs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonOpenTablePatient;
        private System.Windows.Forms.Button buttonOpenTablePrcedure;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

