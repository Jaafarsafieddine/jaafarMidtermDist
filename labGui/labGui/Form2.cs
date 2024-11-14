using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labGui
{
    public partial class Form2 : Form
    {
        private int id;
        public Form2(int id)
        {
            InitializeComponent();
            this.id = id;
            string query = "SELECT * FROM book WHERE book_id = @Id";
            using (SqlCommand command = new SqlCommand(query, Connection.connect()))
            {
                command.Parameters.AddWithValue("@Id", id);

                try
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {

                        textBox1.Text = reader["title"].ToString();
                        textBox2.Text = reader["author"].ToString();
                        textBox3.Text = reader["number_pages"].ToString();
                        textBox4.Text = reader["category_id"].ToString();
                    }
                    else
                    {

                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {

                    label5.Text = "Error: " + ex.Message;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            string author = textBox2.Text;
            int numberPages = int.Parse(textBox3.Text);
            int categoryId = int.Parse(textBox4.Text);

            
            string query = "UPDATE book SET title = @Title, author = @Author, number_pages = @NumberPages, category_id = @CategoryId WHERE book_id = @Id";
            using (SqlCommand command = new SqlCommand(query, Connection.connect()))
            {
                
                command.Parameters.AddWithValue("@Id", id);

                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Author", author);
                command.Parameters.AddWithValue("@NumberPages", numberPages);
                command.Parameters.AddWithValue("@CategoryId", categoryId);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Book details updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update book details.");
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception
                    Console.WriteLine("Error: " + ex.Message);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
