using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Turnero
{
    internal class Conection
    {
        private SqlConnection sCon = new SqlConnection();
        private string con = "Data Source=DESKTOP-N6B6AO9;Initial Catalog=Login;Integrated Security=True";
        public SqlConnection conectar()
        {
            try
            {
                sCon = new SqlConnection(con);
                if (sCon.State.Equals(ConnectionState.Open))
                {
                    sCon.Close();
                }
                else
                {
                    sCon.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            return sCon;

        }

    }
}
