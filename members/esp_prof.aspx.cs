using System;
using System.Windows;
using System.Collections.Generic;
using System.Data.SqlClient;

using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DocumentFormat.OpenXml.Office.CustomUI;

namespace trombinoscope1.members
{
    public partial class esp_prof : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id_user = (Request.QueryString["id_user"] != null) ? Request.QueryString["id_user"] : "";
                Response.Write(id_user);
            
                //co bdd
                string datasource = "CY-RT85O0N2T5PK\\SQLEXPRESS";
                string database = "trombinoscope1";
                string username = "usertrombi1";
                string password = "usertrombi1";
                string connString = @"Data Source=" + datasource + ";Database=" + database + ";Trusted_Connection=True;" + "User ID=" + username + ";Password=" + password;
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();

                //requete pour les infos du prof a partir de l'id 
                SqlCommand command20;
                SqlDataReader datar20;
                String sql20, Output20 = ""; 
                sql20 = "Select * from users where id_user = '" + id_user + "'";

                command20 = new SqlCommand(sql20, conn);

                datar20 = command20.ExecuteReader();

                while (datar20.Read())
                {
                    Output20 = Output20 + datar20.GetValue(0) + "-" + datar20.GetValue(1) + "</br>";
                }
                conn.Close();
            }
        }
    }
}