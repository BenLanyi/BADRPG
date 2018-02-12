using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGEngine.Models
{
    //might need to break this into some inherited classes organised by type.
    [Serializable]
    public class GameItem
    {
        //name of the item
        public string name { get; set; }
        //short description of the item
        public string description { get; set; }
        //item type. eg. weapon, armour, food, potion
        public string type { get; set; }
        //item sub type. eg. for weapon it may be sword, axe or for armour it may be light or heavy, for potion it could be health or magic
        public string subType { get; set; }
        //attribute applies differently to each item type. For example on a weapon it will be its base damage, or on a health potion how much health it restores
        public int attribute { get; set; }
        //durability of a weapon will determine how many uses you can get out of it, for consumables like food and potions this will always be set to 1.
        public int durability { get; set; }

    }
}
