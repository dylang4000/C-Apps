using _2024_25_02_02_02;

namespace WinFormsApp1
{
    public enum DayOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday

    }
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FizzBuzzForm fizzBuzzForm = new FizzBuzzForm();
            fizzBuzzForm.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SecretNumberForm secretNumberForm = new SecretNumberForm();
            secretNumberForm.ShowDialog(this);
        }

        private void DigitCounterButton_Click(object sender, EventArgs e)
        {
            DigitCounterForm digitCounterForm = new DigitCounterForm();
            digitCounterForm.ShowDialog(this);
        }

        private void EvenOddButton_Click(object sender, EventArgs e)
        {
            EvenOddForm evenOddForm = new EvenOddForm();
            evenOddForm.ShowDialog(this);
        }

        private void EnumButton_Click(object sender, EventArgs e)
        {
            WarriorType Warrior = WarriorType.Viking;
            switch (Warrior)
            {
                case WarriorType.Ninja:
                    MessageBox.Show("ninja uses they mind");
                    break;
                case WarriorType.Samurai:
                    MessageBox.Show("samuria uses they sword");
                    break;
                case WarriorType.Viking:
                    MessageBox.Show("viking uses they axe");
                    break;
                case WarriorType.Spartan:
                    MessageBox.Show("spartan uses they javelins");
                    break;
                case WarriorType.Knights:
                    MessageBox.Show("knights uses they lance");
                    break;
                case WarriorType.Warrior:
                    MessageBox.Show("ninja uses they mind");
                    break;
                case WarriorType.Mongols:
                    MessageBox.Show("mongol uses they horses");
                    break;
                default:
                    MessageBox.Show("defauilty");
                    break;

            }

            Warrior newWarrior = new Warrior();
            //MessageBox.Show(newWarrior.WarriorType)

        }

        private void CreateWarriorbutton_Click(object sender, EventArgs e)
        {
            WarriorForm warriorform = new WarriorForm();
            warriorform.ShowDialog(this);
        }

        private void NewBookFormButton_Click(object sender, EventArgs e)
        {
            BookForm bookform = new BookForm();
            bookform.ShowDialog(this);
        }
    }

}
