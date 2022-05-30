using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using FontAwesome.Sharp;

namespace WindowsFormsApplication1
{
    public partial class Temas : Form
    {
        //Campos
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //Inicializar form
        public Temas()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
        }
        public void MOSTRAR()
        {
            this.Show();
        }

        //Estructuras (structs)
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(139, 255, 251);
            public static Color color2 = Color.FromArgb(143, 255, 139);
            public static Color color3 = Color.FromArgb(251, 157, 251);
            public static Color color4 = Color.FromArgb(192, 183, 251);
            public static Color color5 = Color.FromArgb(247, 220, 180);
            public static Color color6 = Color.FromArgb(247, 180, 180);
        }

        // MÉTODOS

        // Para cuando esté activo un botón
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Botón
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(199, 0, 57);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Borde Izquierdo del botón
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // Icono del formulario hijo actual
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        // Para desactivar el resaltado del botón
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                //Botón
                currentBtn.BackColor = Color.FromArgb(144, 12, 63);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        // Abrir formulario hijo

        private void OpenChildForm(Form childform)
        {
            if(currentChildForm != null)
            {
                // Abrir un único formulario
                currentChildForm.Close();
            }
            currentChildForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childform);
            panelDesktop.Tag = childform;
            childform.BringToFront();
            childform.Show();
            labTitleChildForm.Text = childform.Text;
        }

        // Eventos click
        private void bttn_Salir_Click(object sender, EventArgs e)
        {
            
            InicioSesion inicioSesion = new InicioSesion();
            inicioSesion.Show();this.Close();

        }

        private void bttn_Depa_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Equipos());
            /*Departamento departamento = new Departamento();
            departamento.Show(); this.Hide();
            bttn_Depa.Focus();*/
        }

        private void bttn_Curso_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Libros());
            /*Curso curso = new Curso();
            curso.Show(); this.Hide();
            bttn_Curso.Focus();*/
        }

        private void bttn_Docente_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Trabajadores());
            /*Docente docente = new Docente();
            docente.Show();this.Hide();
            bttn_Docente.Focus();*/
        }

        private void bttn_Instructor_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new Visualizador());
            /*Instructor instructor = new Instructor();
            instructor.Show();this.Hide();
            bttn_Instructor.Focus();*/
        }

        private void bttn_Grupo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new Ventas());
            /*Grupo grupo = new Grupo();
            grupo.Show();this.Hide();   
            bttn_Grupo.Focus();*/
        }

        private void bttn_Asistencia_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new Prestamos());
            /*Asistencia asistencia = new Asistencia();
            asistencia.Show();this.Hide();
            bttn_Asistencia.Focus();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();this.Hide();
        }

        private void bttn_Home_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.LightSteelBlue;
            labTitleChildForm.Text = "Inicio";
        }

        private void labTitleChildForm_Click(object sender, EventArgs e)
        {

        }
    }
}
