using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace MiColmado
{
    internal class MainClass
    {
        //conexion con la base de datos

        public static readonly string con_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\selin\\OneDrive\\Documentos\\MiColmadoSQL.mdf;Integrated Security=True;Connect Timeout=30";
        public static SqlConnection con = new SqlConnection(con_string);

        //metodo para comprobar la validacion de usuario
        public static bool IsValidUser(string username, string password)
        {
            bool isValid = false;

            string qry = @"Select * from users where username = '" + username + "' and upass = '" + password + "' ";
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isValid = true;
                USER = dt.Rows[0]["uName"].ToString();
            }
            return isValid;
        }
        //crear la propiedad para el nombre de usuario asi aparece en el label
        public static string user;

        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }

        


    }
}
