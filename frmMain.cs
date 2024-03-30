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

namespace MiColmado
{
    public partial class frmMain : Sample
    {
        //static frmMain _obj;
        //public static frmMain instancia
        //{
        //    //get
        //    //{
        //    //    if (_obj == null)
        //    //    {
        //    //        _obj = new frmMain();
        //    //    }
        //    //    //return _obj;
        //    //}
        //}
        public frmMain()
        {
            InitializeComponent();
        }

        //metodo para añadir las pestañas cuando selecciones home,categoria etc
        public void AddControls(Form f) //es static
        {
            centerPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            centerPanel.Controls.Add(f);
            f.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //_obj = this;
            //para que aparezca el nombre de usuario en la barra lateral
            lbusuario.Text = MainClass.USER;
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

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
