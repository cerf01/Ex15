namespace WinFormsApp16
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
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            numericUpDown3 = new NumericUpDown();
            richTextBox1 = new RichTextBox();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            button4 = new Button();
            richTextBox2 = new RichTextBox();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            richTextBox3 = new RichTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(22, 87);
            button1.Name = "button1";
            button1.Size = new Size(108, 32);
            button1.TabIndex = 0;
            button1.Text = "Show/Hide";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(22, 296);
            button2.Name = "button2";
            button2.Size = new Size(108, 32);
            button2.TabIndex = 0;
            button2.Text = "Show/Hide";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(richTextBox3);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(numericUpDown3);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(numericUpDown2);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(184, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 201);
            panel1.TabIndex = 1;
            panel1.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(250, 124);
            label8.Name = "label8";
            label8.Size = new Size(78, 15);
            label8.TabIndex = 3;
            label8.Text = "thread count:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(142, 124);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 3;
            label7.Text = "max:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 124);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 3;
            label6.Text = "min:";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(250, 141);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(74, 23);
            numericUpDown3.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(33, 24);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(295, 97);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(142, 140);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(46, 23);
            numericUpDown2.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(33, 141);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(50, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // button4
            // 
            button4.Location = new Point(130, 169);
            button4.Name = "button4";
            button4.Size = new Size(87, 23);
            button4.TabIndex = 1;
            button4.Text = "start";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(12, 13);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(335, 116);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = "";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(richTextBox2);
            panel2.Location = new Point(184, 228);
            panel2.Name = "panel2";
            panel2.Size = new Size(365, 196);
            panel2.TabIndex = 1;
            panel2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(250, 132);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 2;
            label3.Text = "Avg: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(142, 132);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 2;
            label2.Text = "Max: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 132);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 2;
            label1.Text = "Min: ";
            // 
            // button3
            // 
            button3.Location = new Point(131, 170);
            button3.Name = "button3";
            button3.Size = new Size(86, 23);
            button3.TabIndex = 1;
            button3.Text = "start";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(33, 52);
            label4.Name = "label4";
            label4.Size = new Size(62, 32);
            label4.TabIndex = 2;
            label4.Text = "Ex 1:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(33, 261);
            label5.Name = "label5";
            label5.Size = new Size(62, 32);
            label5.TabIndex = 2;
            label5.Text = "Ex 4:";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(35, 3);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.Size = new Size(293, 19);
            richTextBox3.TabIndex = 4;
            richTextBox3.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 436);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Panel panel1;
        private Button button4;
        private RichTextBox richTextBox2;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private RichTextBox richTextBox1;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown3;
        private Label label8;
        private Label label7;
        private Label label6;
        private RichTextBox richTextBox3;
    }
}