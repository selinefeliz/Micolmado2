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
        static frmMain _obj;
        public static frmMain instancia
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
         

        private void frmMain_Load(object sender, EventArgs e)
        {
            _obj = this;
        }
    }
}
