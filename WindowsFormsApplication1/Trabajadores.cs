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
        SqlConnection conexion = new SqlConnection(@"server=.\SQLEXPRESS; Initial Catalog=urban; integrated security=true");

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
                    bttn_Save.Visible = true;

                    TXT_Name.Enabled = true;
                    Combo_ID.Enabled = true;


                    ConexionVerifing();
                    SqlCommand ComboFill = new SqlCommand("SELECT [ID_Personal] from [Personal]", conexion);

                    SqlDataReader reader1 = ComboFill.ExecuteReader();
                    while (reader1.Read())
                    {
                       // Combo_PlazaName.Items.Add(reader1["NamePlaza"].ToString());
                    }
                    ComboFill.Dispose(); reader1.Close();
                
                    conexion.Close();

                    break;
                case 1: //Seleccion Cancelar (CHECKBOX)

                    CheckDelete.Checked = false;
                    bttn_Delete.Visible = false;
                    CheckDelete.Visible = false;
                    bttn_Save.Enabled = true;

                    TxT_Mail.Enabled = true;
                    TxT_Domicilio.Enabled = true;
                    TXT_Name.Enabled=true;
                    TxT_Phone.Enabled = true;
                    Combo_Nac.Enabled = true;

                    Combo_ID.Items.Clear();
                    TXT_Name.Text = "";
                    Combo_ID.Text = "";
                    TxT_Domicilio.Text = "";
                    TxT_Mail.Text = "";
                    TxT_Phone.Text = "";
                    Activaciones(0);


                    break;
                case 2://Push Modify

                    CheckDelete.Visible = true;
                    bttn_Save.Enabled = false;
                    bttn_Save.Visible = true;
                    bttn_Delete.Enabled = false;
                    bttn_Delete.Visible = true;
                    bttn_Modify.Enabled = false;

                    TXT_Name.Enabled = true;
                    Combo_ID.Enabled = true;
                    TxT_Mail.Enabled = true;
                    TxT_Domicilio.Enabled = true;
                    TXT_Name.Enabled = true;
                    TxT_Phone.Enabled = true;
                    Combo_Nac.Enabled = true;
                    ConexionVerifing();
                    Combo_ID.Items.Clear();
                    SqlCommand cmd = new SqlCommand("Select [ID_Personal] FROM [Personal]", conexion);

                    SqlDataReader dr1 = cmd.ExecuteReader();
                    while (dr1.Read())
                    {
                        Combo_ID.Items.Add(dr1["ID_Personal"].ToString());
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



                    TXT_Name.Enabled = false;
                    Combo_ID.Enabled = true;
                    TxT_Phone.Enabled = false;
                    TxT_Domicilio.Enabled = false;
                    TxT_Mail.Enabled = false;
                    Combo_Nac.Enabled = false;

                    ConexionVerifing();
                    Combo_ID.Items.Clear();
                    SqlCommand cmd1 = new SqlCommand("Select ID_Personal FROM Personal", conexion);

                    SqlDataReader dr = cmd1.ExecuteReader();
                    while (dr.Read())
                    {
                        Combo_ID.Items.Add(dr["ID_Personal"].ToString());
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
                        DateTime dateTime= Convert.ToDateTime(Combo_Nac.Value.Date.ToString("dd-MM-yyyy"));
                        SqlCommand alta = new SqlCommand(String.Format("INSERT INTO[dbo].[Personal] ([NameP],[FechNacimiento],[DomicilioP],[MailP],[TelefonoP]) VALUES('{0}',@FechaNac,'{1}','{2}','{3}')", TXT_Name.Text, TxT_Domicilio.Text, TxT_Mail.Text, TxT_Phone.Text), conexion);
                        alta.Parameters.AddWithValue("@FechaNac", dateTime);
                        
                        alta.ExecuteNonQuery();
                        MessageBox.Show("Se ha registrado " + TXT_Name.Text, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                        DateTime dateTime = Convert.ToDateTime(Combo_Nac.Value.Date.ToString("dd-MM-yyyy"));
                        ConexionVerifing();
                        SqlCommand mod = new SqlCommand(String.Format("UPDATE [dbo].[Personal] SET[NameP] = '{0}',[FechNacimiento] = @FechaNac,[DomicilioP] = '{1}',[MailP] = '{2}',[TelefonoP] = '{3}' WHERE [ID_Personal]='{4}' ", TXT_Name.Text, TxT_Domicilio.Text, TxT_Mail.Text, TxT_Phone.Text, Combo_ID.Text), conexion); 
                        mod.Parameters.AddWithValue("@FechaNac",dateTime);
                        mod.ExecuteNonQuery();
                        MessageBox.Show("Se ha Modificado la ID: " + Combo_ID.Text, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        private void Combo_IDWk_SelectedIndexChanged(object sender, EventArgs e)
        {
            bttn_Delete.Enabled = true; 
            bttn_Save.Enabled = true;
            ConexionVerifing();

            SqlCommand TXTfill = new SqlCommand(String.Format("SELECT [NameP],[FechNacimiento],[DomicilioP],[MailP],[TelefonoP] FROM[dbo].[Personal] WHERE [ID_Personal]='{0}'", Combo_ID.SelectedItem.ToString()), conexion);
            SqlDataReader reader = TXTfill.ExecuteReader();
            if (reader.Read())
            {
                TXT_Name.Text = reader["NameP"].ToString();
                Combo_Nac.Text = reader["FechNacimiento"].ToString();
                TxT_Domicilio.Text = reader.GetString(2);
                TxT_Mail.Text = reader.GetString(3);
                TxT_Phone.Text = reader.GetString(4);
            }
            TXTfill.Dispose(); reader.Close();
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
                    SqlCommand sqlCommand = new SqlCommand(String.Format("DELETE FROM [dbo].[Personal] WHERE [ID_Personal] = '{0}'", Combo_ID.SelectedItem.ToString()), conexion);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Se ha eliminado el Trabajador.", "Eliminacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
