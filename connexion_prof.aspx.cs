using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace trombinoscope1
{
    public partial class connexion_prof : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_connprof_Click(object sender, EventArgs e)
        {
            //recup donnees du form
            string username_coprof = username_connprof.Text;
            string pass_coprof = pass_connprof.Text;


            //co bdd
            string datasource = "CY-RT85O0N2T5PK\\SQLEXPRESS";
            string database = "trombinoscope1";
            string username = "usertrombi1";
            string password = "usertrombi1";
            string connString = @"Data Source=" + datasource + ";Database=" + database + ";Trusted_Connection=True;" + "User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            //ajout user a bdd
            SqlCommand command10;
            SqlDataReader datar10;
            String sql10, Output10 = ""; 
            sql10 = "Select PasswordHash from users where Username='" + username_coprof + "'";
            command10 = new SqlCommand(sql10, conn);
            datar10 = command10.ExecuteReader();
            while (datar10.Read())
            {
                Output10 = Output10 + datar10.GetValue(0);
            }
            if (Output10 == pass_coprof)
            {
                Response.Redirect("members/esp_prof.aspx");
            }
            else if(Output10 != pass_coprof)
            {
                Response.Write("Identifiant et / ou Mot de Passe Incorrect(s)"); 
            }
            datar10.Close();
            command10.Dispose();
            conn.Close(); 
        }

        protected void pass_connprof_TextChanged(object sender, EventArgs e)
        {

        }
    }

}