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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection(@"server=.\SQLEXPRESS; Initial Catalog=biblioteca; integrated security=true");
      //  SqlConnection conexionLo = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=biblioteca; Integrated Security=SSPI");
        private void button5_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            { // se crea el comando para dar de altas al sistema

                SqlCommand altas = new SqlCommand
                    ("insert into socio (id_Socio,nombre,direccion,tel) values(@id_socio,@nombre,@direccion,@telefono)", conexion);
                // se pasan los valores de los text box a las variables temporales
                altas.Parameters.AddWithValue("id_socio", textBox1.Text);
                altas.Parameters.AddWithValue("nombre", textBox2.Text);
                altas.Parameters.AddWithValue("direccion", textBox3.Text);
                altas.Parameters.AddWithValue("telefono", textBox4.Text);
                conexion.Open();// se abre la conexion
                altas.ExecuteNonQuery();
                conexion.Close();// se cierra la conexion
                MessageBox.Show("socio Almacenado");
                // limpiar los textbox
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

            }

        }

        private void button3_Click(object sender, EventArgs e)
         {        
            string baja = "DELETE FROM socio WHERE id_socio = @id_socio";
            conexion.Open();


            SqlCommand cmdIns = new SqlCommand(baja, conexion);
            cmdIns.Parameters.Add("id_socio", textBox1.Text);
            cmdIns.ExecuteNonQuery();

            cmdIns.Dispose();
            cmdIns = null;
            textBox1.Clear();

            conexion.Close();
            MessageBox.Show("socio eliminado");
        

           
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
/*
SqlCommand command1 = new SqlCommand("SELECT ID_Dep from Departamento", conexion);

SqlDataReader reader1 = command1.ExecuteReader();
while (reader1.Read())
{
    comboBox1.Items.Add(reader1["ID_Dep"].ToString());
}*/