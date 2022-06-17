﻿using System;
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

            var preName = newDataRow.Cells[0].Value;
            var prePrice = newDataRow.Cells[1].Value;

            /*using (var connection = new SqlConnection(connString))
            {
                var update = new SqlCommand("UPDATE Menu SET NomeProdotto = @nome, Prezzo = @prezzo WHERE IDRow = @ind", connection);
                update.Parameters.AddWithValue("nome", textBox1.Text);
                update.Parameters.AddWithValue("prezzo", Convert.ToDecimal(textBox2.Text));
                update.Parameters.AddWithValue("ind", indexKey);

                connection.Open();

                update.ExecuteNonQuery();

                connection.Close();
            }*/


            using (var connection = new SqlConnection(connString))
            {
                var update = new SqlCommand("UPDATE Menu SET NomeProdotto = @nome, Prezzo = @prezzo WHERE NomeProdotto = @preName AND Prezzo = @prePrice", connection);
                update.Parameters.AddWithValue("nome", textBox1.Text);
                update.Parameters.AddWithValue("prezzo", Convert.ToDecimal(textBox2.Text));
                update.Parameters.AddWithValue("preName", preName);
                update.Parameters.AddWithValue("prePrice", Convert.ToDecimal(prePrice));

                connection.Open();

                try
                {
                    update.ExecuteNonQuery();
                }
                catch (SqlException) { }

                connection.Close();
            }
            newDataRow.Cells[0].Value = textBox1.Text;
            newDataRow.Cells[1].Value = textBox2.Text;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddRow_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(connString))
            {

                var add = new SqlCommand("INSERT INTO Menu(NomeProdotto, Prezzo) VALUES (@nome, @prezzo)", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                add.Parameters.AddWithValue("nome", textBox1.Text);
                add.Parameters.AddWithValue("prezzo", Convert.ToDecimal(textBox2.Text));
                

                connection.Open();

                try
                {
                    add.ExecuteNonQuery();
                }
                catch (SqlException) {}

                connection.Close();
            }
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(connString))
            {

                var delete = new SqlCommand("DELETE FROM Menu WHERE NomeProdotto = @nome AND Prezzo = @prezzo", connection);
                delete.Parameters.AddWithValue("nome", textBox1.Text);
                delete.Parameters.AddWithValue("prezzo", Convert.ToDecimal(textBox2.Text));

                connection.Open();

                delete.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
