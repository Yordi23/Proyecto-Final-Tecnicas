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
            MessageBox.Show("Ingrese su ID, contraseña y nombre. Seleccione la carrera a la que se encuentre matriculado actualmente y las materias que desee cursar.", "Ayuda",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //var text = File.ReadAllText("Calificaciones.txt");
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

                    write = new StreamWriter("Calificaciones.txt", true);
                    write.WriteLine(txtBoxID.Text);
                    foreach (object itemChecked in checkedListBoxMaterias.CheckedItems)
                    {
                        write.Write(itemChecked.ToString() + '\0');
                    }
                    write.WriteLine(' ');
                    
                    foreach (object itemChecked in checkedListBoxMaterias.CheckedItems)
                    {
                        write.Write("0" + '@');
                    }
                    write.WriteLine(' ');                   
                    write.Close();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("Usuario agregado exitosamente", "",
               MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
            UncheckAllItems();
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
                    leer.Close();
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

        private void formRegisterStudent_Load(object sender, EventArgs e)
        {
            refreshCheckList();
        }

        void refreshCheckList()
        {

            checkedListBoxMaterias.Items.Clear();
            System.IO.StreamReader leer = new System.IO.StreamReader("Materias.txt");
            string linea = leer.ReadLine();
            while (linea != null)
            {
                string[] materiaArray = linea.Split('\0');
                checkedListBoxMaterias.Items.Add(materiaArray[0]);
                linea = leer.ReadLine();
            }
            leer.Close();

        }

        private void UncheckAllItems()
        {
            while (checkedListBoxMaterias.CheckedIndices.Count > 0)
                checkedListBoxMaterias.SetItemChecked(checkedListBoxMaterias.CheckedIndices[0], false);
        }

        
    }
}
