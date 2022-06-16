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
        public Administrator()
        {
            InitializeComponent();
            using (var conn = new SqlConnection(@"Data Source=PCCHIARA\SQLEXPRESS;Initial Catalog= Pizzeria;User ID=sa;Password=cs"))
            {
                conn.Open();
                var sqlAdapter = new SqlDataAdapter("SELECT * FROM Menu", conn);
                var dataTable = new DataTable();
                sqlAdapter.Fill(dataTable);

                var prodotti = new List<Prodotto>();
                foreach (DataRow row in dataTable.Rows)
                {
                    var Prodotto = new Prodotto();
                    Prodotto.Name = (string)row["NomeProdotto"];
                    Prodotto.Prezzo = Convert.ToDecimal(row["Prezzo"]);
                    prodotti.Add(Prodotto);
                }
                prodottoBindingSource.DataSource = prodotti;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void Viewdata_Click(object sender, EventArgs e)
        {

        }
    }
}
