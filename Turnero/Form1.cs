using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace Turnero
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

     

        private void btnIngresar_Click(object sender, EventArgs e)
        {
         



            var dt = new DataTable();
            var usu = new LoginMetodos();
            var usuario = txtUsuario.Text;
            var pas = txtContraseña.Text;

            dt = usu.ConsultarLogin(usuario, pas);

        



            if (usuario == "Admin" || usuario == "Admin2" && pas == "123")
            {

                
                MessageBox.Show("Ingreso Correcto");
                AdminLogin ofrmprincipal = new AdminLogin();
                this.Hide();
                ofrmprincipal.Show();

            

        }

       else  if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Ingreso Correcto");
                var frm = new frmPrincipal();
                this.Hide();
                frm.Show();


            }
            else
            {
                MessageBox.Show("Ingreso Incorrecto.Vuelva a intentarlo");


            }


           


            }

        private void timer1_Tick(object sender, EventArgs e)
        {




        }

     
        }
    }







    

