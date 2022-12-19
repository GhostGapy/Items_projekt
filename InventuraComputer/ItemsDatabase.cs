using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventuraComputer
{
    public class ItemsDatabase
    {

        //   |----------------|   //
        //   |     ITEMS      |   //
        //   |----------------|   //

        public void AddItem(string id, string name, string price)
        {
            SQLiteConnection con = new SQLiteConnection("data source = InventuraComputer.db");

            using (con)
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Item (id, name, price) VALUES (@id, @name, @price)", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void DeleteItem(string id)
        {
            SQLiteConnection con = new SQLiteConnection("data source = InventuraComputer.db");
            using (con)
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Item WHERE id = @id", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public List<ListViewItem> GetItems()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=InventuraComputer.db");
            using (con)
            {
                con.Open();
                List<ListViewItem> items = new List<ListViewItem>();
                string query = "SELECT * FROM Item";
                SQLiteCommand command = new SQLiteCommand(query, con);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["id"].ToString());
                    item.SubItems.Add(reader["name"].ToString());
                    item.SubItems.Add(reader["price"].ToString());
                    items.Add(item);
                }
                reader.Close();
                return items;
            }
        }



        public void editItem(string id, string name, string price)
        {
            SQLiteConnection con = new SQLiteConnection("data source = InventuraComputer.db");
            con.Open();
            using (con)
            {
                SQLiteCommand cmd = new SQLiteCommand("UPDATE Item SET name = @name, price = @price WHERE id = @id", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.ExecuteNonQuery();
            }
        }





        //   |-------------------|   //
        //   |     SOFTWARE      |   //
        //   |-------------------|   //

        public void AddSoftware(string id, string name, string price, string licencekey, string sizeinmb)
        {
            AddItem(id, name, price);
            SQLiteConnection con = new SQLiteConnection("data source = InventuraComputer.db");
            using (con)
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Software (id, licensekey, sizeinmb, item_id) VALUES (@id, @licencekey, @sizeinmb, @id)", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@licencekey", licencekey);
                cmd.Parameters.AddWithValue("@sizeinmb", sizeinmb);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void DeleteSoftware(string id)
        {
            SQLiteConnection con = new SQLiteConnection("data source = InventuraComputer.db");
            using (con)
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Software WHERE id = @id", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            DeleteItem(id);
        }
        public List<ListViewItem> GetSoftware()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=InventuraComputer.db");
            using (con)
            {
                con.Open();
                List<ListViewItem> items = new List<ListViewItem>();
                string query = "SELECT * FROM Item INNER JOIN Software ON Software.item_id=Item.id";
                SQLiteCommand command = new SQLiteCommand(query, con);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["id"].ToString());
                    item.SubItems.Add(reader["name"].ToString());
                    item.SubItems.Add(reader["price"].ToString());
                    item.SubItems.Add(reader["licensekey"].ToString());
                    item.SubItems.Add(reader["sizeinmb"].ToString());
                    items.Add(item);
                }
                reader.Close();
                return items;
            }
        }
        public void editSoftware(string id, string name, string price, string licencekey, string sizeinmb)
        {
            editItem(id, name, price);
            SQLiteConnection con = new SQLiteConnection("data source = InventuraComputer.db");
            con.Open();
            using (con)
            {
                SQLiteCommand cmd2 = new SQLiteCommand("UPDATE Software SET licensekey = @licencekey, sizeinmb = @sizeinmb WHERE id = @id", con);
                cmd2.Parameters.AddWithValue("@id", id);
                cmd2.Parameters.AddWithValue("@licencekey", licencekey);
                cmd2.Parameters.AddWithValue("@sizeinmb", sizeinmb);
                cmd2.ExecuteNonQuery();
            }
            editItem(id, name, price);
        }




        //   |-------------------|   //
        //   |     HARDWARE      |   //
        //   |-------------------|   //

        public void AddHardware(string id, string name, string price, string weight)
        {
            AddItem(id, name, price);
            SQLiteConnection con = new SQLiteConnection("data source = InventuraComputer.db");
            con.Open();
            using (con)
            {
                SQLiteCommand cmd2 = new SQLiteCommand("INSERT INTO Hardware (id, weight, item_id) VALUES (@id, @weight, @id)", con);
                cmd2.Parameters.AddWithValue("@id", id);
                cmd2.Parameters.AddWithValue("@weight", weight);
                cmd2.ExecuteNonQuery();
            }
        }
        public void DeleteHardware(string id)
        {
            SQLiteConnection con = new SQLiteConnection("data source = InventuraComputer.db");
            using (con)
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Hardware WHERE id = @id", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            DeleteItem(id);
        }

        public void editHardware(string id, string name, string price, string weight)
        {
            editItem(id, name, price);
            SQLiteConnection con = new SQLiteConnection("data source = InventuraComputer.db");
            using (con)
            {
                con.Open();
                SQLiteCommand cmd2 = new SQLiteCommand("UPDATE Hardware SET weight = @weight WHERE id = @id", con);
                cmd2.Parameters.AddWithValue("@id", id);
                cmd2.Parameters.AddWithValue("@weight", weight);
                cmd2.ExecuteNonQuery();
            }
        }

        public List<ListViewItem> GetHardware()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=InventuraComputer.db");
            using (con)
            {
                con.Open();
                List<ListViewItem> items = new List<ListViewItem>();
                string query = "SELECT * FROM Item INNER JOIN Hardware ON hardware.item_id= item.id";
                SQLiteCommand command = new SQLiteCommand(query, con);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["id"].ToString());
                    item.SubItems.Add(reader["name"].ToString());
                    item.SubItems.Add(reader["price"].ToString());
                    item.SubItems.Add(reader["weight"].ToString());
                    items.Add(item);
                }
                reader.Close();
                return items;
            }
        }






        //   |-------------------|   //
        //   |     COMPUTER      |   //
        //   |-------------------|   //

        public void AddComputer(string id, string name, string price, string weight, string noofcores, string amountofram, string hddsize)
        {
            AddHardware(id, name, price, weight);
            SQLiteConnection con = new SQLiteConnection("data source = InventuraComputer.db");
            using (con)
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Computer (id, noofcores, amountofram, hddsizes, hardware_id) VALUES (@id, @noofcores, @amountofram, @hddsize, @id)", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@noofcores", noofcores);
                cmd.Parameters.AddWithValue("@amountofram", amountofram);
                cmd.Parameters.AddWithValue("@hddsize", hddsize);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void DeleteComputer(string id)
        {
            SQLiteConnection con = new SQLiteConnection("data source = InventuraComputer.db");
            using (con)
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Computer WHERE id = @id", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            DeleteHardware(id);
        }
        public List<ListViewItem> GetComputer()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=InventuraComputer.db");
            using (con)
            {
                con.Open();
                List<ListViewItem> items = new List<ListViewItem>();
                string query = "SELECT * FROM Item INNER JOIN Hardware ON hardware.item_id = item.id INNER JOIN Computer ON computer.hardware_id = hardware.id";
                SQLiteCommand command = new SQLiteCommand(query, con);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["id"].ToString());
                    item.SubItems.Add(reader["name"].ToString());
                    item.SubItems.Add(reader["price"].ToString());
                    item.SubItems.Add(reader["noofcores"].ToString());
                    item.SubItems.Add(reader["amountofram"].ToString());
                    item.SubItems.Add(reader["hddsizes"].ToString());
                    item.SubItems.Add(reader["weight"].ToString());
                    items.Add(item);
                }
                reader.Close();
                return items;
            }
        }
        public void editComputer(string id, string name, string price, string noofcores, string amountofram, string hddsize, string weight)
        {
            editHardware(id, name, price, weight);
            SQLiteConnection con = new SQLiteConnection("data source = InventuraComputer.db");
            using (con)
            {
                con.Open();
                SQLiteCommand cmd2 = new SQLiteCommand("UPDATE Computer SET noofcores = @noofcores, amountofram = @amountofram, hddsizes = @hddsize WHERE id = @id", con);
                cmd2.Parameters.AddWithValue("@id", id);
                cmd2.Parameters.AddWithValue("@noofcores", noofcores);
                cmd2.Parameters.AddWithValue("@amountofram", amountofram);
                cmd2.Parameters.AddWithValue("@hddsize", hddsize);
                cmd2.ExecuteNonQuery();
            }
        }






        //   |-------------------|   //
        //   |      MONITOR      |   //
        //   |-------------------|   //

        public void AddMonitor(string id, string name, string price, string weight, string resolution, string monitortype)
        {
            AddHardware(id, name, price, weight);
            SQLiteConnection con = new SQLiteConnection("data source = InventuraComputer.db");
            using (con)
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Monitor (id, resolution, monitortype, hardware_id) VALUES (@id, @resolution, @monitortype, @id)", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@resolution", resolution);
                cmd.Parameters.AddWithValue("@monitortype", monitortype);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void DeleteMonitor(string id)
        {
            SQLiteConnection con = new SQLiteConnection("data source = InventuraComputer.db");
            using (con)
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Monitor WHERE id = @id", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            DeleteHardware(id);
        }
        public void editMonitor(string id, string name, string price, string weight, string resolution, string monitortype)
        {
            editHardware(id, name, price, weight);
            SQLiteConnection con = new SQLiteConnection("data source = InventuraComputer.db");
            using (con)
            {
                con.Open();
                SQLiteCommand cmd2 = new SQLiteCommand("UPDATE Monitor SET resolution = @resolution, monitortype = @monitortype WHERE id = @id", con);
                cmd2.Parameters.AddWithValue("@id", id);
                cmd2.Parameters.AddWithValue("@resolution", resolution);
                cmd2.Parameters.AddWithValue("@monitortype", monitortype);

                cmd2.ExecuteNonQuery();
            }
        }
        public List<ListViewItem> GetMonitor()
        {
            SQLiteConnection con = new SQLiteConnection("data source = InventuraComputer.db");
            using (con)
            {
                con.Open();
                string query = "SELECT * FROM Item INNER JOIN Hardware ON Hardware.Item_id=Item.id INNER JOIN Monitor ON Monitor.hardware_id=Hardware.id";
                SQLiteCommand command = new SQLiteCommand(query, con);
                SQLiteDataReader reader = command.ExecuteReader();
                List<ListViewItem> items = new List<ListViewItem>();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["id"].ToString());
                    item.SubItems.Add(reader["name"].ToString());
                    item.SubItems.Add(reader["price"].ToString());
                    item.SubItems.Add(reader["resolution"].ToString());
                    item.SubItems.Add(reader["monitortype"].ToString());
                    item.SubItems.Add(reader["weight"].ToString());
                    items.Add(item);
                }
                reader.Close();
                return items;

            }
        }
    }
}
