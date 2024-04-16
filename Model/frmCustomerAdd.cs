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
    public partial class frmCustomerAdd : SampleAdd
    {
        public frmCustomerAdd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
                    qry = @"Insert into Customer values(@name,@phone,@Email)";

                }
                else //actualizar
                {
                    qry = @"UPDATE Customer set cusName = @name,
                               cusPhone = @phone,
                               cusEmail =@Email
                               where cusID = @id";

                    

                }

            

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@name", txtName.Text);
                ht.Add("@phone", txtPhone.Text);
                ht.Add("@Email", txtEmail.Text);
               
               

                if (MainClass.SQL(qry, ht) > 0)
                {
                    MessageBox.Show("Datos Guardados correctamente", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    id = 0;
                    txtName.Text = "";
                    txtPhone.Text = "";
                    txtEmail.Text = "";
                    txtName.Focus();
                }

            }
        }

        private void frmCustomerAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
