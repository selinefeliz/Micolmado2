﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiColmado.reportes;

namespace MiColmado
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReporteEmpleado reporteEmpleado = new frmReporteEmpleado();
            reporteEmpleado.ShowDialog();
        }
    }
}
