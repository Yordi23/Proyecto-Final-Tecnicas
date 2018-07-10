namespace Proyecto_Final_Tecnicas
{
    partial class formCalificaciones
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
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.listViewIndices = new System.Windows.Forms.ListView();
            this.columnIndice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMerito = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageCalification = new System.Windows.Forms.TabPage();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listViewCalifications = new System.Windows.Forms.ListView();
            this.lblName2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbBoxID2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageModify = new System.Windows.Forms.TabPage();
            this.txtBoxCalificacion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAcept = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbBoxMateria = new System.Windows.Forms.ComboBox();
            this.cmbBoxID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl.SuspendLayout();
            this.tabPageReport.SuspendLayout();
            this.tabPageCalification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPageModify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageReport);
            this.tabControl.Controls.Add(this.tabPageCalification);
            this.tabControl.Controls.Add(this.tabPageModify);
            this.tabControl.Location = new System.Drawing.Point(-1, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(474, 398);
            this.tabControl.TabIndex = 34;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageReport
            // 
            this.tabPageReport.Controls.Add(this.button2);
            this.tabPageReport.Controls.Add(this.listViewIndices);
            this.tabPageReport.Location = new System.Drawing.Point(4, 22);
            this.tabPageReport.Name = "tabPageReport";
            this.tabPageReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReport.Size = new System.Drawing.Size(466, 372);
            this.tabPageReport.TabIndex = 2;
            this.tabPageReport.Text = "Reporte de índices";
            this.tabPageReport.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(309, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 38);
            this.button2.TabIndex = 55;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // listViewIndices
            // 
            this.listViewIndices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIndice,
            this.columnMerito,
            this.columnID,
            this.columnName});
            this.listViewIndices.Location = new System.Drawing.Point(25, 15);
            this.listViewIndices.Name = "listViewIndices";
            this.listViewIndices.Size = new System.Drawing.Size(419, 304);
            this.listViewIndices.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listViewIndices.TabIndex = 0;
            this.listViewIndices.UseCompatibleStateImageBehavior = false;
            this.listViewIndices.View = System.Windows.Forms.View.Details;
            // 
            // columnIndice
            // 
            this.columnIndice.Text = "Índice";
            this.columnIndice.Width = 45;
            // 
            // columnMerito
            // 
            this.columnMerito.Text = "Honor";
            this.columnMerito.Width = 120;
            // 
            // tabPageCalification
            // 
            this.tabPageCalification.Controls.Add(this.buttonBack);
            this.tabPageCalification.Controls.Add(this.pictureBox2);
            this.tabPageCalification.Controls.Add(this.listViewCalifications);
            this.tabPageCalification.Controls.Add(this.lblName2);
            this.tabPageCalification.Controls.Add(this.label7);
            this.tabPageCalification.Controls.Add(this.cmbBoxID2);
            this.tabPageCalification.Controls.Add(this.label4);
            this.tabPageCalification.Location = new System.Drawing.Point(4, 22);
            this.tabPageCalification.Name = "tabPageCalification";
            this.tabPageCalification.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCalification.Size = new System.Drawing.Size(466, 372);
            this.tabPageCalification.TabIndex = 0;
            this.tabPageCalification.Text = "Calificaciones";
            this.tabPageCalification.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.White;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(309, 325);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(97, 38);
            this.buttonBack.TabIndex = 54;
            this.buttonBack.Text = "Volver";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Final_Tecnicas.Properties.Resources.UNIPROM_Logo_Full_Size__Only_Name_;
            this.pictureBox2.Location = new System.Drawing.Point(65, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(344, 165);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // listViewCalifications
            // 
            this.listViewCalifications.Location = new System.Drawing.Point(40, 250);
            this.listViewCalifications.Name = "listViewCalifications";
            this.listViewCalifications.Size = new System.Drawing.Size(404, 68);
            this.listViewCalifications.TabIndex = 52;
            this.listViewCalifications.UseCompatibleStateImageBehavior = false;
            this.listViewCalifications.View = System.Windows.Forms.View.Details;
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Location = new System.Drawing.Point(272, 234);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(0, 13);
            this.lblName2.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 16);
            this.label7.TabIndex = 50;
            this.label7.Text = "Nombre del estudiante:";
            // 
            // cmbBoxID2
            // 
            this.cmbBoxID2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxID2.FormattingEnabled = true;
            this.cmbBoxID2.Location = new System.Drawing.Point(270, 179);
            this.cmbBoxID2.Name = "cmbBoxID2";
            this.cmbBoxID2.Size = new System.Drawing.Size(154, 21);
            this.cmbBoxID2.TabIndex = 49;
            this.cmbBoxID2.SelectedIndexChanged += new System.EventHandler(this.cmbBoxID2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Seleccione el ID del estudiante:";
            // 
            // tabPageModify
            // 
            this.tabPageModify.Controls.Add(this.txtBoxCalificacion);
            this.tabPageModify.Controls.Add(this.button1);
            this.tabPageModify.Controls.Add(this.buttonAcept);
            this.tabPageModify.Controls.Add(this.lblName);
            this.tabPageModify.Controls.Add(this.cmbBoxMateria);
            this.tabPageModify.Controls.Add(this.cmbBoxID);
            this.tabPageModify.Controls.Add(this.label3);
            this.tabPageModify.Controls.Add(this.label1);
            this.tabPageModify.Controls.Add(this.label2);
            this.tabPageModify.Controls.Add(this.label5);
            this.tabPageModify.Controls.Add(this.pictureBox1);
            this.tabPageModify.Location = new System.Drawing.Point(4, 22);
            this.tabPageModify.Name = "tabPageModify";
            this.tabPageModify.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageModify.Size = new System.Drawing.Size(466, 372);
            this.tabPageModify.TabIndex = 1;
            this.tabPageModify.Text = "Modificar";
            this.tabPageModify.UseVisualStyleBackColor = true;
            // 
            // txtBoxCalificacion
            // 
            this.txtBoxCalificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxCalificacion.Enabled = false;
            this.txtBoxCalificacion.Location = new System.Drawing.Point(277, 292);
            this.txtBoxCalificacion.MaxLength = 3;
            this.txtBoxCalificacion.Name = "txtBoxCalificacion";
            this.txtBoxCalificacion.Size = new System.Drawing.Size(27, 20);
            this.txtBoxCalificacion.TabIndex = 51;
            this.txtBoxCalificacion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(309, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 38);
            this.button1.TabIndex = 50;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAcept
            // 
            this.buttonAcept.BackColor = System.Drawing.Color.White;
            this.buttonAcept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcept.Location = new System.Drawing.Point(60, 325);
            this.buttonAcept.Name = "buttonAcept";
            this.buttonAcept.Size = new System.Drawing.Size(97, 38);
            this.buttonAcept.TabIndex = 49;
            this.buttonAcept.Text = "Aceptar";
            this.buttonAcept.UseVisualStyleBackColor = false;
            this.buttonAcept.Click += new System.EventHandler(this.buttonAcept_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(276, 191);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 48;
            // 
            // cmbBoxMateria
            // 
            this.cmbBoxMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxMateria.Enabled = false;
            this.cmbBoxMateria.FormattingEnabled = true;
            this.cmbBoxMateria.Location = new System.Drawing.Point(274, 230);
            this.cmbBoxMateria.Name = "cmbBoxMateria";
            this.cmbBoxMateria.Size = new System.Drawing.Size(154, 21);
            this.cmbBoxMateria.TabIndex = 46;
            this.cmbBoxMateria.SelectedIndexChanged += new System.EventHandler(this.cmbBoxMateria_SelectedIndexChanged);
            // 
            // cmbBoxID
            // 
            this.cmbBoxID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxID.FormattingEnabled = true;
            this.cmbBoxID.Location = new System.Drawing.Point(274, 151);
            this.cmbBoxID.Name = "cmbBoxID";
            this.cmbBoxID.Size = new System.Drawing.Size(154, 21);
            this.cmbBoxID.TabIndex = 47;
            this.cmbBoxID.SelectedIndexChanged += new System.EventHandler(this.cmbBoxID_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Calificación:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Seleccione una materia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nombre del estudiante:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "Seleccione el ID del estudiante:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final_Tecnicas.Properties.Resources.UNIPROM_Logo_Full_Size__Only_Name_;
            this.pictureBox1.Location = new System.Drawing.Point(64, -22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 90;
            // 
            // columnName
            // 
            this.columnName.Text = "Nombre";
            this.columnName.Width = 160;
            // 
            // formCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 397);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCalificaciones";
            this.Text = "formCalificaciones";
            this.Load += new System.EventHandler(this.formCalificaciones_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageReport.ResumeLayout(false);
            this.tabPageCalification.ResumeLayout(false);
            this.tabPageCalification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPageModify.ResumeLayout(false);
            this.tabPageModify.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageCalification;
        private System.Windows.Forms.TabPage tabPageModify;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAcept;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbBoxMateria;
        private System.Windows.Forms.ComboBox cmbBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxCalificacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPageReport;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView listViewCalifications;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBoxID2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listViewIndices;
        private System.Windows.Forms.ColumnHeader columnIndice;
        private System.Windows.Forms.ColumnHeader columnMerito;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnName;
    }
}