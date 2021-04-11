using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace trombinoscope1
{
    public partial class connexion_etu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitcoetu_Click(object sender, EventArgs e)
        {
            //recup donnees du form
            string idcoetud = idcoetu.Text;
            string passcoetud = mdpcoetu.Text;


            //co bdd
            string datasource = "CY-RT85O0N2T5PK\\SQLEXPRESS";
            string database = "trombinoscope1";
            string username = "usertrombi1";
            string password = "usertrombi1";
            string connString = @"Data Source=" + datasource + ";Database=" + database + ";Trusted_Connection=True;" + "User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();


            SqlCommand command10;
            SqlCommand command11;
            SqlDataReader datar10;
            SqlDataReader datar11;
            String sql10, sql11, Output10 = "", Output11 = "";
            sql10 = "Select PasswordHash from users where Username='" + idcoetud + "'";
            sql11 = "Select id_user from users where Username='" + idcoetud + "'";

            command10 = new SqlCommand(sql10, conn);
            command11 = new SqlCommand(sql11, conn);

            datar10 = command10.ExecuteReader();

            //recup pass_user
            while (datar10.Read())
            {
                Output10 = Output10 + datar10.GetValue(0);
            }

            datar10.Close();
            command10.Dispose();

            datar11 = command11.ExecuteReader();
            //recup id_user
            while (datar11.Read())
            {
                Output11 = Output11 + datar11.GetValue(0);
            }



            datar11.Close();
            command11.Dispose();

            //comparaison mdp
            if (Output10 == passcoetud)
            {
                Response.Redirect("members/esp_etu.aspx?id_user=" + Output11);
            }
            //le cas ou le mot de passe ne correspond pas 
            else if (Output10 != passcoetud)
            {
                Response.Write("Identifiant et / ou Mot de Passe Incorrect(s)");

                //on recup accessfail de l'user 
                SqlCommand command12;
                SqlDataReader datar12;
                String sql12, Output12 = "";
                sql12 = "Select AccessFailedCount from users where Username = '" + idcoetud + "'";
                command12 = new SqlCommand(sql12, conn);
                datar12 = command12.ExecuteReader();
                while (datar12.Read())
                {
                    Output12 = Output12 + datar12.GetValue(0);
                }
                datar12.Close();
                command12.Dispose();
                conn.Close();
            }
        }
    }
}