namespace Proyecto_Final_Tecnicas
{
    partial class formMaterias
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTeacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCredits = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBoxCredit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxTeacher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.buttonAcept = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEditAcept = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBoxEditCredit = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxEditKey = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxEditTeacher = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxEditName = new System.Windows.Forms.TextBox();
            this.cmbBoxMaterias = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonDeleteMateria = new System.Windows.Forms.Button();
            this.cmbBoxDeleteMateria = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Location = new System.Drawing.Point(-1, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(474, 398);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(466, 372);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visualizar materia";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnKey,
            this.columnTeacher,
            this.columnCredits});
            this.listView1.Location = new System.Drawing.Point(1, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(469, 373);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Nombre:";
            this.columnName.Width = 183;
            // 
            // columnKey
            // 
            this.columnKey.Text = "Clave:";
            this.columnKey.Width = 62;
            // 
            // columnTeacher
            // 
            this.columnTeacher.Text = "Profesor:";
            this.columnTeacher.Width = 159;
            // 
            // columnCredits
            // 
            this.columnCredits.Text = "Créditos:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonExit);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.buttonAcept);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(466, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Agregar materia";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.White;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Image = global::Proyecto_Final_Tecnicas.Properties.Resources.Volver;
            this.buttonExit.Location = new System.Drawing.Point(308, 334);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(97, 38);
            this.buttonExit.TabIndex = 26;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbBoxCredit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxKey);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBoxTeacher);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(61, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 201);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los datos de la nueva materia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre:";
            // 
            // cmbBoxCredit
            // 
            this.cmbBoxCredit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxCredit.FormattingEnabled = true;
            this.cmbBoxCredit.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbBoxCredit.Location = new System.Drawing.Point(165, 164);
            this.cmbBoxCredit.Name = "cmbBoxCredit";
            this.cmbBoxCredit.Size = new System.Drawing.Size(121, 24);
            this.cmbBoxCredit.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Clave";
            // 
            // txtBoxKey
            // 
            this.txtBoxKey.Location = new System.Drawing.Point(165, 83);
            this.txtBoxKey.MaxLength = 15;
            this.txtBoxKey.Name = "txtBoxKey";
            this.txtBoxKey.Size = new System.Drawing.Size(121, 22);
            this.txtBoxKey.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Profesor:";
            // 
            // txtBoxTeacher
            // 
            this.txtBoxTeacher.Location = new System.Drawing.Point(165, 125);
            this.txtBoxTeacher.MaxLength = 50;
            this.txtBoxTeacher.Name = "txtBoxTeacher";
            this.txtBoxTeacher.Size = new System.Drawing.Size(121, 22);
            this.txtBoxTeacher.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cantidad de créditos:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(165, 44);
            this.txtBoxName.MaxLength = 50;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(121, 22);
            this.txtBoxName.TabIndex = 13;
            // 
            // buttonAcept
            // 
            this.buttonAcept.BackColor = System.Drawing.Color.White;
            this.buttonAcept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcept.Location = new System.Drawing.Point(61, 334);
            this.buttonAcept.Name = "buttonAcept";
            this.buttonAcept.Size = new System.Drawing.Size(97, 38);
            this.buttonAcept.TabIndex = 24;
            this.buttonAcept.Text = "Aceptar";
            this.buttonAcept.UseVisualStyleBackColor = false;
            this.buttonAcept.Click += new System.EventHandler(this.buttonAcept_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.buttonEditAcept);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.cmbBoxMaterias);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(466, 372);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modificar materias";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(308, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 38);
            this.button1.TabIndex = 30;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonEditAcept
            // 
            this.buttonEditAcept.BackColor = System.Drawing.Color.White;
            this.buttonEditAcept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditAcept.Location = new System.Drawing.Point(61, 334);
            this.buttonEditAcept.Name = "buttonEditAcept";
            this.buttonEditAcept.Size = new System.Drawing.Size(97, 38);
            this.buttonEditAcept.TabIndex = 29;
            this.buttonEditAcept.Text = "Aceptar";
            this.buttonEditAcept.UseVisualStyleBackColor = false;
            this.buttonEditAcept.Click += new System.EventHandler(this.buttonEditAcept_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbBoxEditCredit);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtBoxEditKey);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtBoxEditTeacher);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtBoxEditName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(61, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 201);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modifique los datos de la materia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nombre:";
            // 
            // cmbBoxEditCredit
            // 
            this.cmbBoxEditCredit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxEditCredit.FormattingEnabled = true;
            this.cmbBoxEditCredit.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbBoxEditCredit.Location = new System.Drawing.Point(165, 164);
            this.cmbBoxEditCredit.Name = "cmbBoxEditCredit";
            this.cmbBoxEditCredit.Size = new System.Drawing.Size(121, 24);
            this.cmbBoxEditCredit.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Clave:";
            // 
            // txtBoxEditKey
            // 
            this.txtBoxEditKey.Location = new System.Drawing.Point(165, 83);
            this.txtBoxEditKey.MaxLength = 15;
            this.txtBoxEditKey.Name = "txtBoxEditKey";
            this.txtBoxEditKey.Size = new System.Drawing.Size(121, 22);
            this.txtBoxEditKey.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Profesor:";
            // 
            // txtBoxEditTeacher
            // 
            this.txtBoxEditTeacher.Location = new System.Drawing.Point(165, 125);
            this.txtBoxEditTeacher.MaxLength = 50;
            this.txtBoxEditTeacher.Name = "txtBoxEditTeacher";
            this.txtBoxEditTeacher.Size = new System.Drawing.Size(121, 22);
            this.txtBoxEditTeacher.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Cantidad de créditos:";
            // 
            // txtBoxEditName
            // 
            this.txtBoxEditName.Location = new System.Drawing.Point(165, 44);
            this.txtBoxEditName.MaxLength = 50;
            this.txtBoxEditName.Name = "txtBoxEditName";
            this.txtBoxEditName.Size = new System.Drawing.Size(121, 22);
            this.txtBoxEditName.TabIndex = 13;
            // 
            // cmbBoxMaterias
            // 
            this.cmbBoxMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxMaterias.FormattingEnabled = true;
            this.cmbBoxMaterias.Location = new System.Drawing.Point(141, 52);
            this.cmbBoxMaterias.Name = "cmbBoxMaterias";
            this.cmbBoxMaterias.Size = new System.Drawing.Size(206, 21);
            this.cmbBoxMaterias.TabIndex = 27;
            this.cmbBoxMaterias.SelectedIndexChanged += new System.EventHandler(this.cmbBoxMaterias_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Seleccione la materia que desee modificar:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(753, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Créditos:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(496, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Profesor:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonBack);
            this.tabPage4.Controls.Add(this.buttonDeleteMateria);
            this.tabPage4.Controls.Add(this.cmbBoxDeleteMateria);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.pictureBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(466, 372);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Eliminar materia";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.White;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(288, 324);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(97, 38);
            this.buttonBack.TabIndex = 32;
            this.buttonBack.Text = "Volver";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonDeleteMateria
            // 
            this.buttonDeleteMateria.BackColor = System.Drawing.Color.White;
            this.buttonDeleteMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteMateria.Location = new System.Drawing.Point(82, 324);
            this.buttonDeleteMateria.Name = "buttonDeleteMateria";
            this.buttonDeleteMateria.Size = new System.Drawing.Size(97, 38);
            this.buttonDeleteMateria.TabIndex = 31;
            this.buttonDeleteMateria.Text = "Eliminar";
            this.buttonDeleteMateria.UseVisualStyleBackColor = false;
            this.buttonDeleteMateria.Click += new System.EventHandler(this.buttonDeleteMateria_Click);
            // 
            // cmbBoxDeleteMateria
            // 
            this.cmbBoxDeleteMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxDeleteMateria.FormattingEnabled = true;
            this.cmbBoxDeleteMateria.Location = new System.Drawing.Point(131, 227);
            this.cmbBoxDeleteMateria.Name = "cmbBoxDeleteMateria";
            this.cmbBoxDeleteMateria.Size = new System.Drawing.Size(206, 21);
            this.cmbBoxDeleteMateria.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(105, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(259, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "Seleccione la materia que desee eliminar:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final_Tecnicas.Properties.Resources.UNIPROM_Logo_Full_Size__Only_Name_;
            this.pictureBox1.Location = new System.Drawing.Point(61, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Final_Tecnicas.Properties.Resources.UNIPROM_Logo_Full_Size__Only_Name_;
            this.pictureBox2.Location = new System.Drawing.Point(67, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(344, 165);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // formMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 397);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formMaterias";
            this.Text = "formMaterias";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.formMaterias_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnKey;
        private System.Windows.Forms.ColumnHeader columnTeacher;
        private System.Windows.Forms.ColumnHeader columnCredits;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBoxCredit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxTeacher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Button buttonAcept;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonEditAcept;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBoxEditCredit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxEditKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxEditTeacher;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxEditName;
        private System.Windows.Forms.ComboBox cmbBoxMaterias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cmbBoxDeleteMateria;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonDeleteMateria;
    }
}