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
    public partial class Libros : Form
    {
        public Libros()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        //conexión con la base de datos
        SqlConnection conexion = new SqlConnection(@"server=.\SQLEXPRESS; Initial Catalog=next; integrated security=true");
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
                    //bttn_Regresar.Visible = true;
                    bttn_Save.Visible = true;
                    //bttn_Delete.Visible = false;

                    
                    TXT_IDCurso.Enabled = true;
                    Combo_Curso.Enabled = true;
                    Combo_InstructorID.Enabled = true;
                    TXT_InstructorName.Enabled = false;
                    TXT_Horario.Enabled = true;
                    TXT_Lugar.Enabled = true;
                    Combo_TipoCurso.Enabled = true;

                    Combo_InstructorID.Items.Clear();
                    ConexionVerifing();
                    SqlCommand command1 = new SqlCommand("SELECT ID_Instructor from Instructor", conexion);

                    SqlDataReader reader1 = command1.ExecuteReader();
                    while (reader1.Read())
                    {
                        Combo_InstructorID.Items.Add(reader1["ID_Instructor"].ToString());
                    }
                    conexion.Close();
                    break;
                case 1: //Seleccion Cancelar (CHECKBOX)
                    
                        CheckDelete.Checked = false;
                        bttn_Delete.Visible = false;
                        CheckDelete.Visible = false;
                        bttn_Save.Enabled = true;

                    Combo_Curso.Items.Clear();
                    TXT_Horario.Text = "";
                    TXT_IDCurso.Text = "";                    
                    TXT_Lugar.Text = "";
                    Combo_Curso.Text = "";
                    Combo_TipoCurso.SelectedIndex = 0;
                    Activaciones(0);

                    
                    break;
                case 2://Push Modify

                    CheckDelete.Visible = true;
                    bttn_Save.Enabled = false;
                    bttn_Save.Visible = true;
                    bttn_Delete.Enabled = false;
                    bttn_Delete.Visible = true;
                    bttn_Modify.Enabled = false;

                    TXT_IDCurso.Enabled = false;
                    Combo_Curso.Enabled = true;
                    Combo_InstructorID.Enabled = true;
                    TXT_InstructorName.Enabled = false;
                    TXT_Horario.Enabled = true;
                    TXT_Lugar.Enabled = true;
                    Combo_TipoCurso.Enabled = true;

                    ConexionVerifing();
                    Combo_Curso.Items.Clear();  
                    SqlCommand cmd = new SqlCommand("Select NameCurso FROM Curso", conexion);
                  
                    SqlDataReader dr1 = cmd.ExecuteReader();
                    while (dr1.Read())
                    {
                        Combo_Curso.Items.Add(dr1["NameCurso"].ToString());
                    }
                    conexion.Close();
                    if (x == 0)
                    {
                        MessageBox.Show("Ahora puedes Introducir la ID");
                        x = 1;
                    }
                    break;
                case 3://consultar
                    Activaciones(2);
                    TXT_Lugar.Enabled = false;
                    bttn_Save.Enabled = false;
                    bttn_Save.Visible = false;
                    bttn_Delete.Enabled = false;
                    bttn_Delete.Visible = false;
                    bttn_Modify.Enabled = true;


                    TXT_IDCurso.Enabled = false;
                    Combo_Curso.Enabled = true;
                    Combo_InstructorID.Enabled = false;
                    TXT_InstructorName.Enabled = false;
                    TXT_Horario.Enabled = false;
                    TXT_Lugar.Enabled = false;
                    Combo_TipoCurso.Enabled = false;


                    ConexionVerifing();
                    Combo_InstructorID.Items.Clear();
                    SqlCommand cmd1 = new SqlCommand("Select ID_Instructor FROM Instructor", conexion);
                   
                    SqlDataReader dr11 = cmd1.ExecuteReader();
                    while (dr11.Read())
                    {
                        Combo_InstructorID.Items.Add(dr11["ID_Instructor"].ToString());
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

        private void bttn_Regresar_Click(object sender, EventArgs e)
        {
            Temas temas = new Temas();
            temas.Show();
            this.Close();
        }


        private void bttn_Save_Click(object sender, EventArgs e)
        {
            switch (bttn_Modify.Enabled==true)
            {
                case true: //Modo GUARDAR
                    ConexionVerifing();
                    try
                    {
                        SqlCommand sql = new SqlCommand(String.Format("INSERT INTO [dbo].[Curso] ([ID_Curso],[ID_Instructor],[NameCurso],[Horario],[LugarCurso],[TipoCurso])" +
                            " VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", TXT_IDCurso.Text, Combo_InstructorID.Text, Combo_Curso.Text, TXT_Horario.Text, TXT_Lugar.Text, Combo_TipoCurso.Text), conexion);
                        sql.ExecuteNonQuery();
                        MessageBox.Show("Curso Registrado: ID--> " + TXT_IDCurso.Text, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        SqlCommand sqlCommand = new SqlCommand(string.Format("UPDATE Curso SET [ID_Instructor] = '{0}', [NameCurso] = '{1}', [Horario] = '{2}', [LugarCurso] = '{3}', [TipoCurso] = '{4}' WHERE ID_Curso='{5}'", Combo_InstructorID.Text, Combo_Curso.SelectedItem.ToString(), TXT_Horario.Text, TXT_Lugar.Text, Combo_TipoCurso.SelectedItem.ToString(), TXT_IDCurso.Text), conexion);

                        sqlCommand.ExecuteNonQuery();
                        conexion.Close();
                        MessageBox.Show("Curso Modificado: ID--> " + TXT_IDCurso.Text, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Estas Seguro", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {

                string Declaracion = "ID Eliminada: " + TXT_IDCurso.Text + "\nCurso: " + Combo_Curso.Text + ". ";
                ConexionVerifing();
                SqlCommand SqlDel = new SqlCommand(String.Format("DELETE FROM Curso WHERE ID_Curso ='{0}'",TXT_IDCurso.Text), conexion);
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

        private void Combo_InstructorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand sql = new SqlCommand(String.Format("Select NameInstrcn FROM Instructor WHERE ID_Instructor= '{0}'",Combo_InstructorID.Text),conexion);
            
            ConexionVerifing();SqlDataReader reader = sql.ExecuteReader();

            if (reader.Read()) //Si no se coloca el DataReader queda vacio!!!
            {
                TXT_InstructorName.Text = reader["NameInstrcn"].ToString();
            }
            conexion.Close();
        }

        private void CheckDelete_CheckedChanged(object sender, EventArgs e)
        {
            Activaciones(1);
        }

        private void Combo_Curso_SelectedIndexChanged(object sender, EventArgs e)
        {
            bttn_Delete.Enabled = true;
            bttn_Save.Enabled = true;
            ConexionVerifing();
            SqlCommand cmd = new SqlCommand(String.Format("SELECT [ID_Curso],[ID_Instructor],[Horario],[LugarCurso],[TipoCurso] FROM[dbo].[Curso] WHERE [NameCurso]= '{0}'", Combo_Curso.SelectedItem.ToString()), conexion);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                TXT_IDCurso.Text = reader.GetString(0);
                try
                {
                TXT_Horario.Text = reader.GetString(2);
                }
                catch (Exception)
                {
                    TXT_Horario.Text = "";
                }
                TXT_Lugar.Text = reader.GetString(3);
                Combo_TipoCurso.Text = reader.GetString(4);
                Combo_InstructorID.Text = reader.GetInt32(1).ToString();
            }
            conexion.Close();
        }

    }
}
