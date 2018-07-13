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
    public partial class formMdiAdmin : Form
    {
        

        public formMdiAdmin()
        {
            InitializeComponent();
        }

 

        private void pictureMateria_Click(object sender, EventArgs e)
        {
            this.switchVisibility(false);

            formMaterias formMaterias = new formMaterias();
            formMaterias.MdiParent = this;
            formSetPosition(formMaterias);
            formMaterias.Show();
            MdiClient ctlMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {

                    ctlMDI = (MdiClient)ctl;


                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                }
            }



        }

        public void switchVisibility (bool visible)
        {
            
            //this.pictureMateria.Visible = visible; 2 4 5
            //this.pictureCalificacion.Visible = visible;
            this.label2.Visible = visible;
            this.pictureBox2.Visible = visible;
            this.pictureBox4.Visible = visible;
            this.pictureBox5.Visible = visible;
            //this.pictureBox3.Visible = visible;
            this.buttonExit.Visible = visible;
            //this.pictureBoxBackground.Visible = visible;


        }

        private void formMdiAdmin_BackColorChanged(object sender, EventArgs e)
        {
            switchVisibility(true);
            this.BackColor = Color.White;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureCalificacion_Click(object sender, EventArgs e)
        {
            this.BringToFront();
            this.switchVisibility(false);
            formCalificaciones formCalificaciones = new formCalificaciones();
            formCalificaciones.MdiParent = this;
            formSetPosition(formCalificaciones);
            formCalificaciones.Show();
            MdiClient ctlMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {

                    ctlMDI = (MdiClient)ctl;


                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                }
            }
            formCalificaciones.BringToFront();
        }

        void formSetPosition (Form form1)
        {
            form1.StartPosition = FormStartPosition.Manual;
            form1.Left = 400;
            form1.Top = 225;
            form1.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.switchVisibility(false);
            formUsuarios formUsuarios = new formUsuarios();
            formUsuarios.MdiParent = this;
            formSetPosition(formUsuarios);
            formUsuarios.Show();
            MdiClient ctlMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    ctlMDI = (MdiClient)ctl;
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                }
            }
        }
        private void formMdiAdmin_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    ctlMDI = (MdiClient)ctl;
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.pictureBox2.Visible = true;
            this.pictureBox4.Visible = true;
            this.pictureBox5.Visible = true;
            formUsuarios formUsuarios = new formUsuarios();
            formUsuarios.Hide();
            formCalificaciones formCalificaciones = new formCalificaciones();
            formCalificaciones.Hide();
            formMaterias formMaterias = new formMaterias();
            formMaterias.Hide();


        }
    }
}
