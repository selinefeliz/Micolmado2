using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiColmado.Model
{
    public partial class frmProductAdd : SampleAdd
    {
        public frmProductAdd()
        {
            InitializeComponent();
        }

        public int id = 0;
        public int catID = 0;

        private void frmProductAdd_Load(object sender, EventArgs e)
        {
            string qry = "Select catID 'id', catName 'name' from Category";
            MainClass.CBFill(qry, cbCategoria);

            if(id>0)
            {
                cbCategoria.SelectedValue = catID;
                LoadImage();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPic_Click(object sender, EventArgs e)
        {

        }


        public override void btnSave_Click(object sender, EventArgs e)
        {
            //antes de guardar la imagen se necesita validacion
            if (MainClass.Validation(this) == false)
            {
                MessageBox.Show("Complete los campos requeridos", "Errores encontrados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string qry = "";
                if (id == 0)//para insertar datos
                {
                    qry = @"Insert into Product values(@pName,@pcatID, @barCode,@PCost,@pPrice, @image)";

                }
                else //actualizar
                {
                    qry = @"UPDATE Product set pName = @pName,
                                pcatID = @pcatID,
                                pBarcode = @barCode,
                                pCost = @PCost,
                                pPrice = @pPrice,
                                proImage = @image
                                where proID = @id";

                }

                Image temp = new Bitmap(txtPic.Image);
                MemoryStream ms = new MemoryStream();
                temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imageByteArray = ms.ToArray();

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@pName", txtNombre.Text); 
                ht.Add("@pcatID", Convert.ToInt32(cbCategoria.SelectedValue)); //video 5 revisar
                ht.Add("@barCode", txtCodigo.Text);
                ht.Add("@PCost", Convert.ToDouble(txtCosto.Text));
                ht.Add("@pPrice", Convert.ToDouble(txtPrecio.Text));
                ht.Add("@image", imageByteArray);

                if (MainClass.SQL(qry, ht) > 0)
                {
                    MessageBox.Show("Datos Guardados correctamente", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    id = 0;
                    txtNombre.Text = "";
                    txtCodigo.Text = "";
                    cbCategoria.SelectedIndex = 0;
                    cbCategoria.SelectedIndex = -1;
                    txtCosto.Text = ""; 
                    txtPrecio.Text = "";
                    txtPic.Image = MiColmado.Properties.Resources.productPic;
                    txtNombre.Focus();
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
            string qry = @"Select proImage from Product where proID = " + id + " ";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                byte[] imageArray = (byte[])dt.Rows[0]["proImage"];
                using (MemoryStream ms = new MemoryStream(imageArray))
                {
                    txtPic.Image = Image.FromStream(ms);
                }
            }
        }

        private void cbCategoria_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }



       
    }
}
