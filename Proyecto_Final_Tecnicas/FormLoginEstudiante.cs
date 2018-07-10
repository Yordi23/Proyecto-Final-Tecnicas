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
    public partial class formLoginEstudiante : Form
    {
        public string userID;
        public formLoginEstudiante()
        {
            InitializeComponent();
        }

        private void formLoginEstudiante_Load(object sender, EventArgs e)
        {
            
            refreshTable();
            refreshLabels();
        }

        void refreshTable()
        {
            try
            {
                
                
                    string[] text = File.ReadAllLines("Calificaciones.txt");
                    for (int i = 0; i < text.Length; i = i + 3)
                    {
                        string[] arrayLines = text[i].Split('@');
                        if (userID == arrayLines[0])
                        {
                            lblIndice.Text = arrayLines[1];
                            string[] arrayMaterias = text[i + 1].Split('\0');
                            string[] arrayCalificaciones = text[i + 2].Split('@');
                            listViewCalifications.Columns.Clear();

                            for (int a = 0; a < arrayMaterias.Length - 1; a++)
                            {
                                listViewCalifications.Columns.Add(arrayMaterias[a], 90);
                            }
                            listViewCalifications.Items.Clear();
                            convertCalification(arrayCalificaciones);
                            ListViewItem item = new ListViewItem(arrayCalificaciones[0]);
                            for (int a = 1; a < arrayCalificaciones.Length - 1; a++)
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

        void convertCalification(string[] array)
        {
            for(int i=0; i<array.Length-1; i++)
            {
                if (Convert.ToInt32(array[i]) >= 90)
                {

                    array[i] = "A";
                }
                else if ((Convert.ToInt32(array[i]) >= 80) && (Convert.ToInt32(array[i]) < 90))
                {
                    array[i] = "B";

                }
                else if ((Convert.ToInt32(array[i]) >= 70) && (Convert.ToInt32(array[i]) < 80))
                {
                    array[i] = "C";

                }
                else if ((Convert.ToInt32(array[i]) >= 60) && (Convert.ToInt32(array[i]) < 70))
                {
                    array[i] = "D";

                }
                else if (Convert.ToInt32(array[i]) < 60)
                {
                    array[i] = "F";

                }


            }


        }

        void refreshLabels()
        {
            lblID.Text = userID;
            try
            {
                string[] text = File.ReadAllLines("Users.txt");
                
                for (int i = 0; i< text.Length; i++)
                {
                    string[] arrayLine = text[i].Split('\0');
                    if (arrayLine[0] == userID)
                    {
                        lblName.Text = arrayLine[3];
                        lblCarrera.Text = arrayLine[4];


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
        }
    }
}
