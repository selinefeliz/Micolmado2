namespace MiColmado.View
{
    partial class frmUserView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.miColmadoSQLDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.miColmadoSQLDataSet = new MiColmado.MiColmadoSQLDataSet();
            this.miColmadoSQLDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miColmadoSQLDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new MiColmado.MiColmadoSQLDataSetTableAdapters.usersTableAdapter();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miColmadoSQLDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miColmadoSQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miColmadoSQLDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miColmadoSQLDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(539, 86);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Size = new System.Drawing.Size(227, 31);
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(536, 68);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(668, 51);
            this.pictureBox1.Size = new System.Drawing.Size(29, 31);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Size = new System.Drawing.Size(124, 45);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // miColmadoSQLDataSetBindingSource2
            // 
            this.miColmadoSQLDataSetBindingSource2.DataSource = this.miColmadoSQLDataSet;
            this.miColmadoSQLDataSetBindingSource2.Position = 0;
            // 
            // miColmadoSQLDataSet
            // 
            this.miColmadoSQLDataSet.DataSetName = "MiColmadoSQLDataSet";
            this.miColmadoSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // miColmadoSQLDataSetBindingSource1
            // 
            this.miColmadoSQLDataSetBindingSource1.DataSource = this.miColmadoSQLDataSet;
            this.miColmadoSQLDataSetBindingSource1.Position = 0;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.miColmadoSQLDataSet;
            // 
            // miColmadoSQLDataSetBindingSource
            // 
            this.miColmadoSQLDataSetBindingSource.DataSource = this.miColmadoSQLDataSet;
            this.miColmadoSQLDataSetBindingSource.Position = 0;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "users";
            this.usersBindingSource1.DataSource = this.miColmadoSQLDataSetBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(12, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(754, 305);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // frmUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUserView";
            this.Text = "frmUserView";
            this.Load += new System.EventHandler(this.frmUserView_Load);
            this.Click += new System.EventHandler(this.frmUserView_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miColmadoSQLDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miColmadoSQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miColmadoSQLDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miColmadoSQLDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MiColmadoSQLDataSet miColmadoSQLDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private MiColmadoSQLDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource miColmadoSQLDataSetBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.BindingSource miColmadoSQLDataSetBindingSource1;
        private System.Windows.Forms.BindingSource miColmadoSQLDataSetBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}