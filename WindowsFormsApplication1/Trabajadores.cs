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
    public partial class Trabajadores : Form
    {
        public Trabajadores()
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

        void ConexionVerifing()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            conexion.Open();
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

                    TXT_IDCurso.Enabled = false;
                    TxT_IDDepartamento.Enabled = false;
                    TXT_IDPlaza.Enabled = false;
                    TXT_DocenteName.Enabled = true;
                    Combo_CursoName.Enabled = true;
                    Combo_DepartamentoName.Enabled = true;
                    Combo_IDDocente.Enabled = true;
                    Combo_PlazaName.Enabled = true;


                    ConexionVerifing();
                    SqlCommand ComboFill = new SqlCommand("SELECT NamePlaza from Plaza", conexion);

                    SqlDataReader reader1 = ComboFill.ExecuteReader();
                    while (reader1.Read())
                    {
                        Combo_PlazaName.Items.Add(reader1["NamePlaza"].ToString());
                    }
                    ComboFill.Dispose(); reader1.Close();
                    
                    ComboFill = new SqlCommand("SELECT NameDep FROM Departamento",conexion);
                    SqlDataReader reader2 = ComboFill.ExecuteReader();
                    while (reader2.Read())
                    {
                        Combo_DepartamentoName.Items.Add(reader2["NameDep"].ToString());
                    }
                    ComboFill.Dispose (); reader2.Close();

                    ComboFill = new SqlCommand("SELECT NameCurso FROM Curso", conexion);
                    SqlDataReader reader3=ComboFill.ExecuteReader();
                    while (reader3.Read())
                    {
                        Combo_CursoName.Items.Add(reader3["NameCurso"].ToString());
                    }
                    conexion.Close();

                    break;
                case 1: //Seleccion Cancelar (CHECKBOX)

                    CheckDelete.Checked = false;
                    bttn_Delete.Visible = false;
                    CheckDelete.Visible = false;
                    bttn_Save.Enabled = true;

                    Combo_CursoName.Items.Clear();
                    Combo_DepartamentoName.Items.Clear();
                    Combo_PlazaName.Items.Clear();
                    Combo_IDDocente.Items.Clear();
                    TXT_DocenteName.Text = "";
                    TXT_IDCurso.Text = "";
                    TxT_IDDepartamento.Text = "";
                    TXT_IDPlaza.Text = "";
                    Combo_PlazaName.Text = "";
                    Combo_IDDocente.Text = "";
                    Combo_DepartamentoName.Text = "";
                    Combo_CursoName.Text = "";

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
                    TxT_IDDepartamento.Enabled = false;
                    TXT_IDPlaza.Enabled = false;
                    TXT_DocenteName.Enabled = true;
                    Combo_CursoName.Enabled = true;
                    Combo_DepartamentoName.Enabled = true;
                    Combo_IDDocente.Enabled = true;
                    Combo_PlazaName.Enabled = true;

                    ConexionVerifing();
                    Combo_IDDocente.Items.Clear();
                    SqlCommand cmd = new SqlCommand("Select ID_Docente FROM Docente", conexion);

                    SqlDataReader dr1 = cmd.ExecuteReader();
                    while (dr1.Read())
                    {
                        Combo_IDDocente.Items.Add(dr1["ID_Docente"].ToString());
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
                    bttn_Save.Enabled = false;
                    bttn_Save.Visible = false;
                    bttn_Delete.Enabled = false;
                    bttn_Delete.Visible = false;
                    bttn_Modify.Enabled = true;

                    TXT_IDCurso.Enabled = false;
                    TxT_IDDepartamento.Enabled = false;
                    TXT_IDPlaza.Enabled = false;
                    TXT_DocenteName.Enabled = false;
                    Combo_CursoName.Enabled = false;
                    Combo_DepartamentoName.Enabled = false;
                    Combo_PlazaName.Enabled = false;
                    Combo_IDDocente.Enabled = true;

                    ConexionVerifing();
                    Combo_IDDocente.Items.Clear();
                    SqlCommand cmd1 = new SqlCommand("Select ID_Docente FROM Docente", conexion);

                    SqlDataReader dr = cmd1.ExecuteReader();
                    while (dr.Read())
                    {
                        Combo_IDDocente.Items.Add(dr["ID_Docente"].ToString());
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
        private void bttn_Consult_Click(object sender, EventArgs e)
        {
            Activaciones(3);
        }

        private void Docente_Load(object sender, EventArgs e)
        {
            Activaciones(0);
        }

        private void bttn_Modify_Click(object sender, EventArgs e)
        {
            Activaciones(2);
        }

        private void CheckDelete_CheckedChanged(object sender, EventArgs e)
        {
            Activaciones(1);
        }

        private void bttn_Save_Click(object sender, EventArgs e)
        {
            switch (bttn_Modify.Enabled)
            {
                case true:
                    try
                    {
                        ConexionVerifing();
                        SqlCommand alta = new SqlCommand(String.Format("INSERT INTO [dbo].[Docente] ([ID_Docente],[ID_Plaza],[ID_Dep],[NameDocente],[ID_Curso]) VALUES ('{0}','{1}','{2}','{3}','{4}')", Combo_IDDocente.Text, TXT_IDPlaza.Text, TxT_IDDepartamento.Text, TXT_DocenteName.Text, TXT_IDCurso.Text), conexion);
                        alta.ExecuteNonQuery();
                        MessageBox.Show("Se ha registrado " + TXT_DocenteName.Text, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Activaciones(1);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                    case false:
                    try
                    {
                        ConexionVerifing();
                        SqlCommand mod = new SqlCommand(String.Format("UPDATE[dbo].[Docente] SET[ID_Plaza] = '{0}',[ID_Dep] = '{1}',[NameDocente] = '{2}',[ID_Curso] = '{3}' WHERE[ID_Docente] = '{4}'", TXT_IDPlaza.Text, TxT_IDDepartamento.Text, TXT_DocenteName.Text, TXT_IDCurso.Text, Combo_IDDocente.SelectedItem.ToString()), conexion);
                        mod.ExecuteNonQuery();
                        MessageBox.Show("Se ha Modificado la ID: " + Combo_IDDocente.Text, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        private void Combo_IDDocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            bttn_Delete.Enabled = true; 
            bttn_Save.Enabled = true;
            ConexionVerifing();

            SqlCommand TXTfill = new SqlCommand(String.Format("Select ID_Plaza,ID_Dep,ID_Curso,NameDocente from Docente WHERE ID_Docente='{0}'", Combo_IDDocente.SelectedItem.ToString()), conexion);
            SqlDataReader reader = TXTfill.ExecuteReader();
            if (reader.Read())
            {
                TXT_IDPlaza.Text = reader.GetInt32(0).ToString();
                TxT_IDDepartamento.Text = reader.GetInt32(1).ToString();
                TXT_IDCurso.Text = reader.GetString(2);
                TXT_DocenteName.Text = reader.GetString(3);
            }
            TXTfill.Dispose(); reader.Close();
            SqlCommand ComboFill = new SqlCommand(String.Format("SELECT NamePlaza from Plaza WHERE ID_Plaza='{0}'",TXT_IDPlaza.Text), conexion);

            SqlDataReader reader1 = ComboFill.ExecuteReader();
            if (reader1.Read())
            {
                Combo_PlazaName.Text = reader1.GetString(0);
            }
            ComboFill.Dispose(); reader1.Close();
            ConexionVerifing();
            ComboFill = new SqlCommand(String.Format("SELECT NameDep FROM Departamento WHERE ID_Dep='{0}'",TxT_IDDepartamento.Text), conexion);
            SqlDataReader reader2 = ComboFill.ExecuteReader();
            if (reader2.Read())
            {
                Combo_DepartamentoName.Text = reader2.GetString(0);
            }
            ComboFill.Dispose(); reader2.Close();
            ConexionVerifing();
            ComboFill = new SqlCommand(String.Format("SELECT NameCurso FROM Curso WHERE ID_Curso= '{0}'",TXT_IDCurso.Text), conexion);
            SqlDataReader reader3 = ComboFill.ExecuteReader();
            if (reader3.Read())
            {
                Combo_CursoName.Text=reader3.GetString(0);
            }
            conexion.Close();
        }

        private void Combo_PlazaName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConexionVerifing();
            SqlCommand sql = new SqlCommand(String.Format("SELECT ID_Plaza from Plaza WHERE NamePlaza= '{0}'",Combo_PlazaName.Text),conexion);
            SqlDataReader reader = sql.ExecuteReader();
            if (reader.Read())
            {
                TXT_IDPlaza.Text=reader.GetInt32(0).ToString();
            }
            conexion.Close();
        }

        private void Combo_DepartamentoName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConexionVerifing();
            SqlCommand sql = new SqlCommand(String.Format("SELECT ID_Dep from Departamento WHERE NameDep= '{0}'", Combo_DepartamentoName.Text), conexion);
            SqlDataReader reader = sql.ExecuteReader();
            if (reader.Read())
            {
                TxT_IDDepartamento.Text = reader.GetInt32(0).ToString();
            }
            conexion.Close();

        }

        private void Combo_CursoName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConexionVerifing();
            SqlCommand sql = new SqlCommand(String.Format("SELECT ID_Curso from Curso WHERE NameCurso= '{0}'", Combo_CursoName.Text), conexion);
            SqlDataReader reader = sql.ExecuteReader();
            if (reader.Read())
            {
                TXT_IDCurso.Text = reader.GetString(0);
            }
            conexion.Close();

        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Estas Seguro", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                ConexionVerifing();
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(String.Format("DELETE FROM [dbo].[Docente] WHERE [ID_Docente] = '{0}'", Combo_IDDocente.SelectedItem.ToString()), conexion);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Se ha eliminado el Docente.", "Eliminacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("No es posible eliminar, ya que otra categoria depende de este elemento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Operacion Cancelada");
            }
            conexion.Close();
            Activaciones(1);
           
        }
    }
}
