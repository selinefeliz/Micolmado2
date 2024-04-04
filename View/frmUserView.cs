using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiColmado.View
{
    public partial class frmUserView : SampleView
    {
        public frmUserView()
        {
            InitializeComponent();
        }

        private void frmUserView_Load(object sender, EventArgs e)
        {

        }
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmUserAdd()); //aqui se habre el nuevo formulario
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        
        //para que carge los datos del data grid view
        private void LoadData()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvname);
            lb.Items.Add(dgvuserName);
            lb.Items.Add(dgvpass);
            lb.Items.Add(dgvphone);

            string qry = @"Select userID, uName, userName, upass, uPhone from users
                            where uName like '%" + txtSearch.Text + "%' order by userID desc";
            MainClass.LoadData(qry, dataGridView1, lb);
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

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
                    }
    }
}
