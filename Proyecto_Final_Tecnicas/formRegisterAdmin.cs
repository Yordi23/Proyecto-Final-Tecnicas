using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_Final_Tecnicas
{
    public partial class formRegisterAdmin : Form
    {
        public formRegisterAdmin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void formRegister_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingrese su ID y contraseña.", "Ayuda",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if ((txtBoxID.Text == "") || (txtBoxPassword.Text == ""))
            {
                MessageBox.Show("El usuario no ha sido agregado. Por favor, complete todos los campos correctamente", "Error",
           MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ExistUser())
            {
                MessageBox.Show("El ID ya ha sido agregado anteriormente. Por favor, ingrese otro ID", "Error",
           MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    StreamWriter write = new StreamWriter("Users.txt", true);

                    write.WriteLine(txtBoxID.Text + "\0" + txtBoxPassword.Text + "\0" + "Administrador");
                    write.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

                MessageBox.Show("Usuario agregado exitosamente", "",
               MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            txtBoxID.Text = "";
            txtBoxPassword.Text = "";
            
            txtBoxID.Focus();
            
        }

        bool ExistUser()
        {
            System.IO.StreamReader leer = new System.IO.StreamReader("Users.txt");
            string line = leer.ReadLine();
            while (line != null)
            {
                string[] userArray = line.Split('\0');
                if (txtBoxID.Text == userArray[0])
                {
                    return true;
                }
                line = leer.ReadLine();
            }
            leer.Close();
            return false;
        }

        private void txtBoxID_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxID.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor,  solo ingrese caracteres numéricos.");
                txtBoxID.Text = txtBoxID.Text.Remove(txtBoxID.Text.Length - 1);
            }
        }
    }
}
