﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    public partial class EventForm : Form
    {
        string connString = "server=localhost;user id=root;database=db_calendar;sslmode=none";

        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            String sql = "INSERT INTO tbl_calendar(date, event)values(?,?)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", textBox1.Text);
            cmd.Parameters.AddWithValue("event", textBox2.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
            cmd.Dispose();
            conn.Close();
        }
    }
}
