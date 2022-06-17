using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ServizioConsegne
{
    public partial class Administrator : Form
    {
        private int indexRow;
        private string connString = @"Data Source = PCCHIARA\SQLEXPRESS;Initial Catalog = Pizzeria; User ID = sa; Password=cs";
        public Administrator()
        {
            InitializeComponent();
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                var sqlAdapter = new SqlDataAdapter("SELECT * FROM Menu", conn);
                var dataTable = new DataTable();
                sqlAdapter.Fill(dataTable);

                var prodotti = new List<Prodotto>();
                foreach (DataRow row in dataTable.Rows)
                {
                    var Prodotto = new Prodotto
                    {
                        Name = (string)row["NomeProdotto"],
                        Prezzo = Convert.ToDecimal(row["Prezzo"])
                    };
                    prodotti.Add(Prodotto);
                }
                prodottoBindingSource1.DataSource = prodotti;
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridView1.Rows[indexRow];

            newDataRow.Cells[0].Value = textBox1.Text;
            newDataRow.Cells[1].Value = textBox2.Text;

            using (SqlConnection connection = new SqlConnection(connString)
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Menu"))
                {
                    
                }
            }
        }
    }
}
