using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RPGEngine.ViewModels;
using RPGEngine.Models;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameSession _gameSession;

        public MainWindow()
        {
            InitializeComponent();

            _gameSession = new GameSession();
            _gameSession.NewGame();

            MainTextBox.Text = "Name " + _gameSession.currentPlayer.name + "\nLevel " + _gameSession.currentPlayer.level + "\nClass " + _gameSession.currentPlayer.characterClassName + "\nStrength " + _gameSession.currentPlayer.strength + "\nIntelligence " + _gameSession.currentPlayer.intelligence + "\nAgility " + _gameSession.currentPlayer.agility + "\nCarryWeight " + _gameSession.currentPlayer.carryWeight + "\nHealth " + _gameSession.currentPlayer.health;
            MainTextBox.Text += "\n\n";
            foreach(InventoryItem inventoryItem in _gameSession.currentPlayer.currentInventory.inventory)
            {
                MainTextBox.Text += "\nItem Name" + inventoryItem.itemName + "\nCurrent Durability " + inventoryItem.currentDurability + "\nType " + _gameSession.currentItemList.getItem(inventoryItem.itemName).name;
            }

            _gameSession.SaveGame();
        }

    }
}
