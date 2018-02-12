using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGEngine.Models
{
    
    public class Player : INotifyPropertyChanged
    {

        public PlayerInventory currentInventory { get; set; }

        private string _name;
        private string _characterClassName;
        private int _level = 1;
        private int _experience = 0;
        private int _experienceToLevel = 100;
        private int _gold = 0;
                
        //Player Stats
        private int _health;
        private int _magicPoints;

        
        //Player Attributes
        public int strength { get; private set; }
        public int intelligence { get; private set; }
        public int agility { get; private set; }
        public int carryWeight
        {
            get { return strength * 5; }
        }
        

        public string name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("name");
            }
        }
        public string characterClassName
        {
            get { return _characterClassName; }
            set {
                _characterClassName = value;
                OnPropertyChanged("characterClass");
            }
        }
        public int level
        {
            get { return _level; }
            private set
            {
                _level = value;
                OnPropertyChanged("level");
                OnCharacterLevelUp();
            }
        }
        public int experience {
            get { return _experience; }
            set
            {
                _experience = value;
                //level up when experience reaches target. 
                if (_experience >= _experienceToLevel)
                {
                    //increase level
                    level++;
                    //save any experience that was in excess of the experience target
                    _experience -= _experienceToLevel;
                    //set new experience target for next level
                    _experienceToLevel = Convert.ToInt32(_experienceToLevel * 1.2);
                    
                }
                OnPropertyChanged("experience");
            }
        }
        public int gold {
            get { return _gold; }
            set
            {
                _gold = value;
                OnPropertyChanged("gold");
            }
        }
        public int health
        {
            get { return _health; }
            set
            {
                _health = value;
                OnPropertyChanged("hitpoints");
            }
        }
        public int magicPoints
        {
            get { return _magicPoints; }
            set { _magicPoints = value; }
        }

        //PLAYER CONSTRUCTOR
        public Player(string name)
        {
            this.name = name;
            currentInventory = new PlayerInventory();

        }

        public void SetAttributes(int strength, int intelligence, int agility)
        {
            this.strength = strength;
            this.intelligence = intelligence;
            this.agility = agility;
        }

        public void SetClass(CharacterClass characterClass)
        {
            this.characterClassName = characterClass.name;
            SetAttributes(characterClass.baseStrength, characterClass.baseIntelligence, characterClass.baseAgility);
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler CharacterLevelUp;

        protected virtual void OnCharacterLevelUp()
        {
            //Need to spend attribute points. Recieve 2 per level.
            //Create dialog window in UI that allows you to choose which attributes to assign points to.
            //UI will need to listen for this event.
            strength++;
            intelligence++;

        }

    }

    
}
