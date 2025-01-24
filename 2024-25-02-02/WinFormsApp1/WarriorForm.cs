using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class WarriorForm : Form
    {
        public WarriorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Warrior newWarrior = null;
            switch(WarriorComboBox.Text){
                case "Viking":
                    newWarrior = new Warrior();
                    newWarrior.WarriorType = WarriorType.Viking;
                    break;
                case "Ninja":
                    newWarrior = new Warrior();
                    newWarrior.WarriorType = WarriorType.Ninja;
                    break;
                case "Samurai":
                    newWarrior = new Warrior();
                    newWarrior.WarriorType = WarriorType.Samurai;
                    break;
                case "Knights":
                    newWarrior = new Warrior();
                    newWarrior.WarriorType = WarriorType.Knights;
                    break;
                case "Mongols":
                    newWarrior = new Warrior();
                    newWarrior.WarriorType = WarriorType.Mongols;
                    break;
                case "Gladiator":
                    newWarrior = new Warrior();
                    newWarrior.WarriorType = WarriorType.Gladiator;
                    break;
                case "spartan":
                    newWarrior = new Warrior();
                    newWarrior.WarriorType = WarriorType.Spartan;
                    break;
                case "crusader":
                    newWarrior = new Warrior();
                    newWarrior.WarriorType = WarriorType.Crusader;
                    break;
                default:
                    MessageBox.Show("not a valid warrior type");
                    break;

            }
        }
    }
}
