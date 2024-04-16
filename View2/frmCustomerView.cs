﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiColmado.Model;

namespace MiColmado.View2
{
    public partial class frmCustomerView : SampleView
    {
        public frmCustomerView()
        {
            InitializeComponent();
        }

        private void frmCustomerView_Load(object sender, EventArgs e)
        {
            LoadData();
            AgregarDgv(); //agrega los nuevos campos

            txtSearch.KeyPress += txtSearch2_KeyPress; // Suscribir el evento KeyPress al método txtSearch_KeyPress

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
        }
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmCustomerAdd()); //aqui se abre el nuevo formulario
            LoadData();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        //para que carge los datos del data grid view
        private void LoadData()
        {
            //ListBox lb = new ListBox();
            //lb.Items.Add(cID);
            //lb.Items.Add(cNum);
            //lb.Items.Add(cName);
            //lb.Items.Add(cphone);
            //lb.Items.Add(cEmail);

            //string qry = @"Select userID as ID, userName as NombreUsuario, upass as Contraseña, uName as Nombre, uPhone as Telefono from users";
            string qry = @"Select cusName as Nombre, CusPhone as Telefono, CusEmail as Email from Customer";



            //Agregar una cláusula WHERE para filtrar los resultados según el texto ingresado en txtSearch
            if (!string.IsNullOrWhiteSpace(txtSearch2.Text))
            {
                // Agregar una condición OR para buscar en múltiples campos
                qry += " WHERE cusName LIKE '%" + txtSearch2.Text + "%' OR " +
                       "CusPhone LIKE '%" + txtSearch2.Text + "%' OR " +
                       "CusEmail LIKE '%" + txtSearch2.Text + "%'";
            }

            MainClass.LoadData(qry, dataGridView1);//, lb);
        }

        //agregar programable la columnas de dgvEdit y dgvDel
        private void AgregarDgv()
        {

            DataGridViewImageColumn dgvEdit = new DataGridViewImageColumn();
            dgvEdit.Name = "dgvEdit";
            dgvEdit.HeaderText = "";
            dgvEdit.Width = 30;
            dgvEdit.Image = Properties.Resources.editar;
            dgvEdit.ImageLayout = DataGridViewImageCellLayout.Stretch;

            DataGridViewImageColumn dgvDel = new DataGridViewImageColumn();
            dgvDel.Name = "dgvDel";
            dgvDel.HeaderText = "";
            dgvDel.Width = 30;
            dgvDel.Image = Properties.Resources.cerrar;
            dgvDel.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.Columns.Add(dgvEdit);
            dataGridView1.Columns.Add(dgvDel);
        }
        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmCustomerView());
            LoadData();
        }

        //private void pictureBox1_Click_1(object sender, EventArgs e)
        //{
        //}

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click_2(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmCustomerAdd()); //aqui se abre el nuevo formulario
            LoadData();
        }

        private void txtSearch2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si se presiona la tecla Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Realizar la búsqueda
                LoadData();
                e.Handled = true; // Manejar el evento para evitar que se emita el sonido de error de Windows
            }
        }
    }       
}
