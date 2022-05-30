using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{

    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            this.StartPosition = FormStartPosition.CenterScreen;   
            InitializeComponent();
        }
        private void bttn_Continuar_Click(object sender, EventArgs e)
        {
            Temas temas = new Temas();
            temas.Opacity = 50;
            temas.Show();
            this.Hide();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bttn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
