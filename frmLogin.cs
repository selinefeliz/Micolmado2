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
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //validando las credenciales del usuario
            if ((MainClass.IsValidUser(txtUsuario.Text, txtContrasena.Text)) == false)
            {
                MessageBox.Show("Contraseña o usuario incorrectas");
                return;

            }
            else
            {

                ///Para que se abra el form que sigue despues de logearse
                this.Hide();
                frmMain frm = new frmMain();
                frm.Show();
                
            }
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
