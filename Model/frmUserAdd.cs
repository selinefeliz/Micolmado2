using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;


namespace MiColmado
{
    public partial class frmUserAdd : SampleAdd
    {
        public frmUserAdd()
        {
            InitializeComponent();
        }
        public int id = 0;

        public override void btnSave_Click(object sender, EventArgs e)
        {
            //antes de guardar la imagen se necesita validacion
            if (MainClass.Validation(this)==false)
            {
                MessageBox.Show("Complete los campos requeridos", "Errores encontrados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string qry = "";
                if (id == 0)//para insertar datos
                {
                    qry = @"Insert into users values(@userName,@pass,@name,@phone,@image)";

                }
                else //actualizar
                {
                    qry = @"UPDATE users set userName = @userName
                                upass = @pass,
                                uName =@name,
                                uPhone = @phone,
                                uImage = @image
                                where userID = @id";

                }
                
                Image temp = new Bitmap(txtPic.Image);
                MemoryStream ms = new MemoryStream();
                temp.Save(ms,System.Drawing.Imaging.ImageFormat.Png);
                imageByteArray = ms.ToArray();

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@userName", txtUserName.Text);
                ht.Add("@pass", txtPass.Text);
                ht.Add("@name", txtName.Text);
                ht.Add("@phone", txtPhone.Text);
                ht.Add("@image", imageByteArray);

                if (MainClass.SQL(qry,ht)>0)
                {
                    MessageBox.Show("Datos Guardados correctamente", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    id = 0;
                    txtName.Text = "";
                    txtUserName.Text = "";
                    txtPass.Text = "";
                    txtPhone.Text = "";
                    txtPic.Image = MiColmado.Properties.Resources.userPic;
                    txtName.Focus();
                }

            }
        }
        private void frmUserAdd_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                LoadImage();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //boton para elegir la imagen del empleado
        public string filePath = "";
        Byte[] imageByteArray;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg, .png)|*.png; *jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                txtPic.Image = new Bitmap(filePath);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadImage()
        {
            string qry = @"Select uImage from users where userID = " +id+ " ";
            SqlCommand cmd = new SqlCommand(qry,MainClass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                byte[] imageArray = (byte[])dt.Rows[0]["uImage"];
                using (MemoryStream ms = new MemoryStream(imageArray))
                {
                    txtPic.Image = Image.FromStream(ms);
                }
            } 
        }

    
    
    
    
    }

}
