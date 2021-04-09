using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace trombinoscope1
{
    public partial class add_filiere : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_addfiliere_Click(object sender, EventArgs e)
        {
            string nnfiliere = nom_new_filiere.Text;
            string ufrfil = ufr_filiere.Text; 
            //connexion a la bdd
            string datasource = "CY-RT85O0N2T5PK\\SQLEXPRESS";
            string database = "trombinoscope1";
            string username = "usertrombi1";
            string password = "usertrombi1";
            string connString = @"Data Source=" + datasource + ";Database=" + database + ";Trusted_Connection=True;" + "User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand commandf;
            SqlDataAdapter adapterf = new SqlDataAdapter();
            String sqlf = "";
            sqlf = "Insert into filieres (nom_filiere, ufr) values ('" + nnfiliere + "', '" + ufrfil + "')";
            commandf = new SqlCommand(sqlf, conn);
            adapterf.InsertCommand = new SqlCommand(sqlf, conn);
            adapterf.InsertCommand.ExecuteNonQuery();
            conn.Close(); 
        }

        protected void nom_new_filiere_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //connexion a la bdd
            string datasource = "CY-RT85O0N2T5PK\\SQLEXPRESS";
            string database = "trombinoscope1";
            string username = "usertrombi1";
            string password = "usertrombi1";
            string connString = @"Data Source=" + datasource + ";Database=" + database + ";Trusted_Connection=True;" + "User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string filr = filrech.Text;
            SqlCommand commandrf;
            String sqlrf;
            SqlDataReader datarrf;
            String Outputrf = "";
            sqlrf = "Select id_filiere from filieres where nom_filiere='" + filr + "'";
            commandrf = new SqlCommand(sqlrf, conn);
            datarrf = commandrf.ExecuteReader();
            //recup id_user
            while (datarrf.Read())
            {
                Outputrf = Outputrf + datarrf.GetValue(0);
            }
            Response.Write(Outputrf); 
            datarrf.Close();
            commandrf.Dispose();
            conn.Close(); 
        }
    }
}