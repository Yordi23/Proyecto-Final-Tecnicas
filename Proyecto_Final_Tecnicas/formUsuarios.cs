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
            refreshID(cmbBoxDeleteUser);
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
            cmbBoxDeleteUser.SelectedIndex = -1;
            lblName.Text = "";


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
                                if (ExistUser(i))
                                {
                                    MessageBox.Show("El ID ya ha sido registrado anteriormente. Por favor, ingrese otro ID", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
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

        bool ExistUser(int num)
        {
            string[] leer = File.ReadAllLines("Users.txt");
            
            for(int i=0; i<leer.Length;i++)
            {
                string[] userArray = leer[i].Split('\0');
                if ((txtBoxEditID.Text == userArray[0]) && (i != num))
                {

                    
                    return true;
                }
                
            }
            
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

        /*private void buttonDeleteMateria_Click(object sender, EventArgs e)
        {
            bool student = false;
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar este usuario?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
                if (dialogResult == DialogResult.Yes)
                {
                try
                {
                    string[] text = File.ReadAllLines("Users.txt");
                    string[] editedText = new string[text.Length - 1];
                    int aux = 0;
                    for (int i = 0; i < text.Length; i++)
                    {
                        string[] arrayLines = text[i].Split('\0');
                        if (cmbBoxDeleteUser.Text == arrayLines[0])
                        {
                            if(arrayLines[2] == "Estudiante")
                            {
                                student = true;
                            }
                        }
                        if (cmbBoxDeleteUser.Text != arrayLines[0])
                        {

                            editedText[aux] = text[i];
                            aux++;
                        }

                    }
                    aux = 0;

                    File.WriteAllLines("Users.txt", editedText);

                    if (student)
                    {
                        string[] text2 = File.ReadAllLines("Calificaciones.txt");
                        string[] editedText2 = new string[text2.Length - 3];

                        for (int i = 0; i < text2.Length-1; i++)
                        {
                            string[] arrayLines = text2[i].Split('@');
                            if(cmbBoxDeleteUser.Text == arrayLines[0])
                            {
                                i = i + 2;
                            }
                            else
                            {
                                editedText2[aux] = text2[i];
                                aux++;

                            }
                            

                        }
                        aux = 0;

                        File.WriteAllLines("Calificaciones.txt", editedText2);
                    }


                    MessageBox.Show("Usuario eliminado exitosamente", "",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshID(cmbBoxDeleteUser);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            
            cmbBoxDeleteUser.SelectedIndex = -1;
        }*/

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            formMdiAdmin.ActiveForm.BackColor = Color.Yellow;
        }

        private void buttonDeleteMateria_Click(object sender, EventArgs e)
        {

        }

        void refreshName(ComboBox cmbBox, Label label)
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

        private void cmbBoxDeleteUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshName(cmbBoxDeleteUser, lblName);
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {

            bool student = false;
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar este usuario?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string[] text = File.ReadAllLines("Users.txt");
                    string[] editedText = new string[text.Length - 1];
                    int aux = 0;
                    for (int i = 0; i < text.Length; i++)
                    {
                        string[] arrayLines = text[i].Split('\0');
                        if (cmbBoxDeleteUser.Text == arrayLines[0])
                        {
                            if (arrayLines[2] == "Estudiante")
                            {
                                student = true;
                            }
                        }
                        if (cmbBoxDeleteUser.Text != arrayLines[0])
                        {

                            editedText[aux] = text[i];
                            aux++;
                        }

                    }
                    aux = 0;

                    File.WriteAllLines("Users.txt", editedText);

                    if (student)
                    {
                        string[] text2 = File.ReadAllLines("Calificaciones.txt");
                        string[] editedText2 = new string[text2.Length - 3];

                        for (int i = 0; i < text2.Length ; i++)
                        {
                            string[] arrayLines = text2[i].Split('@');
                            if (cmbBoxDeleteUser.Text == arrayLines[0])
                            {
                                i = i + 2;
                            }
                            else
                            {
                                editedText2[aux] = text2[i];
                                aux++;

                            }


                        }
                        aux = 0;

                        File.WriteAllLines("Calificaciones.txt", editedText2);
                    }


                    MessageBox.Show("Usuario eliminado exitosamente", "",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshID(cmbBoxDeleteUser);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            refreshID(cmbBoxEditUser);
            cmbBoxDeleteUser.SelectedIndex = -1;
            lblName.Text = "";
        }
    }
}
