using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGEngine.Models;


namespace RPGEngine.Factories
{
    public class ItemList
    {
        private List<GameItem> _currentItemList;

        public ItemList()
        {
            _currentItemList = new List<GameItem>();
            //load in the item list game data from text file
            string line;
            bool checkForReadStart = true;
            bool startReading = false;
            
            
 
            System.IO.StreamReader file =
                new System.IO.StreamReader("C:/Projects/BADRPG/RPGEngine/GameData/ItemList.txt");
            while ((line = file.ReadLine()) != null)
            {
                //look for the position to start reading designated by "##"
                if (checkForReadStart == true)
                {
                    if (line == "##")
                    {
                        startReading = true;
                        checkForReadStart = false;
                    }
                }
                //start reading once start position is found
                while (startReading == true)
                {
                    line = file.ReadLine();
                    if (line != null)
                    {
                        GameItem itemToAdd = new GameItem();
                        itemToAdd.name = line;
                        itemToAdd.description = file.ReadLine();
                        itemToAdd.type = file.ReadLine();
                        itemToAdd.subType = file.ReadLine();
                        itemToAdd.attribute = Convert.ToInt32(file.ReadLine());
                        itemToAdd.durability = Convert.ToInt32(file.ReadLine());
                        _currentItemList.Add(itemToAdd);
                    }
                    else
                    {
                        //stop reading once null is found
                        startReading = false;
                    }
                }
                

            }

            file.Close();

        }

        public GameItem getItem(string name)
        {
            foreach(GameItem gameItem in _currentItemList)
            {
                if(name == gameItem.name)
                {
                    return gameItem;
                }
            }
            //need to handle null case
            return null;
        }
    }
}
