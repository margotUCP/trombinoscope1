using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace trombinoscope1
{
    public partial class inscprof : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //recup donnees du form
            string type_user_inprof = "prof"; 
            string nom_inprof = nom_inscprof.Text;
            string prenom_inprof = prenom_inscprof.Text;
            string mail_inprof = mail_inscprof.Text;
            string phone_inprof = phone_inscprof.Text;
            string username_inprof = username_inscprof.Text; 
            string pass_inprof = pass_inscprof.Text;
            string bureau_inprof = bureau_inscprof.Text; 
            DateTime date = DateTime.Now; 

            string spass_incprof = pass_inscprof.Text;


            //co bdd
            string datasource = "CY-RT85O0N2T5PK\\SQLEXPRESS";
            string database = "trombinoscope1";
            string username = "usertrombi1";
            string password = "usertrombi1";
            string connString = @"Data Source=" + datasource + ";Database=" + database + ";Trusted_Connection=True;" + "User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            //ajout user a bdd
            SqlCommand command1, command3;
            SqlDataAdapter adapter1 = new SqlDataAdapter();
            String sql1;

            sql1 = "Insert into users (type_user, nom_user, prenom_user, Email, EmailConfirmed, PasswordHash, SecurityStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEndDateUtc, LockoutEnabled, AccessFailedCount, Username) values ('" + type_user_inprof + "', '" + nom_inprof + "', '" + prenom_inprof + "', '" + mail_inprof + "', 'False', '" + pass_inprof + "', '', '" + phone_inprof + "', '0', '0', '" + date + "','0',  '1', '" + username_inprof + "')";

            command1 = new SqlCommand(sql1, conn);
            adapter1.InsertCommand = new SqlCommand(sql1, conn);
            adapter1.InsertCommand.ExecuteNonQuery();
            command1.Dispose();

            SqlCommand command2; 
            String sql2; 
            SqlDataReader datar2;
            String Output2 = "";
            sql2 = "Select id_user from users where username = '" + username_inprof + "'";
            command2 = new SqlCommand(sql2, conn);
            datar2 = command2.ExecuteReader();
            //recup id_user
            while (datar2.Read())
            {
                Output2 = Output2 + datar2.GetValue(0);
            }

            datar2.Close();
            command2.Dispose();

            //insertion de id_prof dans la table des profs
            SqlDataAdapter adapter3 = new SqlDataAdapter();
            String sql3;
            sql3 = "Insert into professeurs (id_prof, b_prof) values ('" + Output2 + "','" + bureau_inprof + "')";
            command3 = new SqlCommand(sql3, conn);
            adapter3.InsertCommand = new SqlCommand(sql3, conn);
            adapter3.InsertCommand.ExecuteNonQuery();
            command1.Dispose();

            conn.Close();
            Response.Redirect("connexion_prof.aspx");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {

        }
    }
}