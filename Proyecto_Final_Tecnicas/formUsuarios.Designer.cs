﻿namespace Proyecto_Final_Tecnicas
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
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.cmbBoxDeleteUser = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(383, 221);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(582, 335);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbBoxUserType);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.listViewUsers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(574, 309);
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
            this.cmbBoxUserType.Location = new System.Drawing.Point(196, 1);
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
            // listViewUsers
            // 
            this.listViewUsers.GridLines = true;
            this.listViewUsers.Location = new System.Drawing.Point(-1, 22);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(582, 335);
            this.listViewUsers.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewUsers.TabIndex = 3;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonEditAcept);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.cmbBoxEditUser);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(574, 309);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modificar usuario";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonEditAcept
            // 
            this.buttonEditAcept.BackColor = System.Drawing.Color.White;
            this.buttonEditAcept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditAcept.Location = new System.Drawing.Point(238, 268);
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
            this.groupBox2.Location = new System.Drawing.Point(113, 60);
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
            this.cmbBoxEditUser.Location = new System.Drawing.Point(232, 33);
            this.cmbBoxEditUser.Name = "cmbBoxEditUser";
            this.cmbBoxEditUser.Size = new System.Drawing.Size(119, 21);
            this.cmbBoxEditUser.TabIndex = 27;
            this.cmbBoxEditUser.SelectedIndexChanged += new System.EventHandler(this.cmbBoxEditUser_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(163, 5);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblName);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.buttonDeleteUser);
            this.tabPage2.Controls.Add(this.cmbBoxDeleteUser);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(574, 309);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Eliminar usuario";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(289, 183);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Nombre:";
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.BackColor = System.Drawing.Color.White;
            this.buttonDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteUser.Location = new System.Drawing.Point(240, 240);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(97, 38);
            this.buttonDeleteUser.TabIndex = 35;
            this.buttonDeleteUser.Text = "Eliminar";
            this.buttonDeleteUser.UseVisualStyleBackColor = false;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // cmbBoxDeleteUser
            // 
            this.cmbBoxDeleteUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxDeleteUser.FormattingEnabled = true;
            this.cmbBoxDeleteUser.Location = new System.Drawing.Point(184, 137);
            this.cmbBoxDeleteUser.Name = "cmbBoxDeleteUser";
            this.cmbBoxDeleteUser.Size = new System.Drawing.Size(206, 21);
            this.cmbBoxDeleteUser.TabIndex = 34;
            this.cmbBoxDeleteUser.SelectedIndexChanged += new System.EventHandler(this.cmbBoxDeleteUser_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(158, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(258, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = "Seleccione el usuario que desee eliminar:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final_Tecnicas.Properties.Resources.BG_test;
            this.pictureBox1.Location = new System.Drawing.Point(190, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 430);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // formUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1138, 576);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pictureBox1);
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbBoxUserType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.TabPage tabPage3;
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.ComboBox cmbBoxDeleteUser;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}