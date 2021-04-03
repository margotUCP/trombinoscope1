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
            string datasource = "localhost\\SQLEXPRESS";
            string database = "trombinoscope1";
            string username = "usertrombi1";
            string password = "usertrombi1";
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Infor=True; User ID=" + username + "Password=" + password + ";";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            Response.Write("Connexion Reussie");
            conn.Close(); 

        }

        protected void btn_submitprof_Click(object sender, EventArgs e)
        {
            //recup de lid du prof
            string identifiantprof = txt_id_prof.Text;
            Response.Write(identifiantprof);
            //recup du pass prof
            string motdepasseprof = text_passprof.Text;
            Response.Write(motdepasseprof);


        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}