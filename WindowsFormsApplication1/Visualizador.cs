using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
        SqlConnection conexion = new SqlConnection(@"server=.\SQLEXPRESS; Initial Catalog=next; integrated security=true");

        private void bttn_Regresar_Click(object sender, EventArgs e)
        {
          Temas temas = new Temas();
            temas.Show();
            this.Close();
            
        }
        private void bttn_Save_Click(object sender, EventArgs e)
        {
           try
            {
                if (combo_InstructorID.Enabled==true)
                {
                    SqlCommand cmd = new SqlCommand(String.Format("UPDATE Instructor SET [NameInstrcn] = '{0}',[ID_Dep] = '{1}' WHERE ID_Instructor= '{2}'",TXT_NAME.Text,combo_IDDep.Text,combo_InstructorID.SelectedItem.ToString()),conexion);
                    ConexionVerifing(); conexion.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Instructor Actualizado: ID--> " + combo_InstructorID.Text, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);conexion.Close();
                   

                }
                else
                switch (TXT_NAME.Text)
                {
                    case "":
                        MessageBox.Show("Verificar Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        ConexionVerifing(); conexion.Open();
                        // cmd.ExecuteNonQuery();

                        SqlCommand cmd = new SqlCommand(String.Format("INSERT into Instructor (NameInstrcn,ID_Dep) VALUES ('{0}','{1}') SELECT SCOPE_IDENTITY()", TXT_NAME.Text, combo_IDDep.Text), conexion);

                        int id = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                        conexion.Close();
                        MessageBox.Show("Instructor Registrad@: ID--> " + (id - 1).ToString(), "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        combo_InstructorID.Text = id.ToString();

                            TXT_NAME.Text = "";
                            
                        break;
                }
                
            }
           catch (Exception)
            {
                MessageBox.Show("Revisa los datos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); conexion.Close();
                conexion.Close();
            }
        }
        int x=0;

        void Activaciones(int OPC)
        {
            switch (OPC)
            {
                case 0: //INICIO
                    bttn_Consult.Visible = true;
                    bttn_Modify.Visible = true;
                    //bttn_Regresar.Visible = true;
                    bttn_Save.Visible = true;
                    combo_InstructorID.Enabled = false;
                    TXT_NAME.Enabled = true;
                    combo_IDDep.Enabled = true;
                    combo_IDDep.Items.Clear();

                    ConexionVerifing();
                    conexion.Open();
                    SqlCommand command1 = new SqlCommand("SELECT ID_Dep from Departamento", conexion);

                    SqlDataReader reader1 = command1.ExecuteReader();
                    while (reader1.Read())
                    {
                        combo_IDDep.Items.Add(reader1["ID_Dep"].ToString());
                    }
                    conexion.Close();
                    break;
                case 1: //Seleccion Cancelar (CHECKBOX)
                    if (combo_InstructorID.Enabled == true)
                    {
                        CheckDelete.Checked = false;
                        bttn_Delete.Visible = false;
                        CheckDelete.Visible = false;
                        bttn_Save.Enabled = true;
                        combo_InstructorID.Enabled=false;
                        TXT_NAME.Text = "";
                        Activaciones(0);

                    }
                    ///Poner ID siguientes
                    ///
                    

                    break;
                case 2://Push Modify

                    combo_InstructorID.Enabled = true;
                    CheckDelete.Visible = true;
                    bttn_Save.Enabled = false;
                    bttn_Save.Visible = true;
                    bttn_Delete.Enabled = false;
                    bttn_Delete.Visible = true;
                    combo_IDDep.Enabled = true;
                    TXT_NAME.Enabled = true;
                    ConexionVerifing();
                    combo_InstructorID.Items.Clear();
                    SqlCommand cmd = new SqlCommand("Select ID_Instructor FROM Instructor", conexion);
                    conexion.Open();
                    SqlDataReader dr1 = cmd.ExecuteReader();
                    while (dr1.Read())
                    {
                        combo_InstructorID.Items.Add(dr1["ID_Instructor"].ToString());
                    }
                    conexion.Close();
                    if (x == 0)
                    {
                        MessageBox.Show("Ahora puedes Introducir la ID");
                        x = 1;
                    }
                    break;
                case 3://consultar
                    combo_InstructorID.Enabled = true;
                    TXT_NAME.Enabled = false;
                    bttn_Save.Enabled = false;
                    bttn_Save.Visible = false;
                    bttn_Delete.Enabled = false;
                    bttn_Delete.Visible = false;
                    combo_IDDep.Enabled = false;

                    ConexionVerifing();
                    combo_InstructorID.Items.Clear();
                    SqlCommand cmd1 = new SqlCommand("Select ID_Instructor FROM Instructor", conexion);
                    conexion.Open();
                    SqlDataReader dr11 = cmd1.ExecuteReader();
                    while (dr11.Read())
                    {
                        combo_InstructorID.Items.Add(dr11["ID_Instructor"].ToString());
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

        private void Instructor_Load(object sender, EventArgs e)
        {
            Activaciones(0);
        }

        private void combo_InstructorID_SelectedIndexChanged(object sender, EventArgs e)
        {

            bttn_Delete.Enabled = true;
            bttn_Save.Enabled = true;
            ConexionVerifing();
            conexion.Open();
            SqlCommand cmd = new SqlCommand(String.Format("Select * FROM Instructor WHERE ID_Instructor= '{0}'",combo_InstructorID.Text),conexion);
            SqlDataReader dr = cmd.ExecuteReader();
           
            if (dr.Read())
            {
                TXT_NAME.Text=dr[1].ToString();
                combo_IDDep.Text=dr[2].ToString();
            }

        }

        private void combo_IDDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConexionVerifing();
            conexion.Open();
            SqlCommand cmd = new SqlCommand(String.Format("Select NameDep FROM Departamento WHERE ID_Dep= '{0}'", combo_IDDep.Text), conexion);
           // System.Threading.Thread.Sleep(1000);
            SqlDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                TXT_DepName.Text = dr1[0].ToString();
            }
            conexion.Close();


        }
        void ConexionVerifing()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        private void bttn_Modify_Click(object sender, EventArgs e)
        {
            Activaciones(2);
            AcceptButton = bttn_Save;
        }

        private void bttn_Consult_Click(object sender, EventArgs e)
        {
            Activaciones(3);
        }

        private void CheckDelete_CheckedChanged(object sender, EventArgs e)
        {
            Activaciones(1);
        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Estas Seguro", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {

                string Declaracion = "ID Eliminada: " + combo_InstructorID.Text + "\nNombre: " + TXT_NAME.Text + ". ";
                ConexionVerifing();                conexion.Open();
                Declaracion += "\nDepartamento: " + TXT_DepName.Text;
                SqlCommand sqlDel = new SqlCommand("DELETE FROM Instructor WHERE ID_Instructor =@ID", conexion);
                        sqlDel.Parameters.Add("ID", combo_InstructorID.SelectedItem.ToString());
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
                        sqlDel = null;


                conexion.Close();
                Activaciones(1);
                TXT_NAME.Text = "";
                combo_InstructorID.Text = "";
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Operacion Cancelada");
            }
        }
    }
}
