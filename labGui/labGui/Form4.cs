using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace labGui
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            
            string query = "SELECT b.book_id, b.title, b.author, b.number_pages, c.cat_type " +
                           "FROM book b " +
                           "INNER JOIN category c ON b.category_id = c.id";

            
            SqlCommand command = new SqlCommand(query, Connection.connect());
            try
            {

                
                DataTable dataTable = new DataTable();

                
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }

                
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Error: " + ex.Message);
            }


        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }

}