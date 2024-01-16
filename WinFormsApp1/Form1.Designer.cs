namespace WinFormsApp1
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            comboBox1 = new ComboBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(14, 76);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(361, 344);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(401, 76);
            listBox2.Margin = new Padding(3, 4, 3, 4);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(385, 344);
            listBox2.TabIndex = 1;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(112, 463);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 20;
            listBox3.Location = new Point(14, 551);
            listBox3.Margin = new Padding(3, 4, 3, 4);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(361, 344);
            listBox3.TabIndex = 3;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 20;
            listBox4.Location = new Point(401, 551);
            listBox4.Margin = new Padding(3, 4, 3, 4);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(361, 344);
            listBox4.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 516);
            label1.Name = "label1";
            label1.Size = new Size(283, 20);
            label1.TabIndex = 5;
            label1.Text = "All employees from selected department:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(401, 516);
            label2.Name = "label2";
            label2.Size = new Size(254, 20);
            label2.TabIndex = 6;
            label2.Text = "Managers from selected department:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 467);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 7;
            label3.Text = "Department: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 37);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 8;
            label4.Text = "Departments:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(401, 37);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 9;
            label5.Text = "Employees:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 933);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(comboBox1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private ComboBox comboBox1;
        private ListBox listBox3;
        private ListBox listBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}