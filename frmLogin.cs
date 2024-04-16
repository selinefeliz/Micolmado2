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
    public partial class frmLogin : Form
    {
        //esto es para que el programa se cierre por completo
        private bool closeApplicationAfterClose = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        //descomentar si quieres logearte con un usuario
        private void btnLogin_Click(object sender, EventArgs e)
        {
            ////validando las credenciales del usuario
            //if ((MainClass.IsValidUser(txtUsuario.Text, txtContrasena.Text)) == false)
            //{
            //    MessageBox.Show("Contraseña o usuario incorrectas");
            //    return;

            //}
            //else
            //{

            //    ///Para que se abra el form que sigue despues de logearse
            //    this.Hide();
            //    frmMain frm = new frmMain();
            //    frm.Show();

            //}

            //eliminar esta parte cuando descomentes el codigo que esta arriba
            this.Hide();
            frmMain frm = new frmMain();
            frm.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //este es el boton que cierra el frmLogin
        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            //esto hace que se cierre el programa por completo
            closeApplicationAfterClose = true;
            this.Close();

        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Verificar si se debe cerrar la aplicación después de que el formulario se cierre
            if (closeApplicationAfterClose)
            {
                Application.Exit(); // Cerrar la aplicación
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
