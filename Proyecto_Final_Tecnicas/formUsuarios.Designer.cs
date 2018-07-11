namespace Proyecto_Final_Tecnicas
{
    partial class formUsuarios
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
            this.cmbBoxUserType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEditAcept = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBoxEditCarrera = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxEditPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxEditName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxEditID = new System.Windows.Forms.TextBox();
            this.cmbBoxEditUser = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(-2, -1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(474, 398);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbBoxUserType);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.listViewUsers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(466, 372);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visualizar usuarios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbBoxUserType
            // 
            this.cmbBoxUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxUserType.FormattingEnabled = true;
            this.cmbBoxUserType.Items.AddRange(new object[] {
            "Estudiante",
            "Profesor"});
            this.cmbBoxUserType.Location = new System.Drawing.Point(196, 2);
            this.cmbBoxUserType.Name = "cmbBoxUserType";
            this.cmbBoxUserType.Size = new System.Drawing.Size(85, 21);
            this.cmbBoxUserType.TabIndex = 29;
            this.cmbBoxUserType.SelectedIndexChanged += new System.EventHandler(this.comboBoxUserType_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Seleccione el tipo de usuario:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Proyecto_Final_Tecnicas.Properties.Resources.Volver;
            this.button2.Location = new System.Drawing.Point(308, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 38);
            this.button2.TabIndex = 27;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // listViewUsers
            // 
            this.listViewUsers.Location = new System.Drawing.Point(1, 35);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(469, 293);
            this.listViewUsers.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewUsers.TabIndex = 3;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.buttonEditAcept);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.cmbBoxEditUser);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(466, 372);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modificar usuario";
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
            this.groupBox2.Controls.Add(this.cmbBoxEditCarrera);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtBoxEditPassword);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtBoxEditName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtBoxEditID);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(50, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 201);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modifique los datos del usuario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID:";
            // 
            // cmbBoxEditCarrera
            // 
            this.cmbBoxEditCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxEditCarrera.Enabled = false;
            this.cmbBoxEditCarrera.FormattingEnabled = true;
            this.cmbBoxEditCarrera.Items.AddRange(new object[] {
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
            this.cmbBoxEditCarrera.Location = new System.Drawing.Point(112, 164);
            this.cmbBoxEditCarrera.Name = "cmbBoxEditCarrera";
            this.cmbBoxEditCarrera.Size = new System.Drawing.Size(238, 24);
            this.cmbBoxEditCarrera.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Contraseña:";
            // 
            // txtBoxEditPassword
            // 
            this.txtBoxEditPassword.Enabled = false;
            this.txtBoxEditPassword.Location = new System.Drawing.Point(112, 83);
            this.txtBoxEditPassword.MaxLength = 15;
            this.txtBoxEditPassword.Name = "txtBoxEditPassword";
            this.txtBoxEditPassword.Size = new System.Drawing.Size(121, 22);
            this.txtBoxEditPassword.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nombre:";
            // 
            // txtBoxEditName
            // 
            this.txtBoxEditName.Enabled = false;
            this.txtBoxEditName.Location = new System.Drawing.Point(112, 125);
            this.txtBoxEditName.MaxLength = 50;
            this.txtBoxEditName.Name = "txtBoxEditName";
            this.txtBoxEditName.Size = new System.Drawing.Size(121, 22);
            this.txtBoxEditName.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Carrera:";
            // 
            // txtBoxEditID
            // 
            this.txtBoxEditID.Enabled = false;
            this.txtBoxEditID.Location = new System.Drawing.Point(112, 44);
            this.txtBoxEditID.MaxLength = 50;
            this.txtBoxEditID.Name = "txtBoxEditID";
            this.txtBoxEditID.Size = new System.Drawing.Size(121, 22);
            this.txtBoxEditID.TabIndex = 13;
            // 
            // cmbBoxEditUser
            // 
            this.cmbBoxEditUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxEditUser.FormattingEnabled = true;
            this.cmbBoxEditUser.Location = new System.Drawing.Point(180, 47);
            this.cmbBoxEditUser.Name = "cmbBoxEditUser";
            this.cmbBoxEditUser.Size = new System.Drawing.Size(119, 21);
            this.cmbBoxEditUser.TabIndex = 27;
            this.cmbBoxEditUser.SelectedIndexChanged += new System.EventHandler(this.cmbBoxEditUser_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Seleccione el usuario que desee modificar:";
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
<<<<<<< HEAD
=======
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonBack);
            this.tabPage4.Controls.Add(this.buttonDeleteMateria);
            this.tabPage4.Controls.Add(this.cmbBoxDeleteUser);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.pictureBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(466, 372);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Eliminar usuario";
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
            // 
            // cmbBoxDeleteUser
            // 
            this.cmbBoxDeleteUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxDeleteUser.FormattingEnabled = true;
            this.cmbBoxDeleteUser.Location = new System.Drawing.Point(184, 226);
            this.cmbBoxDeleteUser.Name = "cmbBoxDeleteUser";
            this.cmbBoxDeleteUser.Size = new System.Drawing.Size(115, 21);
            this.cmbBoxDeleteUser.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(105, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(258, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "Seleccione el usuario que desee eliminar:";
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
            // cmbBoxUserType
            // 
            this.cmbBoxUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxUserType.FormattingEnabled = true;
            this.cmbBoxUserType.Items.AddRange(new object[] {
            "Estudiante",
            "Profesor"});
            this.cmbBoxUserType.Location = new System.Drawing.Point(196, 2);
            this.cmbBoxUserType.Name = "cmbBoxUserType";
            this.cmbBoxUserType.Size = new System.Drawing.Size(85, 21);
            this.cmbBoxUserType.TabIndex = 29;
            this.cmbBoxUserType.SelectedIndexChanged += new System.EventHandler(this.comboBoxUserType_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Seleccione el tipo de usuario:";
            // 
>>>>>>> parent of 30c4b62... 1.4.6
            // formUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 397);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formUsuarios";
            this.Text = "formUsuarios";
            this.Load += new System.EventHandler(this.formUsuarios_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbBoxUserType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonEditAcept;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBoxEditCarrera;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxEditPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxEditName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxEditID;
        private System.Windows.Forms.ComboBox cmbBoxEditUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}