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
    public partial class formMaterias : Form
    {
        public formMaterias()
        {
            InitializeComponent();
        }

        private void buttonAcept_Click(object sender, EventArgs e)
        {
            if ((txtBoxName.Text == "") || (txtBoxKey.Text == "") || (txtBoxTeacher.Text == "") || (cmbBoxCredit.Text == ""))
            {
                MessageBox.Show("La materia no ha sido agregada. Por favor, complete todos los campos correctamente", "Error",
           MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ExistMateria())
            {
                MessageBox.Show("La materia ya ha sido agregada anteriormente. Por favor, ingrese una materia nueva", "Error",
           MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                try
                {
                    StreamWriter write = new StreamWriter("Materias.txt", true);

                    write.WriteLine(txtBoxName.Text + "\0" + txtBoxKey.Text + "\0" + txtBoxTeacher.Text + "\0" + cmbBoxCredit.Text);
                    write.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Materia agregada exitosamente", "",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtBoxName.Text = "";
            txtBoxKey.Text = "";
            txtBoxTeacher.Text = "";
            cmbBoxCredit.SelectedIndex = -1;
            txtBoxName.Focus();

        }

        bool ExistMateria()
        {
            System.IO.StreamReader leer = new System.IO.StreamReader("Materias.txt");
            string line = leer.ReadLine();
            while (line != null)
            {
                string[] userArray = line.Split('\0');
                if (txtBoxName.Text == userArray[0])
                {
                    return true;
                }
                line = leer.ReadLine();
            }
            leer.Close();
            return false;


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
