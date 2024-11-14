namespace labGui
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Location = new Point(358, 293);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(175, 35);
            textBox4.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(358, 220);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(175, 35);
            textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(358, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 35);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(358, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 35);
            textBox1.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 293);
            label4.Name = "label4";
            label4.Size = new Size(126, 30);
            label4.TabIndex = 11;
            label4.Text = "Category_ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 223);
            label3.Name = "label3";
            label3.Size = new Size(174, 30);
            label3.TabIndex = 10;
            label3.Text = "Number of Pages";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 154);
            label2.Name = "label2";
            label2.Size = new Size(77, 30);
            label2.TabIndex = 9;
            label2.Text = "Author";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 89);
            label1.Name = "label1";
            label1.Size = new Size(52, 30);
            label1.TabIndex = 8;
            label1.Text = "Title";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Location = new Point(402, 412);
            button1.Name = "button1";
            button1.Size = new Size(131, 40);
            button1.TabIndex = 16;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(43, 394);
            button2.Name = "button2";
            button2.Size = new Size(241, 77);
            button2.TabIndex = 17;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1661, 928);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}