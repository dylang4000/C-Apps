using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Warrior
    {
        //this is an auto-impletmented property
        public WarriorType WarriorType { get; set; }

        public Warrior()
        {

            MessageBox.Show("a new warrior was created");
        }
    }
    public enum WarriorType
    {
        Samurai,
        Mongols,
        Knights,
        Ninja,
        Gladiator,
        Mamluks,
        Shaolin,
        Berserker,
        Warrior,
        Spartan,
        Paladin,
        Viking,
        Crusader,

    }
}
