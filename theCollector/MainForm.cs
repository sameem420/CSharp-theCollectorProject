using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Net;

namespace theCollector
{
    public partial class MainForm : Form
    {
        SqlConnection con = ConnectionManager.GetConnection();
        SqlDataAdapter sqldba;
        DataSet ds;
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
            if(txt_movieTitle.Text == "" || txt_releaseYear.Text == "" || txt_movieType.SelectedItem == null)
            {
                MessageBox.Show("Please fill all the fields","the Collector", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
            var movieType = txt_movieType.SelectedItem.ToString();
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
            cmd.Parameters.AddWithValue("@title", txt_movieTitle.Text);
            cmd.Parameters.AddWithValue("@watched", watched);
            cmd.Parameters.AddWithValue("@year", txt_releaseYear.Text);
            cmd.Parameters.AddWithValue("@movietype", movieType);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Record Saved!","the Collector : Movies",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM recTable";
            sqldba = new SqlDataAdapter(query, con);
            ds = new DataSet();
            sqldba.Fill(ds, "recTable");
            con.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "recTable";

            dataGridView1.Columns["Id"].HeaderText = "ID";
            dataGridView1.Columns["title"].HeaderText = "Movie/Series Title";
            dataGridView1.Columns["year"].HeaderText = "Released Year";
            dataGridView1.Columns["watched"].HeaderText = "Watched";
            dataGridView1.Columns["movietype"].HeaderText = "Category";

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value is double && 0 == (double)cell.Value) { e.CellStyle.ForeColor = Color.Red; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var request = WebRequest.Create(txt_URL.Text);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox1.Image = Bitmap.FromStream(stream);
            }
        }
    }
}
