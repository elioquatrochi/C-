using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace Turnero
{
      internal  class LoginMetodos : Conection
        {
            public DataTable ConsultarLogin(string usu, string pas)
            {
                string sqlStr = "select usuario, contrasenia from login where usuario = '" + usu + "' and contrasenia = '" +
                                pas + "'";

                //var c = AbrirConexion();


                //********************************************************
                var da = new SqlDataAdapter(sqlStr, conectar());
                var ds = new DataSet();
            da.Fill(ds);
                DataTable dt = ds.Tables[0];

                return dt;
                //*****************************************************
            }

       
        
        

    }
}


