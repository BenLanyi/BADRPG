using RPGEngine.Factories;
using RPGEngine.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace RPGEngine.ViewModels
{
    public class GameSession
    {
        public Player currentPlayer { get; set; }
        public ItemList currentItemList { get; set; }

        private const string FILEPATH = "SaveFile.dat";


        public GameSession()
        {
            currentItemList = new ItemList();

        }

        public void NewGame()
        {
            
            currentPlayer = new Player("Ben");
            CharacterClassList characterClassList = new CharacterClassList();
            currentPlayer.SetClass(characterClassList.GetClassDetails("Wizard"));

            currentPlayer.currentInventory.AddItem(currentItemList.getItem("Wooden Sword"));
        }

        public void SaveGame()
        {
            
        }

        public void LoadGame()
        {
            
        }

    }

}
