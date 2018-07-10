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

        void refreshName (ComboBox cmbBox, Label label)
        {
            try
            {
                System.IO.StreamReader leer = new System.IO.StreamReader("Users.txt");
                string linea = leer.ReadLine();
                while (linea != null)
                {
                    string[] userArray = linea.Split('\0');
                    if (cmbBox.Text == userArray[0])
                    {
                        label.Text = userArray[3];


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

        void refreshTable()
        {
            string[] lines = File.ReadAllLines("Calificaciones.txt");
            listViewIndices.Items.Clear();
            for (int i = 0; i < lines.Length; i=i+3)
            {
                string[] fields = lines[i].Split('@');
                ListViewItem item = new ListViewItem(fields[1]);
                item.SubItems.Add(fields[0]);               
                listViewIndices.Items.Add(item);


            }

        }

        private void formCalificaciones_Load(object sender, EventArgs e)
        {
            
            refreshID(cmbBoxID);
            refreshID(cmbBoxID2);
            refreshTable();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxCalificacion.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor,  solo ingrese caracteres numéricos.","",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxCalificacion.Text = txtBoxCalificacion.Text.Remove(txtBoxCalificacion.Text.Length - 1);
            }

            string value = txtBoxCalificacion.Text;
            if (txtBoxCalificacion.Text !="")

            {
                if (Int16.Parse(value) < 0 )
                {
                    txtBoxCalificacion.Text = "";
                    MessageBox.Show("Las calificaciones deben ser mayores o iguales a 0", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Int16.Parse(value) > 100)
                {
                    txtBoxCalificacion.Text = "";
                    MessageBox.Show("Las calificaciones no pueden ser mayores que 100", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                }
        }
            
        

        private void cmbBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBoxMateria.Items.Clear();
            cmbBoxMateria.Enabled = true;
            txtBoxCalificacion.Enabled = false;
            refreshName(cmbBoxID, lblName);
            try
            {
                

            System.IO.StreamReader leer = new System.IO.StreamReader("Calificaciones.txt");

            string linea = leer.ReadLine();
            while (linea != null)
            {
                string[] calificacionArray = linea.Split('@');
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
                string[] userArray = linea.Split('@');
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

        private void buttonAcept_Click(object sender, EventArgs e)
        {
            
            try
            {
                string[] text = File.ReadAllLines("Calificaciones.txt");
                for (int i = 0; i < text.Length; i = i + 3)
                {
                    string[] arrayLines = text[i].Split('@');

                    if (cmbBoxID.Text == arrayLines[0])
                    {
                        string[] arrayMaterias = text[i + 1].Split('\0');
                        for (int c = 0; c < arrayMaterias.Length - 1; c++)
                        {

                            if (cmbBoxMateria.Text == arrayMaterias[c])
                            {
                                string[] arrayCalificaciones = text[i + 2].Split('@');
                                arrayCalificaciones[c] = txtBoxCalificacion.Text;
                                for (int a = 0; a < arrayCalificaciones.Length - 1; a++)
                                {
                                    if (a == 0)
                                    {
                                        text[i + 2] = arrayCalificaciones[a] + "@";
                                    }
                                    else
                                    {
                                        text[i + 2] = text[i + 2] + arrayCalificaciones[a] + "@";
                                    }

                                }
                            }
                        }
                    }
                }

                File.WriteAllLines("Calificaciones.txt", text);
                calcularIndice(cmbBoxID.Text);
                MessageBox.Show("Calificación modificada exitosamente", "",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            cmbBoxMateria.SelectedIndex = -1;
            txtBoxCalificacion.Text = "";
            txtBoxCalificacion.Enabled = false;

        }

        void calcularIndice (string ID)
        {
            double creditos = 0.0;
            double nota = 0.0;
            double indice = 0.0;

            try
            {
                string[] textCalification = File.ReadAllLines("Calificaciones.txt");
                string[] textMaterias = File.ReadAllLines("Materias.txt");

                for (int i = 0; i < textCalification.Length; i = i + 3)
                {
                    string[] arrayID = textCalification[i].Split('@');

                    if (arrayID[0] == ID)
                    {
                        string[] arrayUserMaterias = textCalification[i+1].Split('\0');
                        string[] arrayUserNotas = textCalification[i+2].Split('@');

                        for(int c = 0; c<arrayUserMaterias.Length; c++)
                        {
                            for (int a=0; a<textMaterias.Length; a++)
                            {
                                string[] arrayLineMateria = textMaterias[a].Split('\0');

                                if (arrayUserMaterias[c] == arrayLineMateria[0])
                                {
                                    creditos = creditos + Convert.ToInt32(arrayLineMateria[3]);
                                    if (Convert.ToInt32(arrayUserNotas[c]) > 90)
                                    {
                                        nota = nota + (Convert.ToInt32(arrayLineMateria[3]) * 4.0);

                                    }
                                    else if ((Convert.ToInt32(arrayUserNotas[c]) >= 80) && (Convert.ToInt32(arrayUserNotas[c]) < 90))
                                    {
                                        nota = nota + (Convert.ToInt32(arrayLineMateria[3]) * 3.0);

                                    }
                                    else if ((Convert.ToInt32(arrayUserNotas[c]) >= 70) && (Convert.ToInt32(arrayUserNotas[c]) < 80))
                                    {
                                        nota = nota + (Convert.ToInt32(arrayLineMateria[3]) * 2.0);

                                    }
                                    else if ((Convert.ToInt32(arrayUserNotas[c]) >= 60) && (Convert.ToInt32(arrayUserNotas[c]) < 70))
                                    {

                                        nota = nota + (Convert.ToInt32(arrayLineMateria[3]) * 1.0);
                                    }
                                    else if (Convert.ToInt32(arrayUserNotas[c]) < 60)
                                    {
                                        nota = nota + (Convert.ToInt32(arrayLineMateria[3]) * 0.0);

                                    }

                                }

                            }


                        }
                        indice = nota / creditos;
                        string stringIndice;
                        if (indice == 0)
                        {
                            stringIndice = "0.0";
                        }
                        else if (indice == 1) {
                            stringIndice = "1.0";

                        }
                        else if (indice == 2)
                        {
                            stringIndice = "2.0";

                        }
                        else if (indice == 3)
                        {
                            stringIndice = "3.0";

                        }
                        else if (indice == 4)
                        {
                            stringIndice = "4.0";

                        }
                        else
                        {
                            stringIndice = Convert.ToString(indice).Substring(0, 4);

                        }

                        arrayID[1] = stringIndice;

                        textCalification[i] = arrayID[0] + '@' + arrayID[1];

                        File.WriteAllLines("Calificaciones.txt", textCalification);

                    }
    

            }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBoxID.SelectedIndex = -1;
            cmbBoxMateria.SelectedIndex = -1;
            cmbBoxMateria.Enabled = false;
            txtBoxCalificacion.Text = "";
            txtBoxCalificacion.Enabled = false;
            lblName.Text = "";
            cmbBoxID2.SelectedIndex = -1;
            lblName2.Text = "";
            listViewCalifications.Columns.Clear();
            listViewCalifications.Items.Clear();
            refreshTable();

        }

        private void cmbBoxID2_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshName(cmbBoxID2, lblName2);
            try
            {
                string[] text = File.ReadAllLines("Calificaciones.txt");
                for (int i = 0; i < text.Length; i = i + 3)
                {
                    string[] arrayLines = text[i].Split('@');
                    if (cmbBoxID2.Text == arrayLines[0])
                    {
                        string[] arrayMaterias = text[i + 1].Split('\0');
                        string[] arrayCalificaciones = text[i + 2].Split('@');
                        listViewCalifications.Columns.Clear();

                        for (int a = 0; a < arrayMaterias.Length - 1; a++)
                        {
                            listViewCalifications.Columns.Add(arrayMaterias[a], 90);                                                          
                            }
                        listViewCalifications.Items.Clear();
                        ListViewItem item = new ListViewItem(arrayCalificaciones[0]);
                        for (int a=1; a<arrayCalificaciones.Length-1; a++)
                        {
                            item.SubItems.Add(arrayCalificaciones[a]);
                        }
                        
                        listViewCalifications.Items.Add(item);

                    }

                }

            }
            

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            formMdiAdmin.ActiveForm.BackColor = Color.Yellow;
        }
    }
}
