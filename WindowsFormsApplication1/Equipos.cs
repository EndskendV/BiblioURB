using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Equipos : Form
    {
        public Equipos()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        //Conexión con la base de datos 
        SqlConnection conexion = new SqlConnection(@"server=.\SQLEXPRESS; Initial Catalog=urban; integrated security=true");
        string query = "INSERT INTO [dbo].[Computadoras] ([Disponible]) VALUES(1)  SELECT SCOPE_IDENTITY()";


        private void bttn_Regresar_Click(object sender, EventArgs e)
        {
            Temas temas = new Temas(); temas.Show();

            this.Dispose();
        }

        private void Se1ect_SelectedIndexChanged(object sender, EventArgs e)
        {
            Activaciones(0);
            Activaciones(1);            
        }
        int c = 1;

        private void bttn_Unlock_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Estas Seguro", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {

                SqlCommand cmd = new SqlCommand(String.Format("SELECT [ID_PC]      ,[Disponible]  FROM[dbo].[Computadoras]"), conexion);
                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                try
                {

                    while (reader.Read())
                        if (reader.GetInt32(0) == int.Parse(comboBox1.Text))
                        {
                            if (reader.GetInt32(1) == 0)
                            {

                                SqlCommand sqlCommand = new SqlCommand(String.Format("UPDATE [dbo].[Computadoras]   SET[Disponible] = 1 WHERE ID_PC= '{0}'", comboBox1.Text), conexion);

                                cmd.Dispose(); reader.Close();
                                sqlCommand.ExecuteNonQuery();
                            }
                            else MessageBox.Show("El equipo Ya esta desbloqueado");

                        }
                }
                catch (Exception)
                {
                    MessageBox.Show("Desbloqueada");
                }
                Activaciones(1);
                conexion.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Operacion Cancelada");
            }
        }
        private void bttn_Locky_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(String.Format("SELECT [ID_PC]      ,[Disponible]  FROM[dbo].[Computadoras]"), conexion);
            conexion.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {

                while (reader.Read())
                    if (reader.GetInt32(0) == int.Parse(comboBox1.Text))
                    {
                        if (reader.GetInt32(1)==1)
                        {

                            SqlCommand sqlCommand = new SqlCommand(String.Format("UPDATE [dbo].[Computadoras]   SET[Disponible] = 0 WHERE ID_PC= '{0}'", comboBox1.Text), conexion);

                            cmd.Dispose(); reader.Close();
                            sqlCommand.ExecuteNonQuery();
                        }
                        else MessageBox.Show("El equipo Ya esta bloqueado");

                    }
            }
            catch (Exception)
            {
                MessageBox.Show("Bloqueada");
            }
            Activaciones(1);
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
        void Activaciones(int OPC)
        {
            switch (OPC)
            {
                case 0: //INICIO
                    bttn_Lock.Visible = true;
                    bttn_Unlock.Visible=true;
                    bttn_Select.Visible = true;


                    break;
                case 1: //Actualizacion
                    SqlCommand cmd = new SqlCommand(String.Format("SELECT [ID_PC]      ,[Disponible]  FROM[dbo].[Computadoras]"), conexion);
                    ConexionVerifing();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DatosR.Rows.Clear();
                    comboBox1.Items.Clear();
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader.GetInt32(0));

                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(DatosR);
                        fila.Cells[0].Value = reader.GetInt32(0);
                        fila.Cells[1].Value = reader.GetInt32(1);
                        DatosR.Rows.Add(fila);
                    }
                    conexion.Close();
                    Activaciones(99);


                    break;
                case 2://Push Modify

                    break;
                case 3://consultar
                    bttn_Select.Visible = true;
                    bttn_Unlock.Enabled = false;
                    bttn_Unlock.Visible = true;
                    break;
                case 99: //Color celdas

                    for (int i = 0; i < DatosR.RowCount-1; i++)
                    {
                        if (DatosR.Rows[i].Cells[1].Value.ToString()=="1")
                        for (int ii = 0; ii < 2; ii++)
                        {
                                DatosR.Rows[i].Cells[ii].Style.BackColor = Color.Red;
                        }
                        else for (int ii = 0; ii < 2; ii++)
                            {
                                DatosR.Rows[i].Cells[ii].Style.BackColor = Color.GreenYellow;
                            }
                    }
                    
                    break;
                default:
                    break;
            }
        }

        private void Equipo_Load(object sender, EventArgs e)
        {
            //Poner para cargar la BD
            Activaciones(1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bttn_Unlock.Visible = true;
            bttn_Lock.Visible = true;

        }


        private void bttn_Consult_Click(object sender, EventArgs e)
        {
            Activaciones(3); comboBox1.Focus(); if (c==0)
            {
                try
                {
                    string a = comboBox1.Text;
                    comboBox1.SelectedItem = a;
                }
                catch (Exception)
                {
                comboBox1.SelectedIndex=0;
                    MessageBox.Show("ERROR, No existe ID!!");
                }

            }else
               comboBox1.SelectedIndex=0;
            
          
                c = 0; 
        }


        private void bttn_Select_Click(object sender, EventArgs e)
        {
            
            comboBox1.SelectedIndex=DatosR.CurrentRow.Index;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            comboBox1.SelectedIndex = DatosR.CurrentRow.Index;
        }
        int xx=0;

        private void AñadirPc_Click(object sender, EventArgs e)
        {    
            conexion.Open();
            SqlCommand cmd = new SqlCommand(query,conexion);
            
            xx=Convert.ToInt32(cmd.ExecuteScalar());
            conexion.Close();
            comboBox1.Items.Add(xx);

             DataGridViewRow fila = new DataGridViewRow();
             fila.CreateCells(DatosR);
             fila.Cells[0].Value = xx;
             fila.Cells[1].Value = "1";
             DatosR.Rows.Add(fila);
            Activaciones(99);
        }


        private void PC_Remove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Estas Seguro", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {

                string Declaracion = "PC Eliminada: " + DatosR.Rows[DatosR.RowCount-2].Cells[0].Value;
                conexion.Open();
                SqlCommand sqlDel = new SqlCommand(String.Format("DELETE FROM Computadoras WHERE ID_PC ='{0}'", DatosR.Rows[DatosR.RowCount - 2].Cells[0].Value), conexion);
              
                try
                {
                    sqlDel.ExecuteNonQuery();
                    MessageBox.Show(Declaracion, "Eliminacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("No es posible eliminar, ya que otra categoria depende de este elemento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                sqlDel.Dispose();


                conexion.Close();
                Activaciones(1);
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Operacion Cancelada");
            }
            DatosR.Rows.RemoveAt((DatosR.RowCount - 2));

        }
    }
}
