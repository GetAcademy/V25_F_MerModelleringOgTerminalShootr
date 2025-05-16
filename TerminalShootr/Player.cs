using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalShootr
{
    internal class Player
    {
        public int Health;
        public int Armor;
        public Weapon[] Weapons;

        public Player(int health, int armor)
        {
            Health = health;
            Armor = armor;
            Weapons =
            [
                new Weapon("Empty", 0),
                new Weapon("Empty", 0),
                new Weapon("Empty", 0),
                new Weapon("Empty", 0),
                new Weapon("Empty", 0)
            ];
        }

    }
}
