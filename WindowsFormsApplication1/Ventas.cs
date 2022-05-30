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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        //conexión con la base de datos
        SqlConnection conexion = new SqlConnection(@"server=.\SQLEXPRESS; Initial Catalog=next; integrated security=true");

        private void bttn_Regresar_Click(object sender, EventArgs e)
        {
            Temas temas = new Temas();
            temas.Show();
            this.Close();
        }

        private void bttn_Consult_Click(object sender, EventArgs e)
        {
            ConexionVerifing();
            SqlCommand cmd = new SqlCommand(String.Format("SELECT * FROM Docente WHERE ID_Curso='{0}'",TXT_IDCURSO.Text),conexion);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            Grid_Alumnos.DataSource = dt;
            

            conexion.Close();
        }
        void ConexionVerifing()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            conexion.Open();
        }
        private void Combo_Grupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            bttn_Consult.Enabled = true;
            string temp = "";
            ConexionVerifing();
            SqlCommand sqlCommand = new SqlCommand(String.Format("SELECT ID_Curso,ID_Instructor FROM Curso WHERE NameCurso='{0}'",Combo_Grupo.SelectedItem.ToString()),conexion);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                TXT_IDCURSO.Text= reader.GetString(0);
                temp = reader.GetInt32(1).ToString();
            }
            sqlCommand.Dispose(); reader.Close();

            sqlCommand = new SqlCommand(String.Format("Select NameInstrcn from Instructor WHERE ID_Instructor='{0}'", temp), conexion);
            SqlDataReader reader1= sqlCommand.ExecuteReader();
            if (reader1.Read())
            {
                TXT_instructorName.Text= reader1.GetString(0);
            }
            conexion.Close();
        }

        private void Grupo_Load(object sender, EventArgs e)
        {
            ConexionVerifing();
            SqlCommand cmd = new SqlCommand("Select NameCurso FROM Curso",conexion);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Combo_Grupo.Items.Add(reader["NameCurso"].ToString());
            }
        }

        private void Grid_Alumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
