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
    public partial class frmPurchaseView : SampleView
    {
        public frmPurchaseView()
        {
            InitializeComponent();
        }

        private void frmPurchaseView_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmPurchaseAdd()); //aqui se abre el nuevo formulario
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
            //lb.Items.Add(dgvid);
            //lb.Items.Add(dgvuserName);
            //lb.Items.Add(dgvpass);
            //lb.Items.Add(dgvname);
            //lb.Items.Add(dgvphone);

            string qry = @"Select proID as ID, proName as Nombre, proCode as Codigo, 
                            proCost as Costo, proPrice as Precio from products";
            //   where uName like '%" + txtSearch.Text + " %' order by userID desc";


            // Agregar una cláusula WHERE para filtrar los resultados según el texto ingresado en txtSearch
            //if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            //{
            //    // Agregar una condición OR para buscar en múltiples campos
            //    qry += " WHERE propID LIKE '%" + txtSearch.Text + "%' OR " +
            //           "userName LIKE '%" + txtSearch.Text + "%' OR " +
            //           "upass LIKE '%" + txtSearch.Text + "%' OR " +
            //           "uPhone LIKE '%" + txtSearch.Text + "%'";
            //}

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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

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
            MainClass.BlurBackground(new frmPurchaseAdd());
            LoadData();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
        }

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

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si se presiona la tecla Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Realizar la búsqueda
                LoadData();
                e.Handled = true; // Manejar el evento para evitar que se emita el sonido de error de Windows
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {


            /* if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
             { 
                 frmUserAdd frm = new frmUserAdd();
            frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
            frm.txtName.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvname"].Value);
            frm.txtUser.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvuserName"].Value);
            frm.txtPass.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvpass"].Value);
            frm.txtPhone.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgphone"].Value);

             MainClass.BlurBackground(frm);
                 LoadData();
             }
             //Delete
             if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvDe1")
             {
                int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value)

                 string qry = "Delet from users where userID = " + id + "";
                 Hashtable ht = new Hashtable();

                 if (MainClass.SQL(qry, ht) > 0)
                 {
                     guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogoButtons.OK;
                     guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                     guna2MessageDialog1.Ic Show("Deleted Successfully..");
            LoadData();

                 }

             }*/

            {
                //Update
                if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
                {
                    frmPurchaseAdd frm = new frmPurchaseAdd();
                    frm.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                    frm.txtCodigo.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Codigo"].Value);
                    frm.txtCosto.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Costo"].Value);

                    MainClass.BlurBackground(frm);
                    LoadData();
                }

                // Delete

                ////Confirmar antes de borrar
                if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvDel")
                {

                    DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar esto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);

                        string qry = "DELETE FROM products WHERE propID = " + id;
                        Hashtable ht = new Hashtable();

                        if (MainClass.SQL(qry, ht) > 0)
                        {
                            MessageBox.Show("Deleted Successfully..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }

                    }


                }
            }
        }

        private void btnAdd_Click_2(object sender, EventArgs e)
        {

        }
    }
}
