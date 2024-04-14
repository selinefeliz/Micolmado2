using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiColmado.View2
{
    public partial class frmCategoryView : SampleView
    {
        public frmCategoryView()
        {
            InitializeComponent();
        }

        private void frmCategoryView_Load(object sender, EventArgs e)
        {
            LoadData();
        }
      /*  public frmUserView()
        {
            InitializeComponent();
        }*/

        private void frmUserView_Load(object sender, EventArgs e)
        {
            LoadData();
            AgregarDgv(); //agrega los nuevos campos
            txtSearch.KeyPress += txtSearch_KeyPress; // Suscribir el evento KeyPress al método txtSearch_KeyPress
        }
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmUserAdd()); //aqui se abre el nuevo formulario
            LoadData();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        //para que carge los datos del data grid view
        private void LoadData()
        {
           // ListBox lb = new ListBox();
           // lb.Items.Add(dgvid);
           // lb.Items.Add(dgvuserName);
            //lb.Items.Add(dgvpass);
            //lb.Items.Add(dgvname);
            //lb.Items.Add(dgvphone);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Aquí accedemos a los valores de las celdas en cada fila
                ListBox lb = new ListBox();
                string id = row.Cells["ID"].Value.ToString();
                var name = row.Cells["Nombre"].Value.ToString();
              

                // Concatenamos los valores en una cadena y los agregamos al ListBox
                string item = $"ID: {id},  Nombre: {name}";
                lb.Items.Add(item);
            }
            string qry = @"Select * from Category
            where catName like '%" + txtSearch.Text + " %' order by catID desc";
            // Agregar una cláusula WHERE para filtrar los resultados según el texto ingresado en txtSearch
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                // Agregar una condición OR para buscar en múltiples campos
                qry += " WHERE uName LIKE '%" + txtSearch.Text + "%' OR " +
                       "userName LIKE '%" + txtSearch.Text + "%' OR " +
                       "upass LIKE '%" + txtSearch.Text + "%' OR " +
                       "uPhone LIKE '%" + txtSearch.Text + "%'";

                MessageBox.Show("Deleted Successfully..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();

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
            MainClass.BlurBackground(new frmUserAdd());
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
                    frmUserAdd frm = new frmUserAdd();
                    frm.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                    frm.txtName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Nombre"].Value);
                    frm.txtUserName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["NombreUsuario"].Value);
                    frm.txtPass.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Contraseña"].Value);
                    frm.txtPhone.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Telefono"].Value);

                    MainClass.BlurBackground(frm);
                    LoadData();
                }

                // Delete
                if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvDel")
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);

                    string qry = "Delete from where userID = " + id + "";
                    Hashtable ht = new Hashtable();

                    if (MainClass.SQL(qry, ht) > 0)
                    {
                        MessageBox.Show("Deleted Successfully..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }


                }
            }
        }
        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{

        //}
        private void panel1_Click(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica para manejar el evento Click del panel
        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
