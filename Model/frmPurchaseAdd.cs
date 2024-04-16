using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiColmado.Model
{
    public partial class frmPurchaseAdd : SampleAdd
    {
        public frmPurchaseAdd()
        {
            InitializeComponent();
        }

        public int id = 0;
        public int supID = 0;

        private void frmPurchaseAdd_Load(object sender, EventArgs e)
        {
            string qty = "Select proID 'id', pName 'name' from products";
            string qty2 = "Select supID 'id', supName 'name' from Supplier";

            MainClass.CBFill(qty, cbProducto);
            MainClass.CBFill(qty2, cbProducto);

            if(supID > 0)
            {
                cbSuplidor.SelectedValue = supID;
            }
            LoadData();
        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProducto.SelectedIndex != -1)
            {
                txtCantidad.Text = "";
                GetDetails();
            }
        }

        private void GetDetails()
        {
            string qry = "Select * from products where proID = " + Convert.ToInt32(cbProducto.SelectedIndex) + "";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0 )
            {
                txtCosto.Text = dt.Rows[0]["proCost"].ToString ();
            }
        }

        private void Calculate()
        {
            double qty = 0;
            double cost = 0;
            double monto = 0;

            double.TryParse(txtCantidad.Text, out qty);
            double.TryParse (txtCosto.Text, out cost);

            monto = qty * cost;
            txtMonto.Text = monto.ToString ();  
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string qry = @"Select * from products where proCode = '" + txtCodigo.Text + "'";
                SqlCommand cmd = new SqlCommand(qry, MainClass.con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    cbProducto.SelectedValue = Convert.ToInt32(dt.Rows[0]["proID"].ToString());
                    Calculate();
                    txtCodigo.Text = "";
                }
            }
        }
        private void LoadData()
        {
            //ListBox lb = new ListBox();
            //lb.Items.Add(dgvid);
            //lb.Items.Add(dgvuserName);
            //lb.Items.Add(dgvpass);
            //lb.Items.Add(dgvname);
            //lb.Items.Add(dgvphone);

            string qry = @"Select proID, proName as Nombre, proCode as Codigo, 
                            proCost as Costo, proPrice as Precio from products";
            //   where uName like '%" + txtSearch.Text + " %' order by userID desc";

           

            MainClass.LoadData(qry, dataGridView1);//, lb);
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }
          
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string pid;
            string pname;
            string qty;
            string cost;
            string amt;

            pname = cbProducto.Text;
            pid = cbProducto.SelectedValue.ToString();
            qty = txtCantidad.Text; // Corregido el nombre de la propiedad Text
            cost = txtCosto.Text; // Corregido el nombre de la propiedad Text
            amt = txtMonto.Text;

            // Añadir una nueva fila al DataGridView
            dataGridView1.Rows.Add(pid, pname, qty, cost, amt);

            // Limpiar los controles después de agregar la fila
            cbProducto.SelectedIndex = -1;
            txtCantidad.Text = "";
            txtCosto.Text = "";
            txtMonto.Text = "";
        }
        private void txtPrecio(object sender, EventArgs e)
        {

        }


        //private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    int count = 0;

        //    foreach (DataGridViewRow row in guna2DataGridView1.Rows) 
        //    {
        //        count++;
        //        row.Cells[0].Value = count;
        //    }
        //}

        public override void btnSave_Click(object sender, EventArgs e)
        {
            //Primero have to create table to store
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
