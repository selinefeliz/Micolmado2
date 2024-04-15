using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiColmado.Model
{
    public partial class frmCategoryAdd : SampleAdd 
    {
        public frmCategoryAdd()
        {
            InitializeComponent();
        }

        public int id = 0;
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
                    //qry = @"Insert into  values(@userName,@pass,@name,@phone,@image)"; modificado
                    qry = @"Insert into Category values(@name)";

                }
                else //actualizar
                {
                    qry = @"UPDATE Category set catName = @name
                          Where catID = @id";      

                               /* upass = @pass,
                                uName =@name,
                                uPhone = @phone,
                                uImage = @image*/
                               

                }

               /* Image temp = new Bitmap(txtPic.Image);
                MemoryStream ms = new MemoryStream();
                temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imageByteArray = ms.ToArray(); eliminadp*/

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@name", txtName.Text);
                //ht.Add("@userName", txtUserName.Text);
                //ht.Add("@pass", txtPass.Text);
                //ht.Add("@phone", txtPhone.Text);
                //ht.Add("@image", imageByteArray); Modificado

                if (MainClass.SQL(qry, ht) > 0)
                {
                    MessageBox.Show("Datos Guardados correctamente", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    id = 0;
                    txtName.Text = "";
                    txtName.Focus();
                    //txtUserName.Text = "";
                    //txtPass.Text = "";
                    //txtPhone.Text = ""; Modificado
                    //txtPic.Image = MiColmado.Properties.Resources.userPic;

                }

            }
        }
        private void frmCategoryAdd_Load(object sender, EventArgs e)
        {
             
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        public static implicit operator frmCategoryAdd(frmUserAdd v)
        {
            throw new NotImplementedException();
        }
    }
}
