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
        SqlConnection conexion = new SqlConnection(@"server=.\SQLEXPRESS; Initial Catalog=next; integrated security=true");
        string query = "INSERT INTO dbo.Plaza(NamePlaza,TipoPlaza)VALUES(@NamePlaza, @TipoPlaza) SELECT SCOPE_IDENTITY()",
            query1 = "insert into Departamento (NameDep) values(@NAME) SELECT SCOPE_IDENTITY()";


        private void bttn_Regresar_Click(object sender, EventArgs e)
        {Temas temas = new Temas(); temas.Show();

            this.Dispose();
        }

        private void Se1ect_SelectedIndexChanged(object sender, EventArgs e)
        {
            Activaciones(0);
            Activaciones(1);            
        }
        int c = 1;

        private void bttn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Estas Seguro", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {

                string Declaracion = "ID Eliminada: " + TXT_ID.Text + "\nNombre: " + TXT_NAME.Text + ". ";
               
                conexion.Close();
                Activaciones(1);
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Operacion Cancelada");
            }
        }
        int x = 0;
        private void bttn_Modify_Click(object sender, EventArgs e)
        {
            AcceptButton = bttn_Save;
            if (c == 1||bttn_Save.Visible==false)
            {
            Activaciones(2);
                c= 0;
            }else if (bttn_Delete.Enabled==false)
            { MessageBox.Show("Favor seleccionar una ID Valida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand); }else
            { MessageBox.Show("Para guardar cambios presione Guardar", "Aviso",MessageBoxButtons.OK,MessageBoxIcon.Hand);}
            comboBox1.Focus();
        }
        void Activaciones(int OPC)
        {
            switch (OPC)
            {
                case 0: //INICIO
                    c = 1;
                    bttn_Consult.Visible = true;
                    bttn_Modify.Visible = true;
                    //bttn_Regresar.Visible = true;
                    bttn_Save.Visible = true;
                    break;
                case 1: //Seleccion Cancelar (CHECKBOX)
                    if (TXT_ID.Enabled == true)
                    {
                        CheckDelete.Checked = false;
                        bttn_Delete.Visible = false;
                        CheckDelete.Visible = false;
                        bttn_Save.Enabled = true;
                        TXT_ID.Enabled = false;
                        TXT_ID.Visible = true;
                        comboBox1.Visible = false;
                        c = 1;
                    }
                    //Colector ID siguiente
                    

                    break;
                case 2://Push Modify

                    TXT_ID.Enabled = true;
                    CheckDelete.Visible = true;
                    bttn_Save.Enabled = false;
                    bttn_Save.Visible = true;
                    bttn_Delete.Enabled = false;
                    bttn_Delete.Visible = true;
                    TXT_ID.Visible = false;
                    comboBox1.Visible = true;
                    if (x==0)
                    {
                        MessageBox.Show("Ahora puedes Introducir la ID");
                        x = 1;
                    }
                    break;
                case 3://consultar
                    TXT_ID.Enabled = true;
                    bttn_Save.Enabled = false;
                    bttn_Save.Visible = false;
                    bttn_Delete.Enabled = false;
                    bttn_Delete.Visible = false;
                    TXT_ID.Visible = false;
                    comboBox1.Visible = true;
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

        private void CheckDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckDelete.Checked==true)
            {
                Activaciones(1);
            }
        }

        private void Departamento_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bttn_Delete.Enabled = true;
            bttn_Save.Enabled = true;

            conexion.Open();


            conexion.Close();
        }

        private void plazaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bttn_Consult_Click(object sender, EventArgs e)
        {
            AcceptButton = bttn_Consult;
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


        private void bttn_Save_Click(object sender, EventArgs e)
        {
            //Agregar al sistema
            if (comboBox1.Visible==false)
            {

                Activaciones(1);
            }else
            {
                Activaciones(1);

            }

        }
    }
}
