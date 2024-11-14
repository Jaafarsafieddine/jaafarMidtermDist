namespace labGui
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dataGridView1 = new DataGridView();
            book_id = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Number_pages = new DataGridViewTextBoxColumn();
            Category_id = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(395, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 35);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 111);
            label1.Name = "label1";
            label1.Size = new Size(346, 30);
            label1.TabIndex = 1;
            label1.Text = "Put the book you want to search for";
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Location = new Point(610, 111);
            button1.Name = "button1";
            button1.Size = new Size(131, 40);
            button1.TabIndex = 2;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(28, 28);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { book_id, Title, Author, Number_pages, Category_id });
            dataGridView1.Location = new Point(61, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(950, 105);
            dataGridView1.TabIndex = 3;
            // 
            // book_id
            // 
            book_id.HeaderText = "book_id";
            book_id.MinimumWidth = 9;
            book_id.Name = "book_id";
            book_id.Width = 175;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.MinimumWidth = 9;
            Title.Name = "Title";
            Title.Width = 175;
            // 
            // Author
            // 
            Author.HeaderText = "Author";
            Author.MinimumWidth = 9;
            Author.Name = "Author";
            Author.Width = 175;
            // 
            // Number_pages
            // 
            Number_pages.HeaderText = "Number_pages";
            Number_pages.MinimumWidth = 9;
            Number_pages.Name = "Number_pages";
            Number_pages.Width = 175;
            // 
            // Category_id
            // 
            Category_id.HeaderText = "Category_id";
            Category_id.MinimumWidth = 9;
            Category_id.Name = "Category_id";
            Category_id.Width = 175;
            // 
            // button2
            // 
            button2.Location = new Point(61, 401);
            button2.Name = "button2";
            button2.Size = new Size(131, 40);
            button2.TabIndex = 4;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(256, 401);
            button3.Name = "button3";
            button3.Size = new Size(131, 40);
            button3.TabIndex = 5;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(439, 401);
            button4.Name = "button4";
            button4.Size = new Size(131, 40);
            button4.TabIndex = 6;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 33);
            label2.Name = "label2";
            label2.Size = new Size(0, 30);
            label2.TabIndex = 7;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaptionText;
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(634, 401);
            button5.Name = "button5";
            button5.Size = new Size(132, 40);
            button5.TabIndex = 8;
            button5.Text = "Show All";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2148, 1009);
            Controls.Add(button5);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            ForeColor = SystemColors.Highlight;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn book_id;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Number_pages;
        private DataGridViewTextBoxColumn Category_id;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private Button button5;
    }
}
