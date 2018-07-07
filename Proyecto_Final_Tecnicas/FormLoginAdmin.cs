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
    public partial class FormLoginAdmin : Form
    {
        public FormLoginAdmin()
        {
            InitializeComponent();
        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    formAgregarMateria form1 = new formAgregarMateria();
                    form1.MdiParent = this;
                    form1.Show();
                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;

            }
        }

        
    }
}
