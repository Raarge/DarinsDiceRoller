using DarinsDiceRoller.Interfaces;
using DarinsDiceRoller.Services;
using System.Windows.Input;
using Xamarin.Forms;

namespace DarinsDiceRoller.ViewModels
{
    public class DiceRollerViewModel : BindableObject
    {
        private const string DEFAULT_ROLL_TEXT = "Roll Me!";

        public ICommand RollDie20 => new Command(Roll20);
        public ICommand RollDie12 => new Command(Roll12);
        public ICommand RollDie10 => new Command(Roll10);
        public ICommand RollDie8 => new Command(Roll8);
        public ICommand RollDie6 => new Command(Roll6);
        public ICommand RollDie4 => new Command(Roll4);
        public ICommand RollDie2 => new Command(Roll2);
        public ICommand RollDie100 => new Command(Roll100);
        public ICommand ResetAllDice => new Command(Reset);

        private string _rollDisplay20 = DEFAULT_ROLL_TEXT;
        public string RollDisplay20
        {
            get => _rollDisplay20;
            set
            {
                _rollDisplay20 = value;
                OnPropertyChanged();
            }
        }

        private string _rollDisplay12 = DEFAULT_ROLL_TEXT;
        public string RollDisplay12
        {
            get => _rollDisplay12;
            set
            {
                _rollDisplay12 = value;
                OnPropertyChanged();
            }
        }

        private string _rollDisplay10 = DEFAULT_ROLL_TEXT;
        public string RollDisplay10
        {
            get => _rollDisplay10;
            set
            {
                _rollDisplay10 = value;
                OnPropertyChanged();
            }
        }

        private string _rollDisplay8 = DEFAULT_ROLL_TEXT;
        public string RollDisplay8
        {
            get => _rollDisplay8;
            set
            {
                _rollDisplay8 = value;
                OnPropertyChanged();
            }
        }

        private string _rollDisplay6 = DEFAULT_ROLL_TEXT;
        public string RollDisplay6
        {
            get => _rollDisplay6;
            set
            {
                _rollDisplay6 = value;
                OnPropertyChanged();
            }
        }

        private string _rollDisplay4 = DEFAULT_ROLL_TEXT;
        public string RollDisplay4
        {
            get => _rollDisplay4;
            set
            {
                _rollDisplay4 = value;
                OnPropertyChanged();
            }
        }

        private string _rollDisplay2 = DEFAULT_ROLL_TEXT;
        public string RollDisplay2
        {
            get => _rollDisplay2;
            set
            {
                _rollDisplay2 = value;
                OnPropertyChanged();
            }
        }

        private string _rollDisplay100 = DEFAULT_ROLL_TEXT;
        public string RollDisplay100
        {
            get => _rollDisplay100;
            set
            {
                _rollDisplay100 = value;
                OnPropertyChanged();
            }
        }

        void Roll20()
        {
            IDiceBuilder<SimpleDiceBuilder> simpleDiceBuilder = new SimpleDiceBuilder();
            var roll = simpleDiceBuilder.AddD20().RollDice();
            if (roll == 1)
            {
                RollDisplay20 = $"{roll} - Critical Fail!!";
            } else if (roll == 20)
            {
                RollDisplay20 = $"{roll} - Critical Success!!";
            }
            else
            {
                RollDisplay20 = $"{roll}";
            }
        }

        void Roll12()
        {
            IDiceBuilder<SimpleDiceBuilder> simpleDiceBuilder = new SimpleDiceBuilder();
            var roll = simpleDiceBuilder.AddD12().RollDice();
            RollDisplay12 = $"{roll}";
        }

        void Roll10()
        {
            IDiceBuilder<SimpleDiceBuilder> simpleDiceBuilder = new SimpleDiceBuilder();
            var roll = simpleDiceBuilder.AddD10().RollDice();
            RollDisplay10 = $"{roll}";
        }

        void Roll8()
        {
            IDiceBuilder<SimpleDiceBuilder> simpleDiceBuilder = new SimpleDiceBuilder();
            var roll = simpleDiceBuilder.AddD8().RollDice();
            RollDisplay8 = $"{roll}";
        }

        void Roll6()
        {
            IDiceBuilder<SimpleDiceBuilder> simpleDiceBuilder = new SimpleDiceBuilder();
            var roll = simpleDiceBuilder.AddD6().RollDice();
            RollDisplay6 = $"{roll}";
        }

        void Roll4()
        {
            IDiceBuilder<SimpleDiceBuilder> simpleDiceBuilder = new SimpleDiceBuilder();
            var roll = simpleDiceBuilder.AddD4().RollDice();
            RollDisplay4 = $"{roll}";
        }
        void Roll2()
        {
            IDiceBuilder<SimpleDiceBuilder> simpleDiceBuilder = new SimpleDiceBuilder();
            var roll = simpleDiceBuilder.AddD2().RollDice();
            RollDisplay2 = $"{roll}";
        }

        void Roll100()
        {
            IDiceBuilder<SimpleDiceBuilder> simpleDiceBuilder = new SimpleDiceBuilder();
            var roll = simpleDiceBuilder.AddD100().RollDice();
            RollDisplay100 = $"{roll}";
        }

        void Reset()
        {
            RollDisplay100 = DEFAULT_ROLL_TEXT;
            RollDisplay20 = DEFAULT_ROLL_TEXT;
            RollDisplay12 = DEFAULT_ROLL_TEXT;
            RollDisplay10 = DEFAULT_ROLL_TEXT;
            RollDisplay8 = DEFAULT_ROLL_TEXT;
            RollDisplay6 = DEFAULT_ROLL_TEXT;
            RollDisplay4 = DEFAULT_ROLL_TEXT;
            RollDisplay2 = DEFAULT_ROLL_TEXT;
        }
    }
}
