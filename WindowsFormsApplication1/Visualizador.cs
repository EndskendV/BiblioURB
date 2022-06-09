using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    public partial class Visualizador : Form
    {
        public Visualizador()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        //Conexión con la base de datos 
        SqlConnection conexion = new SqlConnection(@"server=.\SQLEXPRESS; Initial Catalog=urban; integrated security=true");
  
        void ConexionVerifing()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            conexion.Open();
        }

        private void Viisualizador_Load(object sender, EventArgs e)
        {
            activaciones(0);
        }

        void    activaciones(int c)
        {
            switch (c)
            {

                case 0://Load
                    Grid_Libros.Rows.Clear();
                    ConexionVerifing();
                    SqlCommand cmd = new SqlCommand(String.Format("SELECT * FROM [Libros]"), conexion);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(Grid_Libros);
                        row.Cells[0].Value = dr[0].ToString();
                        row.Cells[1].Value = dr[1].ToString();
                        row.Cells[2].Value = dr[2].ToString();
                        row.Cells[3].Value = dr[3].ToString();
                        row.Cells[4].Value = dr[4].ToString();
                        row.Cells[5].Value = dr[5].ToString();
                        row.Cells[6].Value = dr[6].ToString();
                        Grid_Libros.Rows.Add(row);

                    }
                    cmd.Dispose(); dr.Dispose();

                    for (int i = 0; i < Grid_Libros.RowCount - 1; i++)
                    {
                        try
                        {

                            SqlCommand sqlCommand = new SqlCommand(String.Format("INSERT INTO[dbo].[Ventas]([ID_Book],[EstadoLibro]) VALUES ('{0}', '{1}')", Grid_Libros.Rows[i].Cells[0].Value, 0), conexion);
                            sqlCommand.ExecuteNonQuery();
                        }
                        catch (Exception)
                        {
                        }
                    }

                    cmd.Dispose(); dr.Dispose();

                    for (int i = 0; i < Grid_Libros.RowCount - 1; i++)
                    {
                        cmd = new SqlCommand(String.Format("Select EstadoLibro from Ventas Where ID_Book='{0}' ", Grid_Libros.Rows[i].Cells[0].Value), conexion);
                        dr = cmd.ExecuteReader();
                        if (dr.Read()) Grid_Libros.Rows[i].Cells[7].Value = dr["EstadoLibro"].ToString();
                        for (int ii = 0; ii < Grid_Libros.ColumnCount; ii++)
                        {
                            if (dr.GetInt32(0) != 0)
                            {
                                if (dr.GetInt32(0) == 1)
                                {
                                    Grid_Libros.Rows[i].Cells[ii].Style.BackColor = Color.Coral;

                                    Grid_Libros.Rows[i].Cells[7].Value = "Vendido";

                                }
                                else
                                {
                                    Grid_Libros.Rows[i].Cells[ii].Style.BackColor = Color.LightCyan;

                                    Grid_Libros.Rows[i].Cells[7].Value = "Prestado";
                                }
                            }
                            else
                            {

                                Grid_Libros.Rows[i].Cells[ii].Style.BackColor = Color.White;

                                Grid_Libros.Rows[i].Cells[7].Value = "Disponible";
                            }
                        }
                        cmd.Dispose(); dr.Dispose();
                    }
                    conexion.Close();
                    break;

                case 1://COLOR

                    break;
                default:
                    break;
            }
        }
        private void bttn_Consult_Click_1(object sender, EventArgs e)
        {
            activaciones(0);
        }
    }
}
