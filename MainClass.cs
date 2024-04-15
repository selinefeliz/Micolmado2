using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Reflection;
using System.Security.Cryptography;
using System.IO;
using ComboBox = System.Windows.Forms.ComboBox;  
using TextBox = System.Windows.Forms.TextBox;

namespace MiColmado
{
    internal class MainClass
    {
        //conexion con la base de datos (MODIFICAR PARA QUE USE LA BD DE TU MAQUINA) *Solo el string* OJO

        public static readonly string con_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\selin\\OneDrive\\Documentos\\MiColmado.mdf;Integrated Security=True;Connect Timeout=30";
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
                //para la imagen de usuario
                Byte[] imageArray = (byte[])dt.Rows[0]["uImage"];
                byte[] imageByteArray = imageArray;
                IMG = Image.FromStream(new MemoryStream(imageArray));
            }
            return isValid;
        }
        //para que pare de ponerse borroso
        public static void StopBuffering(Panel ctr, bool doubleBuffer)
        {
            try
            {
                typeof(Control).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance |
                    BindingFlags.SetProperty, null, ctr, new object[] {doubleBuffer});

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        //crear la propiedad para el nombre de usuario asi aparece en el label
        public static string user;

        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }
        //crear la propiedad para la imagen que aparezca en el controlPanel

        public static Image img;
        public static Image IMG
        {
            get { return img; }
            private set { img = value; }
        }
        //Para la imagen del usuario (falta por continuar)


        ///Metodo para crear las funciones de Create, Update, Read,Delete CURF operations
        ///
        public static int SQL(string qry, Hashtable ht)
        {
            int res = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                res = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
                
            }

            return res;
        }

        ////para cargar la data desde la base de datos
        public static void LoadData(string qry, DataGridView gv) //, ListBox lb)
        {

           // gv.CellFormatting += new DataGridViewCellFormattingEventHandler(gv_CellFormatting);
            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                /*
                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colNam1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colNam1].DataPropertyName = dt.Columns[i].ToString();

                }
                */
                gv.DataSource = dt;

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();

            }
        }

        ////para Darle formato a las filas del dataGridView
        /**private static void gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView gv = (DataGridView)sender;
            int count = 0;

            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
               // row.Cells[0].Value = count;
            }
            
        }
        */

        //para que se ponga borrrosa la pantalla 
        public static void BlurBackground(Form Model)
        {
            Form Backgroud = new Form();
            using (Model)
            {
                Backgroud.StartPosition = FormStartPosition.Manual;
                Backgroud.FormBorderStyle = FormBorderStyle.None;
                Backgroud.Opacity = 0.5d;
                Backgroud.BackColor = Color.Black;
                Backgroud.Size = frmMain.Instance.Size;
                Backgroud.Location = frmMain.Instance.Location;
                Backgroud.ShowInTaskbar = false;
                Backgroud.Show();
                Model.Owner = Backgroud;
                Model.ShowDialog(Backgroud);
                Backgroud.Dispose();
            }
        }

        ////for cb fill
        public static void CBFill(string qry, ComboBox cb)
        {
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb.DisplayMember = "name";
            cb.ValueMember = "id";
            cb.DataSource = dt;
            cb.SelectedIndex = -1;
        }

        //para validar que el usuario ingrese los datos para agregar un empleado o usuario
        public static bool Validation(Form F)
        {
            bool isValid = false;

            int count = 0;
            
            foreach (Control c in F.Controls)
            {
                //usando Tag del control para comprobar si queremos validar o no 
                if (Convert.ToString(c.Tag)!="" && Convert.ToString(c.Tag) !=null)
                {
                    if (c is TextBox)
                    {
                        TextBox t = (TextBox)c;
                        if (t.Text.Trim() == "")
                        {
                            t.ForeColor = Color.White; //aqui es BorderColor
                            t.BackColor = Color.Red; //modificar
                            count++;
                        }
                        else
                        {
                            t.ForeColor = Color.DarkCyan; //aqui es BorderColor
                            t.BackColor = Color.White; //modificar
                        }

                    }
                }

                if (count == 0)
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }

            }

            return isValid;
        }
    }
}
