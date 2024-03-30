namespace MiColmado
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.Panel = new System.Windows.Forms.Panel();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.lbusuario = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.DarkCyan;
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel.Controls.Add(this.btnEmpleados);
            this.Panel.Controls.Add(this.btnProveedores);
            this.Panel.Controls.Add(this.btnCompras);
            this.Panel.Controls.Add(this.btnProductos);
            this.Panel.Controls.Add(this.btnCategoria);
            this.Panel.Controls.Add(this.lbusuario);
            this.Panel.Controls.Add(this.btnHome);
            this.Panel.Controls.Add(this.pictureBox1);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(232, 571);
            this.Panel.TabIndex = 0;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.BackgroundImage")));
            this.btnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEmpleados.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEmpleados.Location = new System.Drawing.Point(10, 424);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(197, 42);
            this.btnEmpleados.TabIndex = 7;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProveedores.BackgroundImage")));
            this.btnProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProveedores.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProveedores.Location = new System.Drawing.Point(10, 376);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(197, 42);
            this.btnProveedores.TabIndex = 6;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            // 
            // btnCompras
            // 
            this.btnCompras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCompras.BackgroundImage")));
            this.btnCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCompras.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCompras.Location = new System.Drawing.Point(10, 328);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(197, 42);
            this.btnCompras.TabIndex = 5;
            this.btnCompras.Text = "Compras";
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProductos.BackgroundImage")));
            this.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProductos.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProductos.Location = new System.Drawing.Point(10, 280);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(197, 42);
            this.btnProductos.TabIndex = 4;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            // 
            // btnCategoria
            // 
            this.btnCategoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCategoria.BackgroundImage")));
            this.btnCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCategoria.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCategoria.Location = new System.Drawing.Point(10, 232);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(197, 42);
            this.btnCategoria.TabIndex = 3;
            this.btnCategoria.Text = "Categoria";
            this.btnCategoria.UseVisualStyleBackColor = true;
            // 
            // lbusuario
            // 
            this.lbusuario.AutoSize = true;
            this.lbusuario.BackColor = System.Drawing.Color.Transparent;
            this.lbusuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbusuario.Location = new System.Drawing.Point(48, 130);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(125, 17);
            this.lbusuario.TabIndex = 2;
            this.lbusuario.Text = "Nombre de Usuario";
            this.lbusuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.Location = new System.Drawing.Point(10, 186);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(197, 40);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(51, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 95);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.centerPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(232, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 571);
            this.panel2.TabIndex = 1;
            // 
            // centerPanel
            // 
            this.centerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.centerPanel.Location = new System.Drawing.Point(7, 12);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(730, 547);
            this.centerPanel.TabIndex = 0;
            this.centerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 571);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lbusuario;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnProveedores;
    }
}