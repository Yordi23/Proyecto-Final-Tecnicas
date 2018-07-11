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
    public partial class formUsuarios : Form
    {
        public formUsuarios()
        {
            InitializeComponent();
        }

        private void cmbBoxEditUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxEditID.Enabled = true;
            txtBoxEditPassword.Enabled = true;
            txtBoxEditName.Enabled = true;
            cmbBoxEditCarrera.Enabled = false;
            cmbBoxEditCarrera.SelectedIndex = -1;

            try
            {
                System.IO.StreamReader leer = new System.IO.StreamReader("Users.txt");
                string linea = leer.ReadLine();
                while (linea != null)
                {
                    string[] userArray = linea.Split('\0');
                    if (cmbBoxEditUser.Text == userArray[0])
                    {
                        txtBoxEditID.Text = userArray[0];
                        txtBoxEditPassword.Text = userArray[1];
                        txtBoxEditName.Text = userArray[3];
                        if (userArray[2] == "Estudiante")
                        {
                            cmbBoxEditCarrera.Enabled = true;
                            cmbBoxEditCarrera.Text = userArray[4];
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
                    cmbBox.Items.Add(materiaArray[0]);
                    linea = leer.ReadLine();
                }
                leer.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void formUsuarios_Load(object sender, EventArgs e)
        {
            refreshID(cmbBoxEditUser);
            
        }

        void clearAll()
        {
            txtBoxEditID.Enabled = false;
            txtBoxEditPassword.Enabled = false;
            txtBoxEditName.Enabled = false;
            cmbBoxEditCarrera.Enabled = false;

            txtBoxEditID.Text = "";
            txtBoxEditPassword.Text = "";
            txtBoxEditName.Text = "";

            cmbBoxEditCarrera.SelectedIndex = -1;
            cmbBoxEditUser.SelectedIndex = -1;
            


        }
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearAll();
            listViewUsers.Columns.Clear();
            listViewUsers.Items.Clear();
            cmbBoxUserType.SelectedIndex = -1;
        }

        private void buttonEditAcept_Click(object sender, EventArgs e)
        {
            if ((txtBoxEditID.Text == "") || (txtBoxEditPassword.Text == "") || (txtBoxEditName.Text == "") )
            {
                MessageBox.Show("El usuario no ha sido modificada. Por favor, complete todos los campos correctamente", "Error",
           MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ExistUser())
            {
                MessageBox.Show("El ID ya ha sido registrado anteriormente. Por favor, ingrese otro ID", "Error",
           MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea modificar este usuario?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        string[] text = File.ReadAllLines("Users.txt");

                        for (int i = 0; i < text.Length; i++)
                        {
                            string[] arrayLines = text[i].Split('\0');

                            if (cmbBoxEditUser.Text == arrayLines[0])
                            {
                                if (arrayLines[2] == "Estudiante")
                                {
                                    text[i] = txtBoxEditID.Text + "\0" + txtBoxEditPassword.Text + "\0" + "Estudiante" + "\0" + txtBoxEditName.Text + "\0" + cmbBoxEditCarrera.Text;
                                    string[] calificaciones = File.ReadAllLines("Calificaciones.txt");
                                    for (int a =0; i<calificaciones.Length; a=a+3)
                                    {
                                        string[] arrayCalificaciones = calificaciones[a].Split('@');
                                        if(arrayCalificaciones[0] == cmbBoxEditUser.Text)
                                        {
                                            calificaciones[a] = txtBoxEditID.Text + "@" + arrayCalificaciones[1];
                                            break;
                                        }
                                    }
                                    File.WriteAllLines("Calificaciones.txt", calificaciones);
                                }
                                else 
                                {
                                    text[i] = txtBoxEditID.Text + "\0" + txtBoxEditPassword.Text + "\0" + "Administrador" + "\0" + txtBoxEditName.Text;
                                }
                            }
                        }
                        File.WriteAllLines("Users.txt", text);
                        refreshID(cmbBoxEditUser);
                        clearAll();


                        MessageBox.Show("Usuario modificado exitosamente", "",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }


            }
        }

        bool ExistUser()
        {
            System.IO.StreamReader leer = new System.IO.StreamReader("Users.txt");
            string line = leer.ReadLine();
            while (line != null)
            {
                string[] userArray = line.Split('\0');
                if (txtBoxEditID.Text == userArray[0])
                {

                    leer.Close();
                    return true;
                }
                line = leer.ReadLine();
            }
            leer.Close();
            return false;
        }

        private void comboBoxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshTable(cmbBoxUserType.Text);
        }

        void refreshTable (string user)
        {
            listViewUsers.Columns.Clear();
            listViewUsers.Items.Clear();
            try
            {
                string[] text = File.ReadAllLines("Users.txt");
               switch (user)
                {
                    case "Profesor":
                        listViewUsers.Columns.Add("ID", 90);
                        listViewUsers.Columns.Add("Contraseña", 90);
                        listViewUsers.Columns.Add("Nombre", 110);

                        for (int i = 0; i < text.Length; i++)
                        {
                            string[] arrayText = text[i].Split('\0');
                            if (arrayText[2] == "Administrador")
                            {
                                ListViewItem item = new ListViewItem(arrayText[0]);
                                for (int a = 1; a < arrayText.Length ; a++)
                                {
                                    if (a != 2)
                                    {
                                        item.SubItems.Add(arrayText[a]);
                                    }
                                }

                                listViewUsers.Items.Add(item);
                            }
                        }
                        break;
                    case "Estudiante":
                        listViewUsers.Columns.Add("ID", 70);
                        listViewUsers.Columns.Add("Contraseña", 90);
                        listViewUsers.Columns.Add("Nombre", 110);
                        listViewUsers.Columns.Add("Carrera", 190);


                        for (int i = 0; i < text.Length; i++)
                        {
                            string[] arrayText = text[i].Split('\0');
                            if (arrayText[2] == "Estudiante")
                            {
                                ListViewItem item = new ListViewItem(arrayText[0]);
                                for (int a = 1; a < arrayText.Length ; a++)
                                {
                                    if (a != 2)
                                    {
                                        item.SubItems.Add(arrayText[a]);
                                    }
                                }

                                listViewUsers.Items.Add(item);
                            }
                        }
                        break;



                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
<<<<<<< HEAD
<<<<<<< HEAD

        

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            formMdiAdmin.ActiveForm.BackColor = Color.Yellow;
        }
=======
>>>>>>> parent of 30c4b62... 1.4.6
=======
>>>>>>> parent of 30c4b62... 1.4.6
    }
}
