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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBoxMaterias = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
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
            this.tabControl.Size = new System.Drawing.Size(476, 398);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonExit);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.buttonAcept);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(468, 372);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar materia";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.White;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(306, 331);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(97, 38);
            this.buttonExit.TabIndex = 18;
            this.buttonExit.Text = "Salir";
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
            this.groupBox1.Location = new System.Drawing.Point(59, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 201);
            this.groupBox1.TabIndex = 16;
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
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(121, 22);
            this.txtBoxName.TabIndex = 13;
            // 
            // buttonAcept
            // 
            this.buttonAcept.BackColor = System.Drawing.Color.White;
            this.buttonAcept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcept.Location = new System.Drawing.Point(59, 331);
            this.buttonAcept.Name = "buttonAcept";
            this.buttonAcept.Size = new System.Drawing.Size(97, 38);
            this.buttonAcept.TabIndex = 17;
            this.buttonAcept.Text = "Aceptar";
            this.buttonAcept.UseVisualStyleBackColor = false;
            this.buttonAcept.Click += new System.EventHandler(this.buttonAcept_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final_Tecnicas.Properties.Resources.UNIPROM_Logo_Full_Size__Only_Name_;
            this.pictureBox1.Location = new System.Drawing.Point(59, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbBoxMaterias);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(468, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar materia";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(468, 372);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Visualizar materias";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(468, 372);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Eliminar materia";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Seleccione la materia que desee modificar:";
            // 
            // cmbBoxMaterias
            // 
            this.cmbBoxMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxMaterias.FormattingEnabled = true;
            this.cmbBoxMaterias.Location = new System.Drawing.Point(225, 20);
            this.cmbBoxMaterias.Name = "cmbBoxMaterias";
            this.cmbBoxMaterias.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxMaterias.TabIndex = 1;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox cmbBoxCredit;
        private System.Windows.Forms.TextBox txtBoxKey;
        private System.Windows.Forms.TextBox txtBoxTeacher;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAcept;
        private System.Windows.Forms.ComboBox cmbBoxMaterias;
        private System.Windows.Forms.Label label5;
    }
}