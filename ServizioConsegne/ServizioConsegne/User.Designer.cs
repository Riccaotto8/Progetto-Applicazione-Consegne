namespace ServizioConsegne
{
    partial class User
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
            this.navbarUser = new System.Windows.Forms.Panel();
            this.panelLog = new System.Windows.Forms.Panel();
            this.Login = new System.Windows.Forms.Button();
            this.assistenza = new System.Windows.Forms.Button();
            this.carrello = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeProdottoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezzoProdottoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodottoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.navbarUser.SuspendLayout();
            this.panelLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodottoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // navbarUser
            // 
            this.navbarUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.navbarUser.Controls.Add(this.panelLog);
            this.navbarUser.Controls.Add(this.assistenza);
            this.navbarUser.Controls.Add(this.carrello);
            this.navbarUser.Controls.Add(this.menu);
            this.navbarUser.Controls.Add(this.home);
            this.navbarUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.navbarUser.Location = new System.Drawing.Point(0, 0);
            this.navbarUser.Name = "navbarUser";
            this.navbarUser.Size = new System.Drawing.Size(163, 568);
            this.navbarUser.TabIndex = 0;
            this.navbarUser.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // panelLog
            // 
            this.panelLog.Controls.Add(this.Login);
            this.panelLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLog.Location = new System.Drawing.Point(0, 0);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(163, 100);
            this.panelLog.TabIndex = 4;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(42, 12);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Log_Click);
            // 
            // assistenza
            // 
            this.assistenza.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.assistenza.FlatAppearance.BorderSize = 0;
            this.assistenza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assistenza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assistenza.ForeColor = System.Drawing.Color.White;
            this.assistenza.Location = new System.Drawing.Point(0, 390);
            this.assistenza.Name = "assistenza";
            this.assistenza.Size = new System.Drawing.Size(163, 48);
            this.assistenza.TabIndex = 3;
            this.assistenza.Text = "Assistenza";
            this.assistenza.UseVisualStyleBackColor = true;
            this.assistenza.Click += new System.EventHandler(this.Assistance_Click);
            // 
            // carrello
            // 
            this.carrello.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.carrello.FlatAppearance.BorderSize = 0;
            this.carrello.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carrello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carrello.ForeColor = System.Drawing.Color.White;
            this.carrello.Location = new System.Drawing.Point(0, 299);
            this.carrello.Name = "carrello";
            this.carrello.Size = new System.Drawing.Size(163, 48);
            this.carrello.TabIndex = 2;
            this.carrello.Text = "Carrello";
            this.carrello.UseVisualStyleBackColor = true;
            this.carrello.Click += new System.EventHandler(this.Cart_Click);
            // 
            // menu
            // 
            this.menu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.menu.FlatAppearance.BorderSize = 0;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ForeColor = System.Drawing.Color.White;
            this.menu.Location = new System.Drawing.Point(0, 197);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(163, 48);
            this.menu.TabIndex = 1;
            this.menu.Text = "Menu";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // home
            // 
            this.home.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.home.FlatAppearance.BorderSize = 0;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.Location = new System.Drawing.Point(0, 109);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(163, 48);
            this.home.TabIndex = 0;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.Home_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeProdottoDataGridViewTextBoxColumn,
            this.prezzoProdottoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prodottoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(163, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(843, 568);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // nomeProdottoDataGridViewTextBoxColumn
            // 
            this.nomeProdottoDataGridViewTextBoxColumn.DataPropertyName = "NomeProdotto";
            this.nomeProdottoDataGridViewTextBoxColumn.HeaderText = "NomeProdotto";
            this.nomeProdottoDataGridViewTextBoxColumn.Name = "nomeProdottoDataGridViewTextBoxColumn";
            this.nomeProdottoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezzoProdottoDataGridViewTextBoxColumn
            // 
            this.prezzoProdottoDataGridViewTextBoxColumn.DataPropertyName = "PrezzoProdotto";
            this.prezzoProdottoDataGridViewTextBoxColumn.HeaderText = "PrezzoProdotto";
            this.prezzoProdottoDataGridViewTextBoxColumn.Name = "prezzoProdottoDataGridViewTextBoxColumn";
            this.prezzoProdottoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodottoBindingSource
            // 
            this.prodottoBindingSource.DataSource = typeof(ServizioConsegne.Prodotto);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 568);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.navbarUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.Text = "Form2";
            this.navbarUser.ResumeLayout(false);
            this.panelLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodottoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navbarUser;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button assistenza;
        private System.Windows.Forms.Button carrello;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdottoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezzoProdottoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource prodottoBindingSource;
        private System.Windows.Forms.Panel panelLog;
        private System.Windows.Forms.Button Login;
    }
}