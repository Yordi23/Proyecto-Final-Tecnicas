using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Tecnicas
{
    
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        int validateUser()
        {
            
            System.IO.StreamReader leer = new System.IO.StreamReader("Users.txt");
            string line = leer.ReadLine();
            while (line != null)
            {
                string[] userArray = line.Split('\0');
                if (txtBoxUser.Text == userArray[0])
                {
                    if (txtBoxPassword.Text == userArray[1])
                    {
                        switch (userArray[2])
                        {
                            case "Administrador":
                                return 1;
                            
                            case "Estudiante":
                            return 2;                          
                        }
                    }
                }
                line = leer.ReadLine();
            }
            leer.Close();
            return 3;


        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            button2.Visible = false;
            buttonLogin.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            txtBoxPassword.Visible = false;
            txtBoxUser.Visible = false;
            pictureBox5.Visible = true;
            circularProgressBar1.Visible = true;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Controls.Add(pictureBox5);         
            pictureBox5.Location = new Point(-6,-7);
            pictureBox5.BackColor = Color.Transparent;
            circularProgressBar1.Update();
            pictureBox5.BringToFront();
            for (int i = 0; i < 101; i++)
            {
                Thread.Sleep(5);
                circularProgressBar1.Value = i;
                circularProgressBar1.Update();
            }
            if (circularProgressBar1.Value == 100)
            {
                switch (validateUser())
                {
                    case 1:
                        formMdiAdmin formMdiAdmin = new formMdiAdmin();
                        formMain form1 = new formMain();
                        {
                            this.Hide();
                            formMdiAdmin.ShowDialog();
                            this.Show();

                        }

                        break;
                    case 2:
                        formLoginEstudiante formLoginEstudiante = new formLoginEstudiante();
                        formLoginEstudiante.userID = txtBoxUser.Text;
                        formMain form2 = new formMain();
                        {
                            this.Hide();
                            formLoginEstudiante.ShowDialog();
                            this.Show();

                        }


                        break;
                    case 3:
                        MessageBox.Show("El nombre de usuario o la contraseña ingresada son incorrectos. Por favor, intentelo nuevamente.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }

            button2.Visible = true;
            buttonLogin.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            txtBoxPassword.Visible = true;
            txtBoxUser.Visible = true;
            circularProgressBar1.Visible = false;
            circularProgressBar1.Update();
            circularProgressBar1.Value = 0;
            circularProgressBar1.Update();
            txtBoxUser.Text = "";
            txtBoxPassword.Text = "";
            txtBoxUser.Focus();
        }

        private void txtBoxUser_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxUser.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor,  solo ingrese caracteres numéricos.");
                txtBoxUser.Text = txtBoxUser.Text.Remove(txtBoxUser.Text.Length - 1);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
          
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
