using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basededatos
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

            if (dt.Rows.Count == 1 )
            {
                MessageBox.Show("ingresaste correctamente");
                frmPrincipal frm = new frmPrincipal();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("No hay registros en la seleccion");
            }
        }
    }
    }

