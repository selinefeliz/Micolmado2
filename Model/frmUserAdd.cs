using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                //39:29
                if (id == 0)//para insertar datos
                {

                }
                else //actualizar
                {

                }
              
            }
        }
        private void frmUserAdd_Load(object sender, EventArgs e)
        {

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
            ofd.Filter = "Images(.jpg, .png) | *.png, *jpg";
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
    }
}
