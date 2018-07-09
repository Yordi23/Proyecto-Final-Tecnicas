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
    public partial class formCalificaciones : Form
    {
        public formCalificaciones()
        {
            InitializeComponent();
        }

        void refreshMaterias(ComboBox cmbBox)
        {
            cmbBox.Items.Clear();
            try
            {
                System.IO.StreamReader leer = new System.IO.StreamReader("Materias.txt");
                string linea = leer.ReadLine();
                while (linea != null)
                {
                    string[] materiaArray = linea.Split('\0');
                    cmbBox.Items.Add(materiaArray[0]);
                    linea = leer.ReadLine();
                }
                leer.Close();
            }

            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        void refreshID(ComboBox cmbBox)
        {
            cmbBox.Items.Clear();
            try
            {
                System.IO.StreamReader leer = new System.IO.StreamReader("Users.txt");
                string linea = leer.ReadLine();
                while (linea != null)
                {
                    string[] materiaArray = linea.Split('\0');
                    if (materiaArray[2] == "Estudiante")
                    {
                        cmbBox.Items.Add(materiaArray[0]);
                    }
                    linea = leer.ReadLine();
                }
                leer.Close();
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void formCalificaciones_Load(object sender, EventArgs e)
        {
            
            refreshID(cmbBoxID);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxCalificacion.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor,  solo ingrese caracteres numéricos.");
                txtBoxCalificacion.Text = txtBoxCalificacion.Text.Remove(txtBoxCalificacion.Text.Length - 1);
            }
        }

        private void cmbBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBoxMateria.Items.Clear();
            cmbBoxMateria.Enabled = true;

            try
            {
                System.IO.StreamReader leer = new System.IO.StreamReader("Users.txt");
            string linea = leer.ReadLine();
            while (linea != null)
            {
                string[] userArray = linea.Split('\0');
                if (cmbBoxID.Text == userArray[0])
                {
                    lblName.Text = userArray[3];
                    
                    
                }

                linea = leer.ReadLine();
            }
            leer.Close();

            leer = new System.IO.StreamReader("Calificaciones.txt");

            linea = leer.ReadLine();
            while (linea != null)
            {
                string[] calificacionArray = linea.Split('\0');
                if (cmbBoxID.Text == calificacionArray[0])
                {
                    linea = leer.ReadLine();
                    string[] materiaArray = linea.Split('\0');
                    for (int i = 0; i < materiaArray.Length-1;i++) {
                        cmbBoxMateria.Items.Add(materiaArray[i]);
                    }
                    
                    leer.Close();
                    return;
                }

                linea = leer.ReadLine();
            }
            leer.Close();
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void cmbBoxMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            System.IO.StreamReader leer = new System.IO.StreamReader("Calificaciones.txt");
            string linea = leer.ReadLine();
            while (linea != null)
            {
                string[] userArray = linea.Split('\0');
                if (cmbBoxID.Text == userArray[0])
                {
                        linea = leer.ReadLine();
                        string[] materiaArray = linea.Split('\0');
                        for (int i = 0; i<materiaArray.Length; i++)
                        {
                            if (cmbBoxMateria.Text == materiaArray[i])
                            {
                                linea = leer.ReadLine();
                                string[] calificacionesArray = linea.Split('@');
                                txtBoxCalificacion.Text = calificacionesArray[i];
                                txtBoxCalificacion.Enabled = true;
                                leer.Close();
                                return;

                            }


                        }


                }

                linea = leer.ReadLine();
            }
                leer.Close();

                }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
