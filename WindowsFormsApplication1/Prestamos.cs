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
    public partial class Prestamos : Form
    {
        public Prestamos()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void bttn_Regresar_Click(object sender, EventArgs e)
        {
            Temas temas = new Temas();
            temas.Show();
            this.Close();
        }
    }
}
