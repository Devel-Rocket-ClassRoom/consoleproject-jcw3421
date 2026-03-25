using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Player : Character
    {
        public string big { get; set; }
        public int Hp  { get; set; } 
        public int Damage { get; set; }
        public int Defense { get; set; }
        public Player(string name = "", int damage =0 , int hp = 5000, int defense = 1000)
        {
            big = name;
            Damage = damage;
            Hp = hp;
            Defense = defense;
        }
    }
     
}
