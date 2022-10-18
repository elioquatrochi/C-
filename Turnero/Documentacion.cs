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

   
    public partial class Documentacion : Form
    {

        string conexion = "Data Source=DESKTOP-N6B6AO9;Initial Catalog=Turnero;Integrated Security=True";
        public Documentacion()
        {
            InitializeComponent();
        }

        #region Eventos

        private void Documentacion_Load(object sender, EventArgs e)
        {
            Lista();
            combo();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Alta();
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            Entrega();   
        }
        
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtId.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cboEstado.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value.ToString();


        }

        #endregion


        #region Metodos

        private void Alta()
        {
            NuevoDoc nd = new NuevoDoc();
            nd.ShowDialog();
            Lista();
        
        }

        private void Entrega()
        {


            string sqlsentecia = " update Documentacion set FechaEntrega = GETDATE(), Id_Estado=" + int.Parse(cboEstado.SelectedValue.ToString()) + "where Id_Documentacion =" + txtId.Text;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conexion;



            SqlCommand comm = new SqlCommand(sqlsentecia, conn);

            conn.Open();



            comm.ExecuteNonQuery();



            MessageBox.Show("Entregado");


            conn.Close();
            Lista();

        }

        public void Lista()
        {


            string sqlsentencia = "select d.Id_Documentacion,d.Apellido,d.Nombre,d.DNI,ed.Nombre as 'Estado',tr.Nombre as 'Tramite',d.FechaRecepcion as 'Fecha de Recepción',d.FechaEntrega as'Fecha de Entrega' from Documentacion as d left join Estados as ed on ed.ID_Estado = d.Id_Estado left join Tipo_Tramites as tr on tr.Id_Tramite = d.Id_Tramite";
            SqlConnection conn = new SqlConnection();


            conn.ConnectionString = conexion;

            SqlCommand comm = new SqlCommand(sqlsentencia, conn);

            conn.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;

            da.Fill(ds);

            conn.Close();

            dataGridView1.DataSource = null;

            dataGridView1.DataSource = ds.Tables[0];



        }

        public void combo()
        {


            string sqlsentecia = "Select * from Estados";
            SqlConnection conn = new SqlConnection();


            conn.ConnectionString = conexion;

            SqlCommand comm = new SqlCommand(sqlsentecia, conn);

            conn.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;

            da.Fill(ds);

            conn.Close();

            cboEstado.DataSource = null;

            cboEstado.DataSource = ds.Tables[0];
            cboEstado.DisplayMember = "Nombre";
            cboEstado.ValueMember = "Id_Estado";


        }

        #endregion
        
    }
}
