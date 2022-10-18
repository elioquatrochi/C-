using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turnero
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

      
        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Contador con = new Contador();
            con.Show();


        }

        private void turnoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Turnero of = new Turnero();

            of.Show();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
            Form1 frm1 = new Form1();
            frm1.Show();

        }

        private void registroUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RegistroUsuario regusu =new  RegistroUsuario();

            regusu.Show();


        }

        private void documentacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Documentacion doc = new Documentacion();
            doc.Show();


        }
    }
}
