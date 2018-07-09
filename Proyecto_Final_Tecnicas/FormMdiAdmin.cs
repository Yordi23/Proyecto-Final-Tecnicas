using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Tecnicas
{
    public partial class formMdiAdmin : Form
    {
        

        public formMdiAdmin()
        {
            InitializeComponent();
        }

 

        private void pictureMateria_Click(object sender, EventArgs e)
        {
            this.switchVisibility(false);

            formMaterias formMaterias = new formMaterias();
            formMaterias.MdiParent = this;
            formSetPosition(formMaterias);
            formMaterias.Show();
            

        }

        public void switchVisibility (bool visible)
        {
            
            this.pictureBox1.Visible = visible;
            this.pictureMateria.Visible = visible;
            this.pictureCalificacion.Visible = visible;
            this.label1.Visible = visible;
            this.label2.Visible = visible;
            this.pictureBox3.Visible = visible;
            this.buttonExit.Visible = visible;


        }

        private void formMdiAdmin_BackColorChanged(object sender, EventArgs e)
        {
            switchVisibility(true);
            this.BackColor = Color.White;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureCalificacion_Click(object sender, EventArgs e)
        {
            this.switchVisibility(false);

            formCalificaciones formCalificaciones = new formCalificaciones();
            formCalificaciones.MdiParent = this;
            formSetPosition(formCalificaciones);
            formCalificaciones.Show();
        }

        void formSetPosition (Form form1)
        {
            form1.StartPosition = FormStartPosition.Manual;
            form1.Left = 0;
            form1.Top = 0;
            form1.Show();

        }
    }
}
