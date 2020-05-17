using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace theCollector
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check_connection = ConnectionManager.isServerConnected();
            if (check_connection)
            {
                MessageBox.Show("Connected to the Server!", "Server Connection Checker", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Not Connected to the Server!", "Server Connection Checker", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SqlConnection con = ConnectionManager.GetConnection();
            var movieType = comboBox1.SelectedItem.ToString();
            var watched = "";
            if(radiobtn_true.Checked)
            {
                watched = "Yes";
            }
            if(radiobtn_false.Checked)
            {
                watched = "No";
            }
            String query = "INSERT INTO recTable (title,year,watched,movietype) VALUES (@title, @year, @watched, @movietype)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@title", txt_title.Text);
            cmd.Parameters.AddWithValue("@watched", watched);
            cmd.Parameters.AddWithValue("@year", txt_releaseYear.Text);
            cmd.Parameters.AddWithValue("@movietype", movieType);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Record Saved!","the Collector",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
