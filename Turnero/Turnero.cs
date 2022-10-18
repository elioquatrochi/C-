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
    public partial class Turnero : Form
    {

        private string conexion = "Data Source=DESKTOP-N6B6AO9;Initial Catalog=Turnero;Integrated Security=True";

        public Turnero()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Seleccion();
            combo();
            
        }


        #region Eventos

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Alta();

        }

        private void lblBaja_Click(object sender, EventArgs e)
        {
            borrar();            
        }

        private void lblMODIFICACION_Click(object sender, EventArgs e)
        {
            modificacion();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtEdad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txthora.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox1.SelectedValue = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            


        }

        #endregion


        #region Metodos

        public void Seleccion()
        {


            string sqlsentecia = "select t.*,tt.Nombre as Tipo  from Turnero as t inner join Tipo_Tramites as tt on t.Id_Tramite= tt.Id_Tramite";
            SqlConnection conn = new SqlConnection();


            conn.ConnectionString = conexion;

            SqlCommand comm = new SqlCommand(sqlsentecia, conn);

            conn.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;

            da.Fill(ds);

            conn.Close();

            dataGridView1.DataSource = null;

            dataGridView1.DataSource = ds.Tables[0];



        }

        private void Alta()
        {


            string sqlsentecia = "insert into Turnero ( Nombre,Apellido,Edad,Dia,Hora,Id_Tramite)  Values ('" + txtNombre.Text + "',' " + txtApellido.Text + "'," + txtEdad.Text + ",'" + dtpDia.Text + "','" + txthora.Text + "', '" + int.Parse(comboBox1.SelectedValue.ToString()) + "')";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conexion;



            SqlCommand comm = new SqlCommand(sqlsentecia, conn);

            conn.Open();



            comm.ExecuteNonQuery();



            MessageBox.Show("Turno Guardado");


            conn.Close();

            Seleccion();
        }

        private void modificacion()
        {


            string sqlsentecia = " update Turnero set Nombre = '" + txtNombre.Text + "', Apellido = '" + txtApellido.Text + "', Edad = '" + txtEdad.Text
                    + "', Dia = '" + dtpDia.Text + "', Hora = '" + txthora.Text + "', Id_Tramite=" + int.Parse(comboBox1.SelectedValue.ToString()) + " where Id= " + txtId.Text;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conexion;



            SqlCommand comm = new SqlCommand(sqlsentecia, conn);

            conn.Open();



            comm.ExecuteNonQuery();



            MessageBox.Show("Turno Modificado");


            conn.Close();


            Seleccion();

        }

        private void borrar()
        {


            string sqlsentecia = "delete from Turnero where Id = '" + txtId.Text + "'";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conexion;



            SqlCommand comm = new SqlCommand(sqlsentecia, conn);

            conn.Open();



            comm.ExecuteNonQuery();



            MessageBox.Show("Turno Eliminado");


            conn.Close();

            Seleccion();


        }

        public void combo()
        {


            string sqlsentecia = "Select * from Tipo_Tramites";
            SqlConnection conn = new SqlConnection();


            conn.ConnectionString = conexion;

            SqlCommand comm = new SqlCommand(sqlsentecia, conn);

            conn.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;

            da.Fill(ds);

            conn.Close();

            comboBox1.DataSource = null;

            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Id_Tramite";


        }

        private void comboalta()
        {


            string sqlsentecia = "insert into Turnero (Nombre,Apellido,Edad,Dia,Hora,Id_Tramite)  Values ('" + txtNombre.Text + "',' " + txtApellido.Text + "'," + txtEdad.Text + ",'" + dtpDia.Text + "','" + txthora.Text + "', '" + int.Parse(comboBox1.SelectedValue.ToString()) + "')";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conexion;



            SqlCommand comm = new SqlCommand(sqlsentecia, conn);

            conn.Open();



            comm.ExecuteNonQuery();



            MessageBox.Show("Entregado");


            conn.Close();

        }

        #endregion
    }



}
