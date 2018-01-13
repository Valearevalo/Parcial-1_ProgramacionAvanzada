using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProgramacionAvanzada.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=VALE\VALE;Initial Catalog=test;Integrated Security=True ");

        public void login(string usuario, string contraseña)
        {
            try
            {
                conn.Open();
                SqlCommand comand = new SqlCommand("SELECT Nombre, Tipo_Usuario FROM usuarios WHERE Usuario = @usuario AND Password = @password");
                comand.Parameters.AddWithValue("usuario", usuario);
                comand.Parameters.AddWithValue("password", contraseña);
                SqlDataAdapter adapter = new SqlDataAdapter(comand);
                DataTable db = new DataTable();
                adapter.Fill(db);

                if(db.Rows.Count == 1){
                    this.Hide();
                    if(db.Rows [0][1].ToString() == "Admin"){
                        new Admin(db.Rows[0][0].ToString()).Show();

                    } 
                    else if(db.Rows [0][1].ToString() == "Usuario")
                    {
                        new UsuarioComun (db.Rows[0][0].ToString()).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrecta");
                }
            }

            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login(this.textBox1.Text, this.textBox2.Text);
        }
    
    }
}
