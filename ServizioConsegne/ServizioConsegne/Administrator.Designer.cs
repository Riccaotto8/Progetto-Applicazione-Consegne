namespace ServizioConsegne
{
    partial class Administrator
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
            this.navbarAdmin = new System.Windows.Forms.Panel();
            this.viewAdmin = new System.Windows.Forms.Button();
            this.deleteAdmin = new System.Windows.Forms.Button();
            this.addElement = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prodottoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prodottoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeProdottoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezzoProdottoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navbarAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodottoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodottoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // navbarAdmin
            // 
            this.navbarAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.navbarAdmin.Controls.Add(this.viewAdmin);
            this.navbarAdmin.Controls.Add(this.deleteAdmin);
            this.navbarAdmin.Controls.Add(this.addElement);
            this.navbarAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbarAdmin.Location = new System.Drawing.Point(0, 0);
            this.navbarAdmin.Name = "navbarAdmin";
            this.navbarAdmin.Size = new System.Drawing.Size(800, 37);
            this.navbarAdmin.TabIndex = 0;
            // 
            // viewAdmin
            // 
            this.viewAdmin.Location = new System.Drawing.Point(265, 4);
            this.viewAdmin.Name = "viewAdmin";
            this.viewAdmin.Size = new System.Drawing.Size(120, 30);
            this.viewAdmin.TabIndex = 2;
            this.viewAdmin.Text = "View Data";
            this.viewAdmin.UseVisualStyleBackColor = true;
            this.viewAdmin.Click += new System.EventHandler(this.Viewdata_Click);
            // 
            // deleteAdmin
            // 
            this.deleteAdmin.Location = new System.Drawing.Point(139, 4);
            this.deleteAdmin.Name = "deleteAdmin";
            this.deleteAdmin.Size = new System.Drawing.Size(120, 30);
            this.deleteAdmin.TabIndex = 1;
            this.deleteAdmin.Text = "Delete";
            this.deleteAdmin.UseVisualStyleBackColor = true;
            this.deleteAdmin.Click += new System.EventHandler(this.Delete_Click);
            // 
            // addElement
            // 
            this.addElement.Location = new System.Drawing.Point(13, 4);
            this.addElement.Name = "addElement";
            this.addElement.Size = new System.Drawing.Size(120, 30);
            this.addElement.TabIndex = 0;
            this.addElement.Text = "Add";
            this.addElement.UseVisualStyleBackColor = true;
            this.addElement.Click += new System.EventHandler(this.Add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeProdottoDataGridViewTextBoxColumn,
            this.prezzoProdottoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prodottoBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 413);
            this.dataGridView1.TabIndex = 1;
            // 
            // prodottoBindingSource1
            // 
            this.prodottoBindingSource1.DataSource = typeof(ServizioConsegne.Prodotto);
            // 
            // prodottoBindingSource
            // 
            this.prodottoBindingSource.DataSource = typeof(ServizioConsegne.Prodotto);
            // 
            // nomeProdottoDataGridViewTextBoxColumn
            // 
            this.nomeProdottoDataGridViewTextBoxColumn.DataPropertyName = "NomeProdotto";
            this.nomeProdottoDataGridViewTextBoxColumn.HeaderText = "NomeProdotto";
            this.nomeProdottoDataGridViewTextBoxColumn.Name = "nomeProdottoDataGridViewTextBoxColumn";
            // 
            // prezzoProdottoDataGridViewTextBoxColumn
            // 
            this.prezzoProdottoDataGridViewTextBoxColumn.DataPropertyName = "PrezzoProdotto";
            this.prezzoProdottoDataGridViewTextBoxColumn.HeaderText = "PrezzoProdotto";
            this.prezzoProdottoDataGridViewTextBoxColumn.Name = "prezzoProdottoDataGridViewTextBoxColumn";
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.navbarAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrator";
            this.Text = "Form2";
            this.navbarAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodottoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodottoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navbarAdmin;
        private System.Windows.Forms.Button viewAdmin;
        private System.Windows.Forms.Button deleteAdmin;
        private System.Windows.Forms.Button addElement;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource prodottoBindingSource1;
        private System.Windows.Forms.BindingSource prodottoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdottoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezzoProdottoDataGridViewTextBoxColumn;
    }
}