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


namespace Turnero
{
    public partial class RegistroUsuario : Form
    {
      
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        string conectionString = "Data Source=DESKTOP-N6B6AO9;Initial Catalog=Login;Integrated Security=True";
        private void Alta()
        {


            
            string sqlSentencia = "insert into Login (usuario,contrasenia,Apellido,Telefono) values ('" + txtNombre.Text + "'," + txtContrasenia.Text + ",'" + txtApellido.Text + "'," + txtTelefono.Text + ")";

            SqlConnection scon = new SqlConnection();

            scon.ConnectionString = conectionString;

            SqlCommand comm = new SqlCommand(sqlSentencia, scon);

            scon.Open();


            var rest = comm.ExecuteNonQuery();

            scon.Close();
                








        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {


            Alta();
            MessageBox.Show("Usuario Registrado");

           

            borrar();

        }

        private void borrar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtContrasenia.Text = "";
            txtNombre.Focus();
           




        }
    }
}
