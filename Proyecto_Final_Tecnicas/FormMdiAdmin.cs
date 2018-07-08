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

 

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.switchVisibility(false);

            formMaterias formMaterias = new formMaterias();
            formMaterias.MdiParent = this;
            formMaterias.StartPosition = FormStartPosition.Manual;
            formMaterias.Left = 0;
            formMaterias.Top = 0;
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
    }
}
