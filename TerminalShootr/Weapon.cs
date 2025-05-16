using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalShootr
{
    internal class Weapon
    {
        public string Name;
        public int Ammo;

        public Weapon(string name, int ammo)
        {
            Name = name;
            Ammo = ammo;
        }
    }
}
