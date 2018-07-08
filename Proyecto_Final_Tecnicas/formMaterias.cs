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
            refreshMaterias();


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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();

            
        }

        private void formMaterias_Load(object sender, EventArgs e)
        {
            refreshMaterias();
            refreshTable();
        }

        void refreshMaterias()
        {
            cmbBoxMaterias.Items.Clear();
            System.IO.StreamReader leer = new System.IO.StreamReader("Materias.txt");
            string linea = leer.ReadLine();
            while (linea != null)
            {
                string[] materiaArray = linea.Split('\0');
                cmbBoxMaterias.Items.Add(materiaArray[0]);
                linea = leer.ReadLine();
            }
            leer.Close();
            txtBoxEditName.Text = "";
            txtBoxEditKey.Text = "";
            txtBoxEditTeacher.Text = "";
            cmbBoxEditCredit.SelectedIndex = -1;


        }

        private void cmbBoxMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

                string[] text = File.ReadAllLines("Materias.txt");
                
                for (int i=0; i< text.Length; i++)
                {
                    string[] arrayLines= text[i].Split('\0');
                    
                    if (cmbBoxMaterias.Text == arrayLines[0])
                    {
                        text[i] = txtBoxEditName.Text + "\0" + txtBoxEditKey.Text + "\0" + txtBoxEditTeacher.Text + "\0" + cmbBoxEditCredit.Text;                                               
                    }                                      
                }
                File.WriteAllLines("Materias.txt", text);
                refreshMaterias();
                txtBoxEditName.Text = "";
                txtBoxEditKey.Text = "";
                txtBoxEditTeacher.Text = "";
                cmbBoxEditCredit.SelectedIndex = -1;
                MessageBox.Show("Materia modificada exitosamente", "",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl.SelectedIndex == 0)
            {
                refreshTable();
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
    }
}
