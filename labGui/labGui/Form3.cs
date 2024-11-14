using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labGui
{
    public partial class Form3 : Form
    {
        static int counter = 6;
        public Form3()
        {
            InitializeComponent();
        }
        
        private bool CategoryExists(int categoryId)
        {
            string query = "SELECT COUNT(*) FROM category WHERE id = @CategoryId";
            using (SqlCommand command = new SqlCommand(query, Connection.connect()))
            {
                command.Parameters.AddWithValue("@CategoryId", categoryId);

                try
                {
                    int categoryCount = (int)command.ExecuteScalar();
                    return categoryCount > 0;
                }
                catch (Exception ex)
                {
                    // Handle exception
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            string author = textBox2.Text;
            int numberPages = int.Parse(textBox3.Text);
            int categoryId = int.Parse(textBox4.Text);

            if (CategoryExists(categoryId))
            {
                // Category exists, proceed with inserting the book
                string query = "INSERT INTO book (book_id, title, author, number_pages, category_id) VALUES (@id, @Title, @Author, @NumberPages, @CategoryId)";
                using (SqlCommand command = new SqlCommand(query, Connection.connect()))
                {
                    command.Parameters.AddWithValue("@id", counter++);
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Author", author);
                    command.Parameters.AddWithValue("@NumberPages", numberPages);
                    command.Parameters.AddWithValue("@CategoryId", categoryId);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("New book added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add new book.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle exception
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                // Category does not exist, display error message
                MessageBox.Show("Category does not exist.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
