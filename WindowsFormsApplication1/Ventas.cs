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
        SqlConnection conexion = new SqlConnection(@"server=.\SQLEXPRESS; Initial Catalog=urban; integrated security=true");

        void ConexionVerifing()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            conexion.Open();
        }
        private void Combo_Libro_SelectedIndexChanged(object sender, EventArgs e)
        {
            bttn_Consult.Enabled = true;
            ConexionVerifing();
            SqlCommand sqlCommand = new SqlCommand(String.Format("SELECT AutorBook,NameBook FROM [Libros] WHERE [ID_Book]='{0}'", Combo_Libros.SelectedItem.ToString()), conexion);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                txt_IDBook.Text = reader.GetString(1);
                txt_Autor.Text = reader.GetString(0);
            }
           
            conexion.Close();
        }

        private void Libroo_Load(object sender, EventArgs e)
        {
        }

        private void Grid_Libros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        void Activaciones(int c)
        {
            switch (c)
            {

                case 0://Inicio

                    ConexionVerifing();
                    Grid_Libros.Rows.Clear();
                    SqlCommand sqlCommand = new SqlCommand(String.Format("SELECT [ID_Book],[NameBook],[AutorBook],[Tematica],[Precio] FROM [dbo].[Libros]"), conexion);
                    SqlDataReader dr = sqlCommand.ExecuteReader();

                    while (dr.Read())
                    {
                        if (dr["Precio"].ToString() != "0")
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(Grid_Libros);
                            row.Cells[0].Value = dr["ID_Book"].ToString().Trim();

                            Combo_Libros.Items.Add(dr["ID_Book"].ToString());
                            row.Cells[1].Value = dr["NameBook"].ToString();
                            row.Cells[2].Value = dr["AutorBook"].ToString();
                            row.Cells[3].Value = dr["Tematica"].ToString();
                            row.Cells[4].Value = dr["Precio"].ToString();


                            Grid_Libros.Rows.Add(row);
                        }
                    }
                    dr.Close();
                    sqlCommand.Dispose();
                    for (int i = 0; i < Grid_Libros.RowCount - 1; i++)
                    {
                        sqlCommand = new SqlCommand(String.Format("Select [EstadoLibro],[ID_Personal],[Precio] FROM[dbo].[Ventas]where ID_Book='{0}'", Grid_Libros.Rows[i].Cells[0].Value), conexion);
                        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                        string temp = "";
                        int ttmp = 0;
                        if (sqlDataReader.Read())
                        {
                            try
                            {

                                Grid_Libros.Rows[i].Cells[5].Value = sqlDataReader.GetInt32(0);
                                Grid_Libros.Rows[i].Cells[6].Value = sqlDataReader.GetInt32(1);
                                temp = sqlDataReader.GetDouble(2).ToString();
                            }
                            catch (Exception)
                            {

                            }
                            for (int ii = 0; ii < 7; ii++)
                            {
                                if (sqlDataReader.GetInt32(0) != 0)
                                {
                                    Grid_Libros.Rows[i].Cells[ii].Style.BackColor = Color.Coral;
                                    if (int.TryParse(temp, out ttmp))
                                    {
                                        Grid_Libros.Rows[i].Cells[4].Value = ttmp;

                                    }
                                    Grid_Libros.Rows[i].Cells[5].Value = "Vendido";
                                    if (sqlDataReader.GetInt32(0) == 2)
                                    {
                                        Grid_Libros.Rows[i].Cells[ii].Style.BackColor = Color.Cyan;
                                        if (int.TryParse(temp, out ttmp))
                                        {
                                            Grid_Libros.Rows[i].Cells[4].Value = ttmp;

                                        }
                                        Grid_Libros.Rows[i].Cells[5].Value = "Prestado";
                                    }
                                }
                                else
                                {
                                    Grid_Libros.Rows[i].Cells[ii].Style.BackColor = Color.White;

                                    Grid_Libros.Rows[i].Cells[5].Value = "Disponible";
                                }
                            }

                            sqlDataReader.Close();

                        }



                    }

                    break;
                    case 1://Clave 
                    ConexionVerifing();
                    string query = "SELECT[NameP] FROM[dbo].[Personal] where[ID_Personal] = '{0}'";
                    sqlCommand = new SqlCommand(String.Format(query, txt_Clave.Text), conexion);
                    SqlDataReader r = sqlCommand.ExecuteReader();
                    try
                    {
                        if (r.Read())
                        {
                            txt_Clave.Text = r["NameP"].ToString();


                        }

                        r.Close();
                        sqlCommand.Dispose();
                    }
                    catch (Exception)
                    {
                        int s=0;
                        if (int.TryParse(LBL_CP.Text,out s)==true)
                        {

                        }
                        else
                        MessageBox.Show("Favor de introducir una clave Valida","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                        r.Close();
                        sqlCommand.Dispose();
                    }
                    try
                    {
                        for (int i = 0; i < Grid_Libros.RowCount - 1; i++)
                        {
                            sqlCommand = new SqlCommand(String.Format(query, Grid_Libros.Rows[i].Cells[6].Value), conexion);

                            r.Close();
                            sqlCommand.Dispose();
                            r = sqlCommand.ExecuteReader();

                            if (r.Read())
                            {
                                Grid_Libros.Rows[i].Cells[6].Value = r.GetString(0);
                                r.Close(); sqlCommand.Dispose();

                            }
                        }
                    }
                    catch (Exception)
                    {
                         
                    }  

                    conexion.Close();

                    break;

                default:
                   
                    break;
            }
        }
        private void Txt_Clave_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                //aqui codigo 
               Activaciones(1);
            }
        }

        private void bttn_Consult_Click_1(object sender, EventArgs e)
        {
            Activaciones(0);
            Activaciones(1);
            conexion.Close();
        }

        private void Sell_Click(object sender, EventArgs e)
        {
            try
            {



                ConexionVerifing();
                SqlCommand sqlCommand = new SqlCommand(String.Format("Select * From Personal Where NameP='{0}'", txt_Clave.Text), conexion);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    MessageBox.Show("Test");
                }//
                else { MessageBox.Show("Usuario Erroneo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);  throw new Exception(); }
                conexion.Close();

                ConexionVerifing();
                SqlCommand sqlCommand1 = new SqlCommand(String.Format("Select EstadoLibro from Ventas Where ID_Book='{0}'", Combo_Libros.Text), conexion);
                SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
                if (sqlDataReader1.Read())
                {
                    if (sqlDataReader1["EstadoLibro"].ToString() == "1" || sqlDataReader1["EstadoLibro"].ToString() == "2")
                    {

                        MessageBox.Show("Este libro Ya no esta disponible", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {

                        sqlDataReader1.Close(); sqlCommand1.Dispose();
                        ConexionVerifing();
                        sqlCommand = new SqlCommand(String.Format("UPDATE[dbo].[Ventas]SET[EstadoLibro] = 1,[ID_Personal] = '{0}',[Precio] = '{1}',[FechaAdq] = '{2}',[TelefonoAdq] = '{3}',[NombreAdq] = '{4}'WHERE[ID_Book] = '{5}'", LBL_CP.Text, txt_price.Text, dateTime.Text, txt_TelefonoAdq.Text, txt_NameAdq.Text, Combo_Libros.Text), conexion);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {

            }

            conexion.Close();
            Activaciones(0);

        }

        private void txt_Clave_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int X=int.Parse(txt_Clave.Text);
            LBL_CP.Text = txt_Clave.Text;

            }
            catch (Exception)
            {

            }
        }

        private void Bttn_search_Click(object sender, EventArgs e)
        {
            Activaciones(1);
        }

        private void bttn_Select_Click(object sender, EventArgs e)
        {
            try
            {
                Combo_Libros.SelectedIndex = Grid_Libros.CurrentRow.Index;
                txt_price.Text = (double.Parse(Grid_Libros.Rows[Combo_Libros.SelectedIndex].Cells[4].Value.ToString()) *1.5).ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione un Dato Valido","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Grid_Libros.RowCount-1; i++)
            {
                if (Grid_Libros.Rows[i].Cells[5].Value.ToString()!="Disponible")
                {
                    Grid_Libros.Rows.Remove(Grid_Libros.Rows[i]);i--;
                }
            }
            Combo_Libros.Items.Clear();
            for (int i = 0; i < Grid_Libros.RowCount-1; i++)
            {

                Combo_Libros.Items.Add(Grid_Libros.Rows[ i].Cells[0].Value);
            }
        }//ncp

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionVerifing();
                SqlCommand sqlCommand = new SqlCommand(String.Format("Select * From Personal Where NameP='{0}'", txt_Clave.Text), conexion);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                }//
                else { MessageBox.Show("Usuario Erroneo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); throw new Exception(); }
                conexion.Close();

                ConexionVerifing();
                SqlCommand sqlCommand1 = new SqlCommand(String.Format("Select EstadoLibro from Ventas Where ID_Book='{0}'", Combo_Libros.Text), conexion);
                SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
                if (sqlDataReader1.Read())
                {
                    if (sqlDataReader1["EstadoLibro"].ToString() == "0" || sqlDataReader1["EstadoLibro"].ToString() == "1")
                    {

                        MessageBox.Show("Este libro no esta disponible para Devolucion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {

                        sqlDataReader1.Close(); sqlCommand1.Dispose();
                        ConexionVerifing();
                        sqlCommand = new SqlCommand(String.Format("UPDATE[dbo].[Ventas]SET[EstadoLibro] = 0,[ID_Personal] = '{0}',[Precio] = NULL,[FechaAdq] = NULL,[TelefonoAdq] = NULL, [NombreAdq] = NULL WHERE[ID_Book] = '{1}'", LBL_CP.Text,Combo_Libros.Text), conexion);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {

            }
            Activaciones(0);
            conexion.Close();
        }
    }
}
