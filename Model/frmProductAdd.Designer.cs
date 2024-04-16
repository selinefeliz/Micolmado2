namespace MiColmado.Model
{
    partial class frmProductAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductAdd));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNombre1 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.CBCategoria1 = new System.Windows.Forms.Label();
            this.txtCosto1 = new System.Windows.Forms.Label();
            this.txtCodigo1 = new System.Windows.Forms.Label();
            this.txtPrecio1 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtPic = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.Text = "Detalles del producto";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(43, 195);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(182, 25);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.Tag = "v";
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtNombre1
            // 
            this.txtNombre1.AutoSize = true;
            this.txtNombre1.Location = new System.Drawing.Point(42, 164);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(57, 17);
            this.txtNombre1.TabIndex = 10;
            this.txtNombre1.Text = "Nombre";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(278, 195);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(182, 25);
            this.cbCategoria.TabIndex = 13;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(43, 275);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(182, 25);
            this.txtCodigo.TabIndex = 14;
            this.txtCodigo.Tag = "v";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(278, 275);
            this.txtCosto.Multiline = true;
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(91, 25);
            this.txtCosto.TabIndex = 15;
            this.txtCosto.Tag = "v";
            // 
            // CBCategoria1
            // 
            this.CBCategoria1.AutoSize = true;
            this.CBCategoria1.Location = new System.Drawing.Point(275, 164);
            this.CBCategoria1.Name = "CBCategoria1";
            this.CBCategoria1.Size = new System.Drawing.Size(65, 17);
            this.CBCategoria1.TabIndex = 16;
            this.CBCategoria1.Text = "Categoria";
            this.CBCategoria1.Click += new System.EventHandler(this.cbCategoria_Click);
            // 
            // txtCosto1
            // 
            this.txtCosto1.AutoSize = true;
            this.txtCosto1.Location = new System.Drawing.Point(275, 246);
            this.txtCosto1.Name = "txtCosto1";
            this.txtCosto1.Size = new System.Drawing.Size(42, 17);
            this.txtCosto1.TabIndex = 17;
            this.txtCosto1.Text = "Costo";
            this.txtCosto1.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCodigo1
            // 
            this.txtCodigo1.AutoSize = true;
            this.txtCodigo1.Location = new System.Drawing.Point(42, 246);
            this.txtCodigo1.Name = "txtCodigo1";
            this.txtCodigo1.Size = new System.Drawing.Size(51, 17);
            this.txtCodigo1.TabIndex = 18;
            this.txtCodigo1.Text = "Codigo";
            // 
            // txtPrecio1
            // 
            this.txtPrecio1.AutoSize = true;
            this.txtPrecio1.Location = new System.Drawing.Point(389, 246);
            this.txtPrecio1.Name = "txtPrecio1";
            this.txtPrecio1.Size = new System.Drawing.Size(44, 17);
            this.txtPrecio1.TabIndex = 19;
            this.txtPrecio1.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(392, 275);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(91, 25);
            this.txtPrecio.TabIndex = 20;
            this.txtPrecio.Tag = "v";
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // txtPic
            // 
            this.txtPic.Image = ((System.Drawing.Image)(resources.GetObject("txtPic.Image")));
            this.txtPic.Location = new System.Drawing.Point(563, 140);
            this.txtPic.Name = "txtPic";
            this.txtPic.Size = new System.Drawing.Size(156, 148);
            this.txtPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtPic.TabIndex = 21;
            this.txtPic.TabStop = false;
            this.txtPic.Click += new System.EventHandler(this.txtPic_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(594, 305);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(102, 33);
            this.btnBrowse.TabIndex = 22;
            this.btnBrowse.Text = "Agregar";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // frmProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 427);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPic);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtPrecio1);
            this.Controls.Add(this.txtCodigo1);
            this.Controls.Add(this.txtCosto1);
            this.Controls.Add(this.CBCategoria1);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNombre1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProductAdd";
            this.Text = "frmProductAdd";
            this.Load += new System.EventHandler(this.frmProductAdd_Load);
            this.Controls.SetChildIndex(this.txtNombre1, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.cbCategoria, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.txtCosto, 0);
            this.Controls.SetChildIndex(this.CBCategoria1, 0);
            this.Controls.SetChildIndex(this.txtCosto1, 0);
            this.Controls.SetChildIndex(this.txtCodigo1, 0);
            this.Controls.SetChildIndex(this.txtPrecio1, 0);
            this.Controls.SetChildIndex(this.txtPrecio, 0);
            this.Controls.SetChildIndex(this.txtPic, 0);
            this.Controls.SetChildIndex(this.btnBrowse, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txtPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label txtNombre1;
        private System.Windows.Forms.ComboBox cbCategoria;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label CBCategoria1;
        private System.Windows.Forms.Label txtCosto1;
        private System.Windows.Forms.Label txtCodigo1;
        private System.Windows.Forms.Label txtPrecio1;
        public System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.PictureBox txtPic;
        private System.Windows.Forms.Button btnBrowse;
    }
}