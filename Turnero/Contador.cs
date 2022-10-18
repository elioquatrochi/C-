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
    public partial class Contador : Form
    {

        SqlConnection sqcon= new SqlConnection ("Data Source=DESKTOP-N6B6AO9;Initial Catalog=Turnero;Integrated Security=True");
        public Contador()
        {
            InitializeComponent();
        }

        private void Contador_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter("Select * from turnero", sqcon);
            DataSet dt = new DataSet();

            adaptador.Fill(dt,"Turnero");
            dataGridView1.DataSource = dt.Tables[0];


        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            SqlCommand sqlcomm = new SqlCommand("Select COUNT(*) from Turnero", sqcon);
            sqcon.Open();
            int contar = (int)sqlcomm.ExecuteScalar();
            lblContar.Text = contar.ToString() + " " +  "Total";
            sqcon.Close();

        }

        private void btnXdia_Click(object sender, EventArgs e)
        {
            SqlCommand sqlcomm = new SqlCommand("select COUNT(*)  from Turnero where Dia between '01/06/2022' AND '01/06/2022' ", sqcon);
            sqcon.Open();
            int contar = (int)sqlcomm.ExecuteScalar();
            lblpormes.Text = contar.ToString() + " " + "Total";
            sqcon.Close();


        }

        private void btnpormes_Click(object sender, EventArgs e)
        {

            SqlCommand sqlcomm = new SqlCommand("select COUNT(*) from Turnero where Dia between '01/06/2022' AND '07/06/2022'", sqcon);
            sqcon.Open();
            int contar = (int)sqlcomm.ExecuteScalar();
            lblporida.Text = contar.ToString() + " " + "Total";
            sqcon.Close();

          

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand sqlcomm = new SqlCommand("select COUNT(*) from Turnero where Dia between '01/06/2022' AND '01/07/2022'", sqcon);
            sqcon.Open();
            int contar = (int)sqlcomm.ExecuteScalar();
            lblxmes.Text = contar.ToString() + " " + "Total";
            sqcon.Close();




        }
    }
}
