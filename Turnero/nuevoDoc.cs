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
    public partial class NuevoDoc : Form
    {
        string conexion = "Data Source=DESKTOP-N6B6AO9;Initial Catalog=Turnero;Integrated Security=True";
        public NuevoDoc()
        {
            InitializeComponent();
            combo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            Close();
        
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Guardar()
        {

            string sqlsentencia = "insert into Documentacion (Apellido,Nombre,DNI,Id_Tramite,Id_Estado,FechaRecepcion) values('" + txtApellido.Text + "',' " + txtNombre.Text + "'," + txtDNI.Text + "," + int.Parse( cboTramite.SelectedValue.ToString()) +"," + 2 + ", GETDATE()) ";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conexion;



            SqlCommand comm = new SqlCommand(sqlsentencia, conn);

            conn.Open();



            comm.ExecuteNonQuery();



            MessageBox.Show("Documentación Cargada");


            conn.Close();

        }
        public void combo()
        {


            string sqlsentencia = "Select * from Tipo_Tramites";
            SqlConnection conn = new SqlConnection();


            conn.ConnectionString = conexion;

            SqlCommand comm = new SqlCommand(sqlsentencia, conn);

            conn.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;

            da.Fill(ds);

            conn.Close();

            cboTramite.DataSource = null;

            cboTramite.DataSource = ds.Tables[0];
            cboTramite.DisplayMember = "Nombre";
            cboTramite.ValueMember = "Id_Tramite";


        }
    }
}
