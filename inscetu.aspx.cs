using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace trombinoscope1
{
    public partial class inscetu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void submit_inscetu_Click(object sender, EventArgs e)
        {
            //connexion a la bdd
            string datasource = "CY-RT85O0N2T5PK\\SQLEXPRESS";
            string database = "trombinoscope1";
            string username = "usertrombi1";
            string password = "usertrombi1";
            string connString = @"Data Source=" + datasource + ";Database=" + database + ";Trusted_Connection=True;" + "User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            ///variables utiles à l'inscription dans la table users
            String type_inetu = "etu";
            String nom_inetu = nom_inscetu.Text; 
            String prenom_inetu = prenom_inscetu.Text; 
            String mail_inetu = mail_inscetu.Text; 
            String phone_inetu = phone_inscetu.Text; 
            String username_inetu = username_inscetu.Text; 
            String pass_inetu = pass_inscetu.Text;
            DateTime date = DateTime.Now;

            ///variables utiles à l'inscription dans la table etudiants
            int no_inetu = int.Parse(no_inscetu.Text);
            String niv_inetu = niv_inscetu.Text;
            String ad_inetu = ad_inscetu.Text;
            String filiere_inetu = filiere_inscetu.Text;

            //30recupération de id_filiere correspondant a la filiere selectionnée dans le form
            SqlCommand command30;
            SqlDataReader datar30;
            String sql30, Output30 = "";
            sql30 = "Select id_filiere from filieres where nom_filiere = '" + filiere_inetu + "'";
            command30 = new SqlCommand(sql30, conn);
            datar30 = command30.ExecuteReader(); 
            while (datar30.Read())
            {
                Output30 = Output30 + datar30.GetValue(0); 
            }
            command30.Dispose();
            int id_filiere = int.Parse(Output30);
            datar30.Close();

            /*filieres si
            int id_filiere = -1;
            if (filiere_inetu == "WS")
            {
                id_filiere = 5;
            }
            else if (filiere_inetu == "EG")
            {
                id_filiere = 124 ;
            }
            else if (filiere_inetu == "MIPI")
            {
                id_filiere = 3; 
            }
            else
            {
                id_filiere = 6; 
            }*/

            //inscription dans la table users
            SqlDataAdapter adapter31 = new SqlDataAdapter();
            String sql31 = "";
            sql31 = "Insert into users (type_user, nom_user, prenom_user, Email, EmailConfirmed, PasswordHash, SecurityStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEndDateUtc, LockoutEnabled, AccessFailedCount, Username) values ('" + type_inetu + "', '" + nom_inetu + "', '" + prenom_inetu + "', '" + mail_inetu + "', 'False', '" + pass_inetu + "', '', '" + phone_inetu + "', '0', '0', '" + date + "','0',  '0', '" + username_inetu + "')";
            adapter31.InsertCommand = new SqlCommand(sql31, conn);
            adapter31.InsertCommand.ExecuteNonQuery();
            adapter31.Dispose(); 

            //recup id_user de l'etu 
            SqlCommand command32;
            SqlDataReader datar32;
            String sql32; 
            int Output32 = -1;
            sql32 = "Select id_user from users where Username='" + username_inetu + "'";
            command32 = new SqlCommand(sql32, conn);
            datar32 = command32.ExecuteReader(); 
            while (datar32.Read())
            {
                Output32 = datar32.GetInt32(0);
            }
            int id_userinetu = Output32;
            command32.Dispose();
            datar32.Close();
            //string id_user = Output32;

            //insertion de l'utilisateur dans la table des étudiants
            //SqlCommand command33;
            SqlDataAdapter adapter33 = new SqlDataAdapter(); 
            String sql33 ="";
            sql33 = "Insert into etudiants (id_etu, n_etu, niv_etu, ad_etu, id_filiere) values ('" + id_userinetu + "','" + no_inetu + "','" + niv_inetu + "','" + ad_inetu + "','" + id_filiere + "')";
            adapter33.InsertCommand = new SqlCommand(sql33, conn);
            adapter33.InsertCommand.ExecuteNonQuery();
            adapter33.Dispose();
            //command33 = new SqlCommand(sql33, conn);  
            //int r33 = command33.ExecuteNonQuery();
            //command33.Dispose();
            conn.Close();
            Response.Redirect("connexion_etu.aspx");
        }
    }
}