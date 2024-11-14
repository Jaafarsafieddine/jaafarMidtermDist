using System.Data.SqlClient;

namespace labGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string command = "select * from book where title = '" + textBox1.Text + "'";
            SqlCommand sqlCmd = new SqlCommand(command, Connection.connect());
            SqlDataReader reader = sqlCmd.ExecuteReader();


            dataGridView1.Rows.Clear();

            while (reader.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);

                row.Cells[0].Value = reader["book_id"].ToString();
                row.Cells[1].Value = reader["title"].ToString();
                row.Cells[2].Value = reader["author"].ToString();
                row.Cells[3].Value = reader["number_pages"].ToString();
                row.Cells[4].Value = reader["category_id"].ToString();

                dataGridView1.Rows.Add(row);
            }

            reader.Close();
            dataGridView1.Show();
        }




        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                label2.Text = "No book ";
            }
            else if (dataGridView1.Rows[0].Cells["book_id"].Value == null)
            {
                label2.Text = "No book is found ";
            }
            else
            {
                int id = Convert.ToInt32(dataGridView1.Rows[0].Cells["book_id"].Value);
                Form2 form2 = new Form2(id);
                form2.Show();
                this.Hide();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                label2.Text = "No book ";
            }
            else if (dataGridView1.Rows[0].Cells["book_id"].Value == null)
            {
                label2.Text = "No book is found ";
            }
            else
            {
                int id = Convert.ToInt32(dataGridView1.Rows[0].Cells["book_id"].Value);
                string query = "DELETE FROM book WHERE book_id = " + id;


                SqlCommand command = new SqlCommand(query, Connection.connect());
                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    label2.Text = $"Rows affected: {rowsAffected}";
                }
                catch (Exception ex)
                {
                    label2.Text = $"Error: {ex.Message}";
                }

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }



}
