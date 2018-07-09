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
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

             

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formRegister form2 = new formRegister();
            formMain form1 = new formMain();
            {
                this.Hide();
                form2.ShowDialog();
                this.Show();
                
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            formLogin form3 = new formLogin();
            formMain form1 = new formMain();
            {
                this.Hide();
                form3.ShowDialog();
                this.Show();

            }
        }
    }
}
