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
            string sid_inscprof = id_inscprof.Text;
            string spass_inscprof = pass_inscprof.Text;


            //co bdd
            string datasource = "CY-RT85O0N2T5PK\\SQLEXPRESS";
            string database = "trombinoscope1";
            string username = "usertrombi1";
            string password = "usertrombi1";
            string connString = @"Data Source=" + datasource + ";Database=" + database + ";Trusted_Connection=True;" + "User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            Response.Write("Connexion Reussie");


            //ajout user a bdd

            conn.Close();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}