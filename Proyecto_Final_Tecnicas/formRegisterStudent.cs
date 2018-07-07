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
    public partial class formRegisterStudent : Form
    {
        public formRegisterStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingrese su ID, contraseña y nombre. Seleccione la carrera a la que se encuentre matriculado actualmente.", "Ayuda",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((txtBoxID.Text == "") || (txtBoxPassword.Text == "") || (txtBoxName.Text == "") || (cmbBoxCarrera.Text == ""))
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

                    write.WriteLine(txtBoxID.Text + "\0" + txtBoxPassword.Text + "\0" + "Estudiante" + "\0" + txtBoxName.Text + "\0" + cmbBoxCarrera.Text);
                    write.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("Usuario agregado exitosamente", "",
               MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            txtBoxID.Text = "";
            txtBoxPassword.Text = "";
            txtBoxName.Text = "";
            cmbBoxCarrera.SelectedIndex = -1;
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
    }
}
