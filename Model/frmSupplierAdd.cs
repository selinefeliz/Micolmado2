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
    public partial class frmSupplierAdd: SampleAdd
    {
        public frmSupplierAdd()
        {
            InitializeComponent();
        }

        private void frmSupplierAdd_Load(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
                    qry = @"Insert into Supplier values(@supName,@supPhone,@supEmail)";

                }
                else //actualizar
                {
                    qry = @"UPDATE Supplier set supName = @supName,
                                supPhone = @supPhone,
                                supEmail =@supEmail
                                where supID = @id";

                }

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@supEmail", txtEmail.Text);
                ht.Add("@supName", txtName.Text);
                ht.Add("@supPhone", txtPhone.Text);

                if (MainClass.SQL(qry, ht) > 0)
                {
                    MessageBox.Show("Datos Guardados correctamente", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Text = "";
                    txtPhone.Text = "";
                    txtEmail.Text = "";
                    txtName.Focus();
                }

            }
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
      
        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
