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
    public partial class Form1 : Form
    {
        private string connString = @"Data Source=PCCHIARA\SQLEXPRESS;Initial Catalog= Pizzeria;User ID=sa;Password=cs";
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);

            if ((textBox1.Text == "Admin") && (textBox2.Text == "1234"))
            {
                using (var connection = new SqlConnection(connString))
                {
                    var crono = new SqlCommand("INSERT INTO RegistroLog (TipoUtente, Orario) VALUES (@user, @time)", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    crono.Parameters.AddWithValue("user", "administrator");
                    crono.Parameters.AddWithValue("time", timeStamp);


                    connection.Open();

                    try
                    {
                        crono.ExecuteNonQuery();
                    }
                    catch (SqlException) { }

                    connection.Close();
                }

                var admin = new Administrator();
                admin.Show();
            }
            else
            {
                using (var connection = new SqlConnection(connString))
                {
                    var crono = new SqlCommand("INSERT INTO RegistroLog (TipoUtente, Orario) VALUES (@user, @time)", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    crono.Parameters.AddWithValue("user", "user");
                    crono.Parameters.AddWithValue("time", timeStamp);


                    connection.Open();

                    try
                    {
                        crono.ExecuteNonQuery();
                    }
                    catch (SqlException) { }

                    connection.Close();
                }

                var user = new User();
                user.Show();
            }
        }

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }
    }
}
