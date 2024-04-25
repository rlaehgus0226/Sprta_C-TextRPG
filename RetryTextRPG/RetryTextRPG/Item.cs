using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetryTextRPG
{
    internal class Item
    {
        public string Name;
        public string Description;
        public int Attack;
        public int Defence;
        public int HP;
        public bool isEquip;


        public Item(string name, string description, int attack = 0, int defence = 0, int hp = 0, bool isEquip = false)
        {
            Name = name;
            Description = description;
            Attack = attack;
            Defence = defence;
            HP = hp;
        }
    }
}
