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

        protected void Button1_Click(object sender, EventArgs e)
        {
            string nomet = rechnometu.Text; 
            //connexion a la bdd
            string datasource = "CY-RT85O0N2T5PK\\SQLEXPRESS";
            string database = "trombinoscope1";
            string username = "usertrombi1";
            string password = "usertrombi1";
            string connString = @"Data Source=" + datasource + ";Database=" + database + ";Trusted_Connection=True;" + "User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand commandre1;
            String sqlre1;
            SqlDataReader datarre1;
            String Outputre1 = "";
            sqlre1 = "Select nom_user from users where type_user= 'etu' and nom_user='" + rechnometu + "'";
            commandre1 = new SqlCommand(sqlre1, conn);
            datarre1 = commandre1.ExecuteReader();
            //recup nom
            while (datarre1.Read())
            {
                Outputre1 = Outputre1 + datarre1.GetValue(0);

            }
            Response.Write(Outputre1);
            datarre1.Close();
            commandre1.Dispose();
            Response.Write("Nom : " + Outputre1); 

            SqlCommand commandre2;
            String sqlre2;
            SqlDataReader datarre2;
            String Outputre2 = "";
            sqlre2 = "Select prenom_user from users where type_user= 'etu' and nom_user='" + nomet + "'";
            commandre2 = new SqlCommand(sqlre2, conn);
            datarre2 = commandre2.ExecuteReader();
            //recup prenom
            while (datarre2.Read())
            {
                Outputre2 = Outputre2 + datarre2.GetValue(0);

            }
            Response.Write(Outputre2);
            datarre2.Close();
            commandre2.Dispose();
            Response.Write("Prénom : " + Outputre2);

            SqlCommand commandre3;
            String sqlre3;
            SqlDataReader datarre3;
            String Outputre3 = "";
            sqlre3 = "Select Email from users where type_user= 'etu' and nom_user='" + rechnometu + "'";
            commandre3 = new SqlCommand(sqlre3, conn);
            datarre3 = commandre3.ExecuteReader();
            //recup mail
            while (datarre3.Read())
            {
                Outputre3 = Outputre3 + datarre3.GetValue(0);

            }
            Response.Write(Outputre2);
            datarre3.Close();
            commandre3.Dispose();
            Response.Write("Nom : " + Outputre3);

            //
            SqlCommand commandre4;
            String sqlre4;
            SqlDataReader datarre4;
            String Outputre4 = "";
            sqlre4 = "Select PhoneNumber from users where type_user= 'etu' and nom_user='" + rechnometu + "'";
            commandre4 = new SqlCommand(sqlre4, conn);
            datarre4 = commandre4.ExecuteReader();
            
            while (datarre4.Read())
            {
                Outputre4 = Outputre4 + datarre4.GetValue(0);

            }
            Response.Write(Outputre4);
            datarre4.Close();
            commandre4.Dispose();
            Response.Write("Téléphone : " + Outputre4);

            //
            SqlCommand commandre5;
            String sqlre5;
            SqlDataReader datarre5;
            String Outputre5 = "";
            sqlre5 = "Select id_user from users where type_user= 'etu' and nom_user='" + rechnometu + "'";
            commandre5 = new SqlCommand(sqlre5, conn);
            datarre5 = commandre5.ExecuteReader();
            //recup id_user
            while (datarre5.Read())
            {
                Outputre5 = Outputre5 + datarre5.GetValue(0);

            }
            Response.Write(Outputre4);
            datarre5.Close();
            commandre5.Dispose();
            //int id_usereture = Outputre5;

            //
            SqlCommand commandre6;
            SqlDataReader datarre6;
            String sqlre6, Outputre6 = "";
            sqlre6 = "Select id_filiere from etudiants where id_etu = '" + Outputre5 + "'";
            commandre6 = new SqlCommand(sqlre6, conn);
            datarre6 = commandre6.ExecuteReader();
            while (datarre6.Read())
            {
                Outputre6 = Outputre6 + datarre6.GetValue(0);
            }
            datarre6.Close();
            commandre6.Dispose();

            //
            SqlCommand commandre7;
            SqlDataReader datarre7;
            String sqlre7, Outputre7 = "";
            sqlre7 = "Select nom_filiere from filieres where id_filiere = '" + Outputre6 + "'";
            commandre7 = new SqlCommand(sqlre7, conn);
            datarre7= commandre7.ExecuteReader();
            while (datarre7.Read())
            {
                Outputre7 = Outputre7 + datarre7.GetValue(0);
            }
            string nomfilierereet = Outputre7;
            datarre7.Close();
            commandre7.Dispose();


            SqlCommand commandre8;
            SqlDataReader datarre8;
            String sqlre8;
            int Outputre8 = 0; 
            sqlre8 = "Select n_etu from etudiants where id_etu = '" + Outputre5 + "'";
            commandre8 = new SqlCommand(sqlre8, conn);
            datarre8 = commandre8.ExecuteReader();
            while (datarre8.Read())
            {
                Outputre8 = datarre8.GetInt32(0);
            }
            Response.Write("Numéro étudiant : " + Outputre8);
            datarre8.Close();
            commandre8.Dispose();

            conn.Close();
        }
    }
}