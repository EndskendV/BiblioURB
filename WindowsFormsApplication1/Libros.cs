using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Libros : Form
    {
        public Libros()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        //conexión con la base de datos
        SqlConnection conexion = new SqlConnection(@"server=.\SQLEXPRESS; Initial Catalog=urban; integrated security=true");
        /// <Verificacion_de_conexion>
        /// Permite Recrear la conexion en caso de ser necesario, asi se evitan problemas cuandos e requiere
        /// de abrir otra conexion o instancia.
        /// </summary>
        void ConexionVerifing()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }conexion.Open();
        }
       
        int x = 0;
        void Activaciones(int OPC)
        {
            switch (OPC)
            {
                case 0: //INICIO 
                    bttn_Consult.Visible = true;
                    bttn_Modify.Visible = true;
                    bttn_Modify.Enabled = true;
                    bttn_Save.Visible = true;

                    Combo_Libro.Enabled = false; 
                    TXT_LibroName.Enabled = true;
                    TXT_AutorLibro.Enabled = true;
                    TXT_EditorialLibro.Enabled = true;
                    Combo_TemasLibros.Enabled = true;
                    Combo_fechaPublic.Enabled = true;   
                    txt_PrecioLibro.Enabled = true;

                    Combo_Libro.Items.Clear();
                    ConexionVerifing();
                    SqlCommand command1 = new SqlCommand("SELECT [ID_Book] from [Libros]", conexion);

                    SqlDataReader reader1 = command1.ExecuteReader();
                    while (reader1.Read())
                    {
                        Combo_Libro.Items.Add(reader1["ID_Book"].ToString());
                    }
                    conexion.Close();
                    break;
                case 1: //Seleccion Cancelar (CHECKBOX)
                    
                        CheckDelete.Checked = false;
                        bttn_Delete.Visible = false;
                        CheckDelete.Visible = false;
                        bttn_Save.Enabled = true;

                    Combo_Libro.Items.Clear();
                    TXT_AutorLibro.Text = "";
                    TXT_LibroName.Text = "";                    
                    TXT_EditorialLibro.Text = "";
                    Combo_TemasLibros.SelectedIndex = 0;
                    txt_PrecioLibro.Text = "";
                    Combo_Libro.Text = "###";
                    Combo_fechaPublic.Text = DateTime.Now.ToString();
                    Activaciones(0);

                    
                    break;
                case 2://Push Modify

                    CheckDelete.Visible = true;
                    bttn_Save.Enabled = false;
                    bttn_Save.Visible = true;
                    bttn_Delete.Enabled = false;
                    bttn_Delete.Visible = true;
                    bttn_Modify.Enabled = false;

                    Combo_fechaPublic.Enabled = true;
                    Combo_Libro.Enabled = true;
                    TXT_LibroName.Enabled = true;
                    TXT_AutorLibro.Enabled = true;
                    TXT_EditorialLibro.Enabled = true;
                    txt_PrecioLibro.Enabled=true;
                    Combo_TemasLibros.Enabled = true;

                 
                    if (x == 0)
                    {
                        MessageBox.Show("Ahora puedes Introducir la ID");
                        x = 1;
                    }
                    break;
                case 3://consultar
                    Activaciones(2);
                    TXT_EditorialLibro.Enabled = false;
                    bttn_Save.Enabled = false;
                    bttn_Save.Visible = false;
                    bttn_Delete.Enabled = false;
                    bttn_Delete.Visible = false;
                    bttn_Modify.Enabled = true;

                    txt_PrecioLibro.Enabled = false;
                    Combo_Libro.Enabled = true;
                    TXT_LibroName.Enabled = false;
                    TXT_AutorLibro.Enabled = false;
                    TXT_EditorialLibro.Enabled = false;
                    Combo_TemasLibros.Enabled = false;
                    Combo_fechaPublic.Enabled= false;


                    ConexionVerifing();
                    Combo_Libro.Items.Clear();
                    SqlCommand cmd = new SqlCommand("Select [ID_Book] from [Libros]", conexion);

                    SqlDataReader dr1 = cmd.ExecuteReader();
                    while (dr1.Read())
                    {
                        Combo_Libro.Items.Add(dr1["ID_Book"].ToString());
                    }
                    conexion.Close();
                    if (x == 0)
                    {
                        MessageBox.Show("Ahora puedes Introducir la ID");
                        x = 1;
                    }
                    break;
                default:
                    break;
            }
        }



        private void bttn_Save_Click(object sender, EventArgs e)
        {
            switch (bttn_Modify.Enabled==true)
            {
                case true: //Modo GUARDAR
                    ConexionVerifing();
                    try
                    {
                        SqlCommand sql = new SqlCommand(String.Format("INSERT INTO[dbo].[Libros] ([NameBook],[AutorBook],[EditorialB],[FechaPublicacion],[Tematica],[Precio])" +
                            " VALUES ('{0}','{1}','{2}','{3}','{4}','{5}') SELECT SCOPE_IDENTITY()", TXT_LibroName.Text, TXT_AutorLibro.Text, TXT_EditorialLibro.Text, Combo_fechaPublic.Text, Combo_TemasLibros.Text, txt_PrecioLibro.Text), conexion);
                        //sql.ExecuteNonQuery(); Evita duplicado.
                        // Se me hace extraño que ahora si guarde la fecha sin problemas....
                        string txx = sql.ExecuteScalar().ToString();
                        MessageBox.Show("Libro Registrado: ID--> " + txx, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Activaciones(1);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Revisa los datos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); conexion.Close();
                        conexion.Close();

                    } break;
                    case false: //MODO Modificacion
                    try
                    {
                        ConexionVerifing();
                        SqlCommand sqlCommand = new SqlCommand(string.Format("UPDATE Libros SET [NameBook] = '{0}', [AutorBook] = '{1}', [EditorialB] = '{2}', [FechaPublicacion] = '{3}', [Tematica] = '{4}', [Precio] = '{5}' WHERE ID_Book='{6}'",TXT_LibroName.Text, TXT_AutorLibro.Text, TXT_EditorialLibro.Text, Combo_fechaPublic.Text, Combo_TemasLibros.Text, txt_PrecioLibro.Text, Combo_Libro.Text), conexion);

                        sqlCommand.ExecuteNonQuery();
                        conexion.Close();
                        MessageBox.Show("Libro Modificado: ID--> " + Combo_Libro.Text, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Activaciones(1);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Revisa los datos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); conexion.Close();
                        conexion.Close();
                    }
                    break;
                default:
                    break;
            }
        }

        private void bttn_Modify_Click(object sender, EventArgs e)
        {
            Activaciones(2);

            Combo_Curso_SelectedIndexChanged(sender, e);
        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Estas Seguro", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {

                string Declaracion = "ID Eliminada: " + Combo_Libro.Text + "\nLibro: " + TXT_LibroName.Text + ". ";
                ConexionVerifing();
                SqlCommand SqlDel = new SqlCommand(String.Format("DELETE FROM [Libros] WHERE ID_Book ='{0}'", Combo_Libro.Text), conexion);
                try
                {
                    SqlDel.ExecuteNonQuery();
                    MessageBox.Show(Declaracion, "Eliminacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("No es posible eliminar, ya que otra categoria depende de este elemento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                SqlDel.Dispose();
            }
            Activaciones(1);
        }

        private void bttn_Consult_Click(object sender, EventArgs e)
        {
            Activaciones(3);
        }

        private void Curso_Load(object sender, EventArgs e)
        {
            Activaciones(0);
        }

        private void CheckDelete_CheckedChanged(object sender, EventArgs e)
        {
            Activaciones(1);
        }

        private void Combo_Curso_SelectedIndexChanged(object sender, EventArgs e)
        {
            bttn_Delete.Enabled = true;
            bttn_Save.Enabled = true;

            SqlCommand sql = new SqlCommand(String.Format("SELECT[NameBook],[AutorBook],[EditorialB],[FechaPublicacion],[Tematica],[Precio] FROM[dbo].[Libros] where[ID_Book] = '{0}'", Combo_Libro.Text), conexion);

            ConexionVerifing(); SqlDataReader reader = sql.ExecuteReader();

            if (reader.Read())
            {
                TXT_LibroName.Text = reader.GetString(0);
                TXT_AutorLibro.Text = reader.GetString(1);
                TXT_EditorialLibro.Text = reader.GetString(2);
                Combo_TemasLibros.Text = reader.GetString(4);
                Combo_fechaPublic.Text = reader.GetString(3);
                txt_PrecioLibro.Text = reader.GetDouble(5).ToString();
            }
            conexion.Close();

        }


    }
}
