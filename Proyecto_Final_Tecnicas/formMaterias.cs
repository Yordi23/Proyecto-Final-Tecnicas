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
            refreshMaterias(cmbBoxMaterias);


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
                    leer.Close();
                    return true;
                }
                line = leer.ReadLine();
            }
            leer.Close();
            return false;


        }

       

        private void formMaterias_Load(object sender, EventArgs e)
        {
            refreshMaterias(cmbBoxMaterias);
            refreshTable();
        }

        void refreshMaterias(ComboBox cmbBox)
        {
            cmbBox.Items.Clear();
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

        private void cmbBoxMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            txtBoxEditName.Enabled = true;
            txtBoxEditKey.Enabled = true;
            txtBoxEditTeacher.Enabled = true;
            cmbBoxEditCredit.Enabled = true;
            System.IO.StreamReader leer = new System.IO.StreamReader("Materias.txt");
            string linea = leer.ReadLine();
            while (linea != null)
            {
                string[] materiaArray = linea.Split('\0');
                if (cmbBoxMaterias.Text == materiaArray[0])
                {
                    txtBoxEditName.Text = materiaArray[0];
                    txtBoxEditKey.Text = materiaArray[1];                  
                    txtBoxEditTeacher.Text = materiaArray[2];
                    cmbBoxEditCredit.Text = materiaArray[3];
                    leer.Close();
                    return;
                }
                
                linea = leer.ReadLine();
            }
            leer.Close();
        }

        private void buttonEditAcept_Click(object sender, EventArgs e)
        {
            if ((txtBoxEditName.Text == "") || (txtBoxEditKey.Text == "") || (txtBoxEditTeacher.Text == "") || (cmbBoxEditCredit.Text == ""))
            {
                MessageBox.Show("La materia no ha sido modificada. Por favor, complete todos los campos correctamente", "Error",
           MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea modificar esta materia?", "",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    string[] text = File.ReadAllLines("Materias.txt");

                    for (int i = 0; i < text.Length; i++)
                    {
                        string[] arrayLines = text[i].Split('\0');

                        if (cmbBoxMaterias.Text == arrayLines[0])
                        {
                            text[i] = txtBoxEditName.Text + "\0" + txtBoxEditKey.Text + "\0" + txtBoxEditTeacher.Text + "\0" + cmbBoxEditCredit.Text;
                        }
                    }
                    File.WriteAllLines("Materias.txt", text);
                    refreshMaterias(cmbBoxMaterias);
                    txtBoxEditName.Text = "";
                    txtBoxEditKey.Text = "";
                    txtBoxEditTeacher.Text = "";
                    cmbBoxEditCredit.SelectedIndex = -1;
                    txtBoxEditName.Enabled = false;
                    txtBoxEditKey.Enabled = false;
                    txtBoxEditTeacher.Enabled = false;
                    cmbBoxEditCredit.Enabled = false;


                    MessageBox.Show("Materia modificada exitosamente", "",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 


            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    refreshTable();
                    break;
                case 1:
                    txtBoxName.Text = "";
                    txtBoxKey.Text = "";
                    txtBoxTeacher.Text = "";
                    cmbBoxCredit.SelectedIndex = -1;
                    txtBoxName.Focus();
                    refreshMaterias(cmbBoxMaterias);
                    break;
                case 2:
                    txtBoxEditName.Enabled = false;
                    txtBoxEditKey.Enabled = false;
                    txtBoxEditTeacher.Enabled = false;
                    cmbBoxEditCredit.Enabled = false;
                    txtBoxEditName.Text = "";
                    txtBoxEditKey.Text = "";
                    txtBoxEditTeacher.Text = "";
                    cmbBoxEditCredit.SelectedIndex = -1;
                    cmbBoxEditCredit.Focus();
                    refreshMaterias(cmbBoxMaterias);
                    break;
                case 3:
                    refreshMaterias(cmbBoxDeleteMateria);
                    break;
                


            }
            
            
            
           

        }

        void refreshTable()
        {
            string[] lines = File.ReadAllLines("Materias.txt");
            listView1.Items.Clear();
            for(int i = 0; i<lines.Length; i++)
            {
                string[] fields = lines[i].Split('\0');
                ListViewItem item = new ListViewItem(fields[0]);
                item.SubItems.Add(fields[1]);
                item.SubItems.Add(fields[2]);
                item.SubItems.Add(fields[3]);
                listView1.Items.Add(item);
                

            }

        }

        private void buttonDeleteMateria_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar esta materia?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string[] text = File.ReadAllLines("Materias.txt");
                string[] editedText = new string[text.Length - 1];
                int aux = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    string[] arrayLines = text[i].Split('\0');

                    if (cmbBoxDeleteMateria.Text != arrayLines[0])
                    {

                        editedText[aux] = text[i];
                        aux++;
                    }

                }
                aux = 0;
                File.WriteAllLines("Materias.txt", editedText);
                cmbBoxDeleteMateria.SelectedIndex = -1;

                MessageBox.Show("Materia eliminada exitosamente", "",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            formMdiAdmin.ActiveForm.BackColor = Color.Yellow;           
            
        }




        
    }
}
