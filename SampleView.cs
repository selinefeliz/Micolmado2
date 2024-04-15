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
    public partial class SampleView : Sample
    {
        public SampleView()
        {
            InitializeComponent();

            //para eliminar categorias 
            /*// Preguntar al usuario si está seguro de eliminar
            DialogResult result = MessageBox.Show(frmMain.Instance, "¿Estás seguro de que quieres eliminar esto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {

            }*/
        }

        private void SampleView_Load(object sender, EventArgs e)
        {

        }

        public virtual void textBox1_Enter(object sender, EventArgs e)
        {
            //BORRAR ESTA PARTE ya que no se
            ////para poner un marca de agua
            //if (txtSearch.Text == "")
            //{
            //    txtSearch.Text = "Buscar";
            //    txtSearch.ForeColor = Color.Silver;
            //}

        }

        public virtual void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnAdd_Click(object sender, EventArgs e)
        {

        }

        public virtual void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
