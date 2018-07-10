namespace Proyecto_Final_Tecnicas
{
    partial class formRegisterStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRegisterStudent));
            this.cmbBoxCarrera = new System.Windows.Forms.ComboBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.checkedListBoxMaterias = new System.Windows.Forms.CheckedListBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBoxCarrera
            // 
            this.cmbBoxCarrera.BackColor = System.Drawing.Color.White;
            this.cmbBoxCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxCarrera.FormattingEnabled = true;
            this.cmbBoxCarrera.Items.AddRange(new object[] {
            "Licenciatura en Biotecnología",
            "Lic. en Estadísticas y Ciencias Act.",
            "Doctor en Medicina",
            "Doctor en Odontología",
            "Lic. en Cine y Comunicación",
            "Lic. en Comunicación Social",
            "Licenciatura en Psicología",
            "Diseño Industrial",
            "Ingeniería Civil",
            "Ingeniería de Sistemas",
            "Ingeniería de Software",
            "Ingeniería Eléctrica",
            "Ingeniería Electrónica",
            "Ingeniería en Ciberseguridad",
            "Ingeniería Industrial",
            "Ingeniería Mecánica",
            "Ingeniería Mecatrónica",
            "Administración y Gestión de Negocios",
            "Contabilidad y Auditoría Empresarial",
            "Economía",
            "Licenciatura en Ingeniería Comercial",
            "Mercadeo y Negocios Electrónicos"});
            this.cmbBoxCarrera.Location = new System.Drawing.Point(117, 313);
            this.cmbBoxCarrera.Name = "cmbBoxCarrera";
            this.cmbBoxCarrera.Size = new System.Drawing.Size(238, 21);
            this.cmbBoxCarrera.TabIndex = 14;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(117, 250);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(121, 20);
            this.txtBoxName.TabIndex = 13;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(117, 281);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(121, 20);
            this.txtBoxPassword.TabIndex = 10;
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(117, 220);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(121, 20);
            this.txtBoxID.TabIndex = 9;
            this.txtBoxID.TextChanged += new System.EventHandler(this.txtBoxID_TextChanged);
            // 
            // checkedListBoxMaterias
            // 
            this.checkedListBoxMaterias.BackColor = System.Drawing.Color.White;
            this.checkedListBoxMaterias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxMaterias.CheckOnClick = true;
            this.checkedListBoxMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxMaterias.FormattingEnabled = true;
            this.checkedListBoxMaterias.Location = new System.Drawing.Point(463, 220);
            this.checkedListBoxMaterias.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.checkedListBoxMaterias.Name = "checkedListBoxMaterias";
            this.checkedListBoxMaterias.Size = new System.Drawing.Size(177, 170);
            this.checkedListBoxMaterias.TabIndex = 14;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Proyecto_Final_Tecnicas.Properties.Resources.Carrera;
            this.pictureBox7.Location = new System.Drawing.Point(83, 314);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 20);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 21;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Proyecto_Final_Tecnicas.Properties.Resources.Password;
            this.pictureBox6.Location = new System.Drawing.Point(83, 281);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Proyecto_Final_Tecnicas.Properties.Resources.Name;
            this.pictureBox5.Location = new System.Drawing.Point(83, 250);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Proyecto_Final_Tecnicas.Properties.Resources.ID;
            this.pictureBox4.Location = new System.Drawing.Point(83, 220);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.White;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Image = global::Proyecto_Final_Tecnicas.Properties.Resources.Volver;
            this.buttonBack.Location = new System.Drawing.Point(659, 356);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(97, 38);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.White;
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.Image = global::Proyecto_Final_Tecnicas.Properties.Resources.Ayuda;
            this.buttonHelp.Location = new System.Drawing.Point(234, 356);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(97, 38);
            this.buttonHelp.TabIndex = 12;
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.White;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Image = global::Proyecto_Final_Tecnicas.Properties.Resources.Sign_In;
            this.buttonRegister.Location = new System.Drawing.Point(105, 356);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(97, 38);
            this.buttonRegister.TabIndex = 11;
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Proyecto_Final_Tecnicas.Properties.Resources.Container2;
            this.pictureBox3.Location = new System.Drawing.Point(18, 155);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(407, 285);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Proyecto_Final_Tecnicas.Properties.Resources.Container3;
            this.pictureBox8.Location = new System.Drawing.Point(405, 155);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(407, 285);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 22;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final_Tecnicas.Properties.Resources.Header;
            this.pictureBox1.Location = new System.Drawing.Point(47, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(755, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // formRegisterStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 460);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.cmbBoxCarrera);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.checkedListBoxMaterias);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formRegisterStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.formRegisterStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.ComboBox cmbBoxCarrera;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.CheckedListBox checkedListBoxMaterias;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}