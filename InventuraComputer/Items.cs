using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventuraComputer
{
    public class Item
    {
        //lastnosti
        //prop 2xtab
        public Item()
        {
            
        }
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }

        //...dodate

        //konstruktorji
        //ctor 2xtab
        public Item(string itemid, string itemname, double price)
        {
            ItemID = itemid;
            ItemName = itemname;
            Price = price;
            //...
        }
        
    }

    public class SoftwareItem : Item
    {
        //lastnosti
        //prop 2xtab
        public string LicenceKey { get; set; }
        public int SizeInMB { get; set; }

        //...dodate
        public SoftwareItem()
        {
            
        }
        //konstruktorji
        //ctor 2xtab
        public SoftwareItem(string itemid, string itemname, double price, string licencekey, int sizeinmb) : base(itemid, itemname, price)
        {
            LicenceKey = licencekey;
            SizeInMB = sizeinmb;
        }
        

    }

    public class HardwareItem : Item
    {
        //lastnosti
        //prop 2xtab
        public double Weight { get; set; }

        //...dodate

        //konstruktorji
        //ctor 2xtab
        public HardwareItem()
        {
            
        }
        public HardwareItem(string itemid, string itemname, double price, double weight) : base(itemid, itemname, price)
        {
            Weight = weight;
        }
        
    }
    
    public class Computer : HardwareItem
    {
        //lastnosti
        //prop 2xtab
        public int NoOfCores { get; set; }
        public int AmountOfRAM { get; set; }
        public int HDDSize { get; set; }

        //...dodate
        public Computer()
        {
            
        }
        //konstruktorji
        //ctor 2xtab
        public Computer(string itemid, string itemname, double price, int noofcores, int amountofram, int hddsize, double weight) : base(itemid, itemname, price, weight)
        {
            NoOfCores = noofcores;
            AmountOfRAM = amountofram;
            HDDSize = hddsize;
        }
        

    }
    public class Monitor : HardwareItem
    {
        //lastnosti
        //prop 2xtab
        public string Resolution { get; set; }
        public string MonitorType { get; set; }

        //...dodate

        //konstruktorji
        //ctor 2xtab
        public Monitor()
        {
            
        }
        public Monitor(string itemid, string itemname, double price, string resolution, string monitortype, double weight) : base(itemid, itemname, price, weight)
        {
            Resolution = resolution;
            MonitorType = monitortype;
        }
        
    }
}
