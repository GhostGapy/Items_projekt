namespace InventuraComputer
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vpogled = new System.Windows.Forms.GroupBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Edit = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAddWeight = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelPrice2 = new System.Windows.Forms.Label();
            this.labelName2 = new System.Windows.Forms.Label();
            this.labelID2 = new System.Windows.Forms.Label();
            this.textBoxAddPrice = new System.Windows.Forms.TextBox();
            this.textBoxAddName = new System.Windows.Forms.TextBox();
            this.textBoxAddID = new System.Windows.Forms.TextBox();
            this.Vpogled.SuspendLayout();
            this.Edit.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.ItemName,
            this.Price});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(541, 454);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Tag = "Id";
            this.ID.Text = "ID";
            // 
            // ItemName
            // 
            this.ItemName.Text = "Name";
            this.ItemName.Width = 200;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 200;
            // 
            // Vpogled
            // 
            this.Vpogled.Controls.Add(this.deleteBtn);
            this.Vpogled.Controls.Add(this.label1);
            this.Vpogled.Controls.Add(this.comboBox1);
            this.Vpogled.Controls.Add(this.listView1);
            this.Vpogled.Location = new System.Drawing.Point(12, 12);
            this.Vpogled.Name = "Vpogled";
            this.Vpogled.Size = new System.Drawing.Size(562, 527);
            this.Vpogled.TabIndex = 1;
            this.Vpogled.TabStop = false;
            this.Vpogled.Text = "Vpogled";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(377, 493);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(179, 23);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Izbriši podan izdelek";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Izbrano:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Hardware",
            "Software",
            "Computer",
            "Monitor"});
            this.comboBox1.Location = new System.Drawing.Point(63, 495);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Edit
            // 
            this.Edit.Controls.Add(this.label10);
            this.Edit.Controls.Add(this.textBox1);
            this.Edit.Controls.Add(this.label9);
            this.Edit.Controls.Add(this.label8);
            this.Edit.Controls.Add(this.label7);
            this.Edit.Controls.Add(this.editBtn);
            this.Edit.Controls.Add(this.labelPrice);
            this.Edit.Controls.Add(this.labelName);
            this.Edit.Controls.Add(this.labelID);
            this.Edit.Controls.Add(this.textBox6);
            this.Edit.Controls.Add(this.textBox5);
            this.Edit.Controls.Add(this.textBox4);
            this.Edit.Controls.Add(this.textBoxPrice);
            this.Edit.Controls.Add(this.textBoxName);
            this.Edit.Controls.Add(this.textBoxID);
            this.Edit.Location = new System.Drawing.Point(590, 12);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(144, 527);
            this.Edit.TabIndex = 2;
            this.Edit.TabStop = false;
            this.Edit.Text = "Edit";
            this.Edit.Enter += new System.EventHandler(this.Edit_Enter);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(21, 383);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "label10";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 399);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.Visible = false;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(21, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "label9";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(21, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "label8";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(21, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "label7";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(37, 493);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 9;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.Location = new System.Drawing.Point(21, 151);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(100, 13);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Price:";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(21, 89);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(100, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelID
            // 
            this.labelID.Location = new System.Drawing.Point(21, 34);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(100, 13);
            this.labelID.TabIndex = 6;
            this.labelID.Text = "ID:";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(21, 341);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 5;
            this.textBox6.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(21, 281);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.Visible = false;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(21, 223);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.Visible = false;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(21, 167);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(21, 105);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(21, 50);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxAddWeight);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.labelPrice2);
            this.groupBox1.Controls.Add(this.labelName2);
            this.groupBox1.Controls.Add(this.labelID2);
            this.groupBox1.Controls.Add(this.textBoxAddPrice);
            this.groupBox1.Controls.Add(this.textBoxAddName);
            this.groupBox1.Controls.Add(this.textBoxAddID);
            this.groupBox1.Location = new System.Drawing.Point(740, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 527);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(50, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "label6";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(50, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "label5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(50, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "label4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(50, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxAddWeight
            // 
            this.textBoxAddWeight.Location = new System.Drawing.Point(50, 277);
            this.textBoxAddWeight.Name = "textBoxAddWeight";
            this.textBoxAddWeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddWeight.TabIndex = 18;
            this.textBoxAddWeight.Visible = false;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(62, 489);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 17;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(50, 455);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 16;
            this.textBox9.Visible = false;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(50, 395);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 15;
            this.textBox8.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(50, 337);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 14;
            this.textBox7.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Add What Item:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "All",
            "Hardware",
            "Software",
            "Computer",
            "Monitor"});
            this.comboBox2.Location = new System.Drawing.Point(28, 45);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(144, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // labelPrice2
            // 
            this.labelPrice2.Location = new System.Drawing.Point(50, 203);
            this.labelPrice2.Name = "labelPrice2";
            this.labelPrice2.Size = new System.Drawing.Size(100, 13);
            this.labelPrice2.TabIndex = 11;
            this.labelPrice2.Text = "Price:";
            this.labelPrice2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelName2
            // 
            this.labelName2.Location = new System.Drawing.Point(50, 147);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(100, 13);
            this.labelName2.TabIndex = 10;
            this.labelName2.Text = "Name:";
            this.labelName2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelID2
            // 
            this.labelID2.Location = new System.Drawing.Point(50, 85);
            this.labelID2.Name = "labelID2";
            this.labelID2.Size = new System.Drawing.Size(100, 13);
            this.labelID2.TabIndex = 7;
            this.labelID2.Text = "ID:";
            this.labelID2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxAddPrice
            // 
            this.textBoxAddPrice.Location = new System.Drawing.Point(50, 219);
            this.textBoxAddPrice.Name = "textBoxAddPrice";
            this.textBoxAddPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddPrice.TabIndex = 2;
            // 
            // textBoxAddName
            // 
            this.textBoxAddName.Location = new System.Drawing.Point(50, 163);
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddName.TabIndex = 1;
            // 
            // textBoxAddID
            // 
            this.textBoxAddID.Enabled = false;
            this.textBoxAddID.Location = new System.Drawing.Point(50, 101);
            this.textBoxAddID.Name = "textBoxAddID";
            this.textBoxAddID.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddID.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 549);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Vpogled);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Vpogled.ResumeLayout(false);
            this.Vpogled.PerformLayout();
            this.Edit.ResumeLayout(false);
            this.Edit.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox Vpogled;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox Edit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TextBox textBoxAddName;
        private System.Windows.Forms.TextBox textBoxAddID;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelPrice2;
        private System.Windows.Forms.Label labelName2;
        private System.Windows.Forms.Label labelID2;
        private System.Windows.Forms.TextBox textBoxAddPrice;
        private System.Windows.Forms.TextBox textBoxAddWeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
    }
}

