namespace SqlTask2WinApp
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txt_BookName = new TextBox();
            txt_Price = new TextBox();
            txt_InStock = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Add = new Button();
            Delete = new Button();
            Update = new Button();
            Seacrh = new Button();
            label5 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 237);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(574, 201);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Sienna;
            label1.Location = new Point(296, 9);
            label1.Name = "label1";
            label1.Size = new Size(188, 37);
            label1.TabIndex = 1;
            label1.Text = "Books Table";
            label1.Click += label1_Click;
            // 
            // txt_BookName
            // 
            txt_BookName.Location = new Point(12, 171);
            txt_BookName.Name = "txt_BookName";
            txt_BookName.Size = new Size(172, 27);
            txt_BookName.TabIndex = 2;
            // 
            // txt_Price
            // 
            txt_Price.Location = new Point(212, 171);
            txt_Price.Name = "txt_Price";
            txt_Price.Size = new Size(172, 27);
            txt_Price.TabIndex = 3;
            txt_Price.TextChanged += textBox2_TextChanged;
            // 
            // txt_InStock
            // 
            txt_InStock.Location = new Point(414, 171);
            txt_InStock.Name = "txt_InStock";
            txt_InStock.Size = new Size(172, 27);
            txt_InStock.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(12, 112);
            label2.Name = "label2";
            label2.Size = new Size(137, 30);
            label2.TabIndex = 5;
            label2.Text = "BookName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(212, 112);
            label3.Name = "label3";
            label3.Size = new Size(67, 30);
            label3.TabIndex = 6;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(414, 112);
            label4.Name = "label4";
            label4.Size = new Size(96, 30);
            label4.TabIndex = 7;
            label4.Text = "InStock";
            // 
            // Add
            // 
            Add.BackColor = SystemColors.Highlight;
            Add.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add.ForeColor = SystemColors.ButtonFace;
            Add.Location = new Point(648, 237);
            Add.Name = "Add";
            Add.Size = new Size(87, 47);
            Add.TabIndex = 8;
            Add.Text = "ADD";
            Add.UseVisualStyleBackColor = false;
            Add.Click += button1_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.Red;
            Delete.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete.ForeColor = SystemColors.ButtonFace;
            Delete.Location = new Point(632, 290);
            Delete.Name = "Delete";
            Delete.Size = new Size(122, 47);
            Delete.TabIndex = 9;
            Delete.Text = "DELETE";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // Update
            // 
            Update.BackColor = Color.Green;
            Update.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update.ForeColor = SystemColors.ButtonFace;
            Update.Location = new Point(618, 343);
            Update.Name = "Update";
            Update.Size = new Size(153, 47);
            Update.TabIndex = 10;
            Update.Text = "UPDATE";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            // 
            // Seacrh
            // 
            Seacrh.BackColor = Color.Navy;
            Seacrh.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Seacrh.ForeColor = SystemColors.ButtonFace;
            Seacrh.Location = new Point(616, 160);
            Seacrh.Name = "Seacrh";
            Seacrh.Size = new Size(167, 47);
            Seacrh.TabIndex = 11;
            Seacrh.Text = "SEARCH";
            Seacrh.UseVisualStyleBackColor = false;
            Seacrh.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkSlateBlue;
            label5.Location = new Point(616, 118);
            label5.Name = "label5";
            label5.Size = new Size(172, 24);
            label5.TabIndex = 12;
            label5.Text = "Seacrh BookName:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(597, 391);
            button1.Name = "button1";
            button1.Size = new Size(191, 47);
            button1.TabIndex = 13;
            button1.Text = "SHOW";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(Seacrh);
            Controls.Add(Update);
            Controls.Add(Delete);
            Controls.Add(Add);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_InStock);
            Controls.Add(txt_Price);
            Controls.Add(txt_BookName);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txt_BookName;
        private TextBox txt_Price;
        private TextBox txt_InStock;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Add;
        private Button Delete;
        private Button Update;
        private Button Seacrh;
        private Label label5;
        private Button button1;
    }
}
