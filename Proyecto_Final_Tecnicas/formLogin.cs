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
            switch(validateUser())
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
    }
}
