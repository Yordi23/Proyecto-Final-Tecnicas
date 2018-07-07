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

        

        

       
        private void FormMdiAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureMateria.Visible = false;
            pictureCalificacion.Visible = false;
            label1.Visible = false; ;
            label2.Visible = false;
            pictureBox3.Visible = false;
            buttonBack.Visible = false;

            formMaterias formMaterias = new formMaterias();
            formMaterias.MdiParent = this;
            formMaterias.Show();
        }
    }
}
