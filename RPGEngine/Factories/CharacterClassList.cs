﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGEngine.Models;

namespace RPGEngine.Models
{
    public class CharacterClassList
    {
        private List<CharacterClass> _characterClasses = new List<CharacterClass>();

        public CharacterClassList()
        {
            CharacterClass warrior = new CharacterClass("Warrior", 5, 2, 3);
            _characterClasses.Add(warrior);
            CharacterClass wizard = new CharacterClass("Wizard", 2, 5, 3);
            _characterClasses.Add(wizard);
            CharacterClass thief = new CharacterClass("Thief", 3, 2, 5);
        }

        //player can create own class. Max points to spend on attributes is 10.
        public void AddCustomClass(string name, int baseStrength, int baseIntelligence, int baseAgility)
        {
            CharacterClass custom = new CharacterClass(name, baseStrength, baseIntelligence, baseAgility);
            _characterClasses.Add(custom);
        }

        public CharacterClass GetClassDetails(string name)
        {
            foreach(CharacterClass playerClass in _characterClasses)
            {
                if(playerClass.name == name)
                {
                    return playerClass;
                }
            }
            return null;
        }

    }

}
