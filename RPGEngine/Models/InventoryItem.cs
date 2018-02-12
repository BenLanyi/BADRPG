using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGEngine.Models
{
    
    public class InventoryItem
    {
        public int itemID { get; set; }
        public string itemName { get; set; }
        public int currentDurability { get; set; }

        public InventoryItem(int itemID, String itemName, int currentDurability)
        {
            this.itemID = itemID;
            this.itemName = itemName;
            this.currentDurability = currentDurability;
        }

    }
}
