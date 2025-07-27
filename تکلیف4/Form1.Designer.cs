namespace تکلیف4
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            SortBtn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(7, -1);
            label1.Name = "label1";
            label1.Size = new Size(178, 32);
            label1.TabIndex = 0;
            label1.Text = "SORT machine";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(29, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 29);
            label2.Name = "label2";
            label2.Size = new Size(128, 15);
            label2.TabIndex = 2;
            label2.Text = "please add ten number";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(47, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(29, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(82, 55);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(29, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(117, 55);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(29, 23);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(152, 55);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(29, 23);
            textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 84);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(29, 23);
            textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(47, 84);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(29, 23);
            textBox7.TabIndex = 8;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(82, 84);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(29, 23);
            textBox8.TabIndex = 9;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(117, 84);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(29, 23);
            textBox9.TabIndex = 10;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(152, 84);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(29, 23);
            textBox10.TabIndex = 11;
            // 
            // SortBtn
            // 
            SortBtn.Location = new Point(47, 113);
            SortBtn.Name = "SortBtn";
            SortBtn.Size = new Size(99, 31);
            SortBtn.TabIndex = 13;
            SortBtn.Text = "save";
            SortBtn.UseVisualStyleBackColor = true;
            SortBtn.Click += SortBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(47, 150);
            button1.Name = "button1";
            button1.Size = new Size(99, 31);
            button1.TabIndex = 14;
            button1.Text = "sort";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(194, 192);
            Controls.Add(button1);
            Controls.Add(SortBtn);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private Button SortBtn;
        private Button button1;
    }
}