namespace Proyecto_Final_Tecnicas
{
    partial class formMdiAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMdiAdmin));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureMateria = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureCalificacion = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMateria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCalificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "CALIFICACIONES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "MATERIAS";
            // 
            // pictureMateria
            // 
            this.pictureMateria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMateria.Image = ((System.Drawing.Image)(resources.GetObject("pictureMateria.Image")));
            this.pictureMateria.Location = new System.Drawing.Point(64, 222);
            this.pictureMateria.Name = "pictureMateria";
            this.pictureMateria.Size = new System.Drawing.Size(100, 50);
            this.pictureMateria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMateria.TabIndex = 14;
            this.pictureMateria.TabStop = false;
            this.pictureMateria.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(308, 311);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 50);
            this.buttonBack.TabIndex = 17;
            this.buttonBack.Text = "Volver";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // pictureCalificacion
            // 
            this.pictureCalificacion.Image = ((System.Drawing.Image)(resources.GetObject("pictureCalificacion.Image")));
            this.pictureCalificacion.Location = new System.Drawing.Point(308, 222);
            this.pictureCalificacion.Name = "pictureCalificacion";
            this.pictureCalificacion.Size = new System.Drawing.Size(100, 50);
            this.pictureCalificacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCalificacion.TabIndex = 16;
            this.pictureCalificacion.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(64, 310);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final_Tecnicas.Properties.Resources.UNIPROM_Logo_Full_Size__Only_Name_;
            this.pictureBox1.Location = new System.Drawing.Point(64, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // formMdiAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(479, 402);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureMateria);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.pictureCalificacion);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "formMdiAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLoginAdmin";
            this.Load += new System.EventHandler(this.FormMdiAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMateria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCalificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureMateria;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureCalificacion;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}