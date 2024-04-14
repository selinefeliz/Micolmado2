using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace MiColmado
{
    public partial class frmMain : Sample
    {
        static frmMain _obj;
        public static frmMain Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new frmMain();
                }
                return _obj;
            }
        }
        public frmMain()
        {
            InitializeComponent();
        }

        //metodo para añadir las pestañas cuando selecciones home,categoria etc
        public void AddControls(Form F)
        {
            this.centerPanel.Controls.Clear();
            F.Dock = DockStyle.Fill;
            F.TopLevel = false;
            centerPanel.Controls.Add(F);
            F.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _obj = this;
            //para que aparezca el nombre de usuario en la barra lateral
            lbusuario.Text = MainClass.USER;
            // Establecer la imagen del perfil
            pictureBox1.Image = MainClass.IMG;
        }
        

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //para que se abra el nuevo formulario de frmHome
            AddControls(new frmHome());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        //btnEmpleados
        private void button6_Click(object sender, EventArgs e)
        {
            //aqui se abre el formulario user View(el que tiene el datagridview)
            AddControls(new View.frmUserView()); 
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCategoria_Click(object sender, EventArgs e)//View2 utilizar
        {
            AddControls(new frmCategoryView());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {

        }

        //para que cuando se cierre el formulario Main aparezca el frmLogin
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin frml = new frmLogin();
            frml.Show();
        }
    }

    internal class frmCategoryView: Form
    {
    }
}
