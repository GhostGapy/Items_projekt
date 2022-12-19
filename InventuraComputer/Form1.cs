using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace InventuraComputer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public void refreshlist()
        {
            textBox1.Text = "";
            textBoxID.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBoxName.Text = "";
            textBoxPrice.Text = "";
            listView1.Items.Clear();
            listView1.Columns.Clear();
            SQLiteConnection conn = new SQLiteConnection("Data Source=InventuraComputer.db");
            conn.Open();
            using (conn)
            {
                int maxidint = 0;
                SQLiteCommand maxid = new SQLiteCommand("SELECT max(id) from Item", conn);
                try { maxidint = Convert.ToInt32(maxid.ExecuteScalar()); }
                catch { }
                maxidint++;
                textBoxAddID.Text = maxidint.ToString();
            }
                if (comboBox1.SelectedIndex == 0)
            {
                listView1.Columns.Add("ID");
                listView1.Columns.Add("Name");
                listView1.Columns.Add("Price");
                listView1.Columns[0].Width = 50;
                listView1.Columns[1].Width = 150;
                listView1.Columns[2].Width = 50;
                ItemsDatabase db = new ItemsDatabase();
                List<ListViewItem> items = db.GetItems();
                foreach (ListViewItem i in items)
                {
                    listView1.Items.Add(i);
                }
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                textBox1.Visible = false;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                listView1.Columns.Add("ID");
                listView1.Columns.Add("Name");
                listView1.Columns.Add("Price");
                listView1.Columns.Add("Weight");
                listView1.Columns[0].Width = 50;
                listView1.Columns[1].Width = 150;
                listView1.Columns[2].Width = 50;
                listView1.Columns[3].Width = 50;
                ItemsDatabase db = new ItemsDatabase();
                List<ListViewItem> items = db.GetHardware();
                foreach (ListViewItem i in items)
                {
                    listView1.Items.Add(i);
                }
                textBox4.Visible = true;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label7.Visible = true;
                label8.Visible = false;
                label9.Visible = false;
                label7.Text = "Weight:";
                label10.Visible = false;
                textBox1.Visible = false;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                listView1.Columns.Add("ID");
                listView1.Columns.Add("Name");
                listView1.Columns.Add("Price");
                listView1.Columns.Add("Licence Key");
                listView1.Columns.Add("Size in MB");
                listView1.Columns[0].Width = 50;
                listView1.Columns[1].Width = 150;
                listView1.Columns[2].Width = 50;
                listView1.Columns[3].Width = 150;
                listView1.Columns[4].Width = 100;
                ItemsDatabase db = new ItemsDatabase();
                List<ListViewItem> items = db.GetSoftware();
                foreach (ListViewItem i in items)
                {
                    listView1.Items.Add(i);
                }
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = false;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = false;
                label7.Text = "Licence Key:";
                label8.Text = "Size in MB:";
                label10.Visible = false;
                textBox1.Visible = false;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                listView1.Columns.Add("ID");
                listView1.Columns.Add("Name");
                listView1.Columns.Add("Price");
                listView1.Columns.Add("No. of cores");
                listView1.Columns.Add("Amount of RAM");
                listView1.Columns.Add("HDD size");
                listView1.Columns[0].Width = 50;
                listView1.Columns[1].Width = 150;
                listView1.Columns[2].Width = 50;
                listView1.Columns[3].Width = 100;
                listView1.Columns[4].Width = 100;
                listView1.Columns[5].Width = 100;
                ItemsDatabase db = new ItemsDatabase();
                List<ListViewItem> items = db.GetComputer();
                foreach (ListViewItem i in items)
                {
                    listView1.Items.Add(i);
                }
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label7.Text = "No. of cores:";
                label8.Text = "Amount of RAM:";
                label9.Text = "HDD size:";
                label10.Text = "Weight";
                textBox1.Visible = true;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                listView1.Columns.Add("ID");
                listView1.Columns.Add("Name");
                listView1.Columns.Add("Price");
                listView1.Columns.Add("Resolution");
                listView1.Columns.Add("Monitor Type");
                listView1.Columns.Add("Weight");
                listView1.Columns[0].Width = 50;
                listView1.Columns[1].Width = 150;
                listView1.Columns[2].Width = 50;
                listView1.Columns[3].Width = 100;
                listView1.Columns[4].Width = 100;
                ItemsDatabase db = new ItemsDatabase();
                List<ListViewItem> items = db.GetMonitor();
                foreach (ListViewItem i in items)
                {
                    listView1.Items.Add(i);
                }
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox1.Visible = false;
                label10.Visible = false;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label7.Text = "Resolution:";
                label8.Text = "Monitor Type:";
                label9.Text = "Weight:";
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxID.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBoxName.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBoxPrice.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
            }
            catch { }
            if (comboBox1.SelectedIndex == 1)
            {
                try
                {
                    textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;

                }
                catch { }
                textBox4.Visible = true;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                try
                {
                    textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
                    textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
                }
                catch { }
                textBox4.Visible = true;
                textBox5.Visible = true;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                try
                {
                    textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
                    textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
                    textBox6.Text = listView1.SelectedItems[0].SubItems[5].Text;
                    textBox1.Text = listView1.SelectedItems[0].SubItems[6].Text;
                }
                catch { }
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox1.Visible = true;
            }
            if(comboBox1.SelectedIndex==4)
            {
                try
                {
                    textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
                    textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
                    textBox6.Text = listView1.SelectedItems[0].SubItems[5].Text;

                }
                catch { }
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshlist();
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=InventuraComputer.db");
            con.Open();
            using (con)
            {
                
                if (comboBox1.SelectedIndex == 0)
                {
                    Item item = new Item(textBoxID.Text, textBoxName.Text, Convert.ToDouble(textBoxPrice.Text));
                    ItemsDatabase db = new ItemsDatabase();
                    db.editItem(item.ItemID,item.ItemName,item.Price.ToString());
                    refreshlist();
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    HardwareItem hardware = new HardwareItem(textBoxID.Text, textBoxName.Text, Convert.ToDouble(textBoxPrice.Text), Convert.ToDouble(textBox4.Text));
                    ItemsDatabase db = new ItemsDatabase();
                    db.editHardware(hardware.ItemID, hardware.ItemName, hardware.Price.ToString(), hardware.Weight.ToString());
                    refreshlist();
                }
                if(comboBox1.SelectedIndex==2)
                {

                    ItemsDatabase db = new ItemsDatabase(); SoftwareItem software = new SoftwareItem(textBoxID.Text, textBoxName.Text, Convert.ToDouble(textBoxPrice.Text), textBox4.Text, Convert.ToInt32(textBox5.Text));
                    db.editSoftware(software.ItemID, software.ItemName, software.Price.ToString(), software.LicenceKey, software.SizeInMB.ToString());
                    refreshlist();
                }
                if(comboBox1.SelectedIndex==3)
                {
                    Computer computer = new Computer(textBoxID.Text, textBoxName.Text, Convert.ToDouble(textBoxPrice.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), Convert.ToDouble(textBox1.Text));
                    ItemsDatabase db = new ItemsDatabase();
                    db.editComputer(computer.ItemID, computer.ItemName, computer.Price.ToString(), computer.Weight.ToString(), computer.NoOfCores.ToString(), computer.AmountOfRAM.ToString(), computer.HDDSize.ToString());
                    refreshlist();
                }
                if (comboBox1.SelectedIndex == 4)
                {
                    Monitor monitor = new Monitor(textBoxID.Text, textBoxName.Text, Convert.ToDouble(textBoxPrice.Text), textBox4.Text, textBox5.Text, Convert.ToDouble(textBox6.Text));
                    ItemsDatabase db = new ItemsDatabase();
                    db.editMonitor(monitor.ItemID, monitor.ItemName, monitor.Price.ToString(),monitor.Weight.ToString(), monitor.Resolution.ToString(), monitor.MonitorType.ToString());
                    refreshlist();
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=InventuraComputer.db");
            con.Open();
            using (con)
            {
                int id = 0;
                SQLiteCommand topid = new SQLiteCommand("SELECT MAX(id) FROM Item", con);
                try{ 
                    id = Convert.ToInt32(topid.ExecuteScalar());
                }
                catch { }
                id++;
                string newid = id.ToString();
                if (comboBox2.SelectedIndex == 0)
                {
                    Item item = new Item(newid, textBoxAddName.Text, Convert.ToDouble(textBoxAddPrice.Text));
                    ItemsDatabase db = new ItemsDatabase();
                    db.AddItem(item.ItemID, item.ItemName, item.Price.ToString());
                    refreshlist();
                }
                if (comboBox2.SelectedIndex == 1)
                {
                    HardwareItem hardware = new HardwareItem(newid, textBoxAddName.Text, Convert.ToDouble(textBoxAddPrice.Text), Convert.ToDouble(textBoxAddWeight.Text));
                    ItemsDatabase db = new ItemsDatabase();
                    db.AddHardware(hardware.ItemID, hardware.ItemName, hardware.Price.ToString(), hardware.Weight.ToString());
                    refreshlist();
                }
                if (comboBox2.SelectedIndex == 2)
                {
                    SoftwareItem software = new SoftwareItem(newid, textBoxAddName.Text, Convert.ToDouble(textBoxAddPrice.Text), textBox7.Text, Convert.ToInt32(textBox8.Text));
                    ItemsDatabase db = new ItemsDatabase();
                    db.AddSoftware(software.ItemID, software.ItemName, software.Price.ToString(), software.LicenceKey.ToString(), software.SizeInMB.ToString());
                    refreshlist();
                }
                if (comboBox2.SelectedIndex == 3)
                {
                    Computer computer = new Computer(newid, textBoxAddName.Text, Convert.ToDouble(textBoxAddPrice.Text), Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text), Convert.ToDouble(textBoxAddWeight.Text));
                    ItemsDatabase db = new ItemsDatabase();
                    db.AddComputer(computer.ItemID, computer.ItemName, computer.Price.ToString(), computer.Weight.ToString(), computer.NoOfCores.ToString(), computer.AmountOfRAM.ToString(), computer.HDDSize.ToString());
                    refreshlist();
                }
                if(comboBox2.SelectedIndex==4)
                {
                    Monitor monitor = new Monitor(newid, textBoxAddName.Text, Convert.ToDouble(textBoxAddPrice.Text), textBox7.Text, textBox8.Text, Convert.ToDouble(textBoxAddWeight.Text));
                    ItemsDatabase db = new ItemsDatabase();
                    db.AddMonitor(monitor.ItemID, monitor.ItemName, monitor.Price.ToString(), monitor.Weight.ToString(), monitor.Resolution, monitor.MonitorType);
                    refreshlist();
                }
            }
            textBoxAddName.Text = "";
            textBoxAddPrice.Text = "";
            textBoxAddWeight.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            comboBox1.SelectedIndex = comboBox2.SelectedIndex;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                textBox7.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                textBoxAddWeight.Visible = false;
            }
            if (comboBox2.SelectedIndex == 1)
            {
                textBox7.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = true;
                label6.Text = "Weight:"; 
                textBoxAddWeight.Visible = true;
            }
            if (comboBox2.SelectedIndex == 2)
            {
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = false;
                label3.Visible = true;
                label3.Text = "License key:";
                label4.Visible = true;
                label4.Text = "Size in mb:";
                label5.Visible = false;
                label6.Visible = false;
                textBoxAddWeight.Visible = false;
            }
            if (comboBox2.SelectedIndex == 3)
            {
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                label3.Visible = true;
                label3.Text = "No of cores:";
                label4.Visible = true;
                label4.Text = "RAM Amount:";
                label5.Visible = true;
                label5.Text = "HDD sizes:";
                label6.Visible = true;
                label6.Text = "Weight:";
                textBoxAddWeight.Visible = true;
            }
            if(comboBox2.SelectedIndex == 4)
            {
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = false;
                label3.Visible = true;
                label3.Text = "Resolution:";
                label4.Visible = true;
                label4.Text = "Monitor type:";
                label5.Visible = false;
                label6.Visible = true;
                label6.Text = "Weight:";
                textBoxAddWeight.Visible = true;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ItemsDatabase db = new ItemsDatabase();
                if (comboBox1.SelectedIndex == 0)
                {
                    db.DeleteComputer(listView1.SelectedItems[0].SubItems[0].Text);
                    refreshlist();
                    db.DeleteMonitor(listView1.SelectedItems[0].SubItems[0].Text);
                    refreshlist();
                    db.DeleteSoftware(listView1.SelectedItems[0].SubItems[0].Text);
                    refreshlist();
                    db.DeleteHardware(listView1.SelectedItems[0].SubItems[0].Text);
                    refreshlist();
                    db.DeleteItem(listView1.SelectedItems[0].SubItems[0].Text);
                    refreshlist();
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    db.DeleteComputer(listView1.SelectedItems[0].SubItems[0].Text);
                    refreshlist();
                    db.DeleteMonitor(listView1.SelectedItems[0].SubItems[0].Text);
                    refreshlist();
                    db.DeleteHardware(listView1.SelectedItems[0].SubItems[0].Text);
                    refreshlist();
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    db.DeleteSoftware(listView1.SelectedItems[0].SubItems[0].Text);
                    refreshlist();
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    db.DeleteComputer(listView1.SelectedItems[0].SubItems[0].Text);
                    refreshlist();
                }
                if (comboBox1.SelectedIndex == 4)
                {
                    db.DeleteMonitor(listView1.SelectedItems[0].SubItems[0].Text);
                    refreshlist();
                }
            }
            catch { }
            refreshlist();
        }

        private void Edit_Enter(object sender, EventArgs e)
        {

        }
    }
}

