using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace trombinoscope1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string datasource = "CY-RT85O0N2T5PK\\SQLEXPRESS";
            string database = "trombinoscope1";
            string username = "usertrombi1";
            string password = "usertrombi1";
            string connString = @"Data Source=" + datasource + ";Database=" + database + ";Trusted_Connection=True;" + "User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            Response.Write("Connexion Reussie");
            conn.Close();
        }

        protected void btnprof_Click(object sender, EventArgs e)
        {
            Response.Redirect("coprof.aspx");
        }

        protected void btnetu_Click(object sender, EventArgs e)
        {
            Response.Redirect("coetu.aspx");
        }

    }


}