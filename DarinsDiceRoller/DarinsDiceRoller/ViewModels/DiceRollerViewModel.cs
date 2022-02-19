using DarinsDiceRoller.Interfaces;
using DarinsDiceRoller.Services;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace DarinsDiceRoller.ViewModels
{
    public class DiceRollerViewModel : BindableObject
    {
        public ICommand RollDie20 => new Command(Roll20);
        public ICommand RollDie12 => new Command(Roll12);
        public ICommand RollDie10 => new Command(Roll10);
        public ICommand RollDie8 => new Command(Roll8);
        public ICommand RollDie6 => new Command(Roll6);
        public ICommand RollDie4 => new Command(Roll4);
        public ICommand RollDie2 => new Command(Roll2);
        public ICommand RollDie100 => new Command(Roll100);

        int roll = 0;
        string rollDisplay = "Roll Me!";

        public string RollDisplay20
        {
            get => rollDisplay;
            set
            {
                if (value == rollDisplay)
                    return;

                rollDisplay = value;
                OnPropertyChanged();
            }
        }

        public string RollDisplay12
        {
            get => rollDisplay;
            set
            {
                if (value == rollDisplay)
                    return;

                rollDisplay = value;
                OnPropertyChanged();
            }
        }

        public string RollDisplay10
        {
            get => rollDisplay;
            set
            {
                if (value == rollDisplay)
                    return;

                rollDisplay = value;
                OnPropertyChanged();
            }
        }

        public string RollDisplay8
        {
            get => rollDisplay;
            set
            {
                if (value == rollDisplay)
                    return;

                rollDisplay = value;
                OnPropertyChanged();
            }
        }

        public string RollDisplay6
        {
            get => rollDisplay;
            set
            {
                if (value == rollDisplay)
                    return;

                rollDisplay = value;
                OnPropertyChanged();
            }
        }

        public string RollDisplay4
        {
            get => rollDisplay;
            set
            {
                if (value == rollDisplay)
                    return;

                rollDisplay = value;
                OnPropertyChanged();
            }
        }

        public string RollDisplay2
        {
            get => rollDisplay;
            set
            {
                if (value == rollDisplay)
                    return;

                rollDisplay = value;
                OnPropertyChanged();
            }
        }

        public string RollDisplay100
        {
            get => rollDisplay;
            set
            {
                if (value == rollDisplay)
                    return;

                rollDisplay = value;
                OnPropertyChanged();
            }
        }

        void Roll20()
        {
            IDiceBuilder<SimpleDiceBuilder> simpleDiceBuilder = new SimpleDiceBuilder();
            roll = simpleDiceBuilder.AddD20().RollDice();
            if (roll == 1)
            {
                RollDisplay20 = $"1 - Critical Fail!!";
            } else if (roll == 20)
            {
                RollDisplay20 = $"20 - Critical Success!!";
            }
            else
            {
                RollDisplay20 = $"{roll}";
            }
        }

        void Roll12()
        {
            IDiceBuilder<SimpleDiceBuilder> simpleDiceBuilder = new SimpleDiceBuilder();
            roll = simpleDiceBuilder.AddD12().RollDice();
            RollDisplay12 = $"{roll}";
        }

        void Roll10()
        {
            IDiceBuilder<SimpleDiceBuilder> simpleDiceBuilder = new SimpleDiceBuilder();
            roll = simpleDiceBuilder.AddD10().RollDice();
            RollDisplay10 = $"{roll}";
        }

        void Roll8()
        {
            IDiceBuilder<SimpleDiceBuilder> simpleDiceBuilder = new SimpleDiceBuilder();
            roll = simpleDiceBuilder.AddD8().RollDice();
            RollDisplay8 = $"{roll}";
        }

        void Roll6()
        {
            IDiceBuilder<SimpleDiceBuilder> simpleDiceBuilder = new SimpleDiceBuilder();
            roll = simpleDiceBuilder.AddD6().RollDice();
            RollDisplay6 = $"{roll}";
        }

        void Roll4()
        {
            IDiceBuilder<SimpleDiceBuilder> simpleDiceBuilder = new SimpleDiceBuilder();
            roll = simpleDiceBuilder.AddD4().RollDice();
            RollDisplay4 = $"{roll}";
        }
        void Roll2()
        {
            IDiceBuilder<SimpleDiceBuilder> simpleDiceBuilder = new SimpleDiceBuilder();
            roll = simpleDiceBuilder.AddD2().RollDice();
            RollDisplay2 = $"{roll}";
        }

        void Roll100()
        {
            IDiceBuilder<SimpleDiceBuilder> simpleDiceBuilder = new SimpleDiceBuilder();
            roll = simpleDiceBuilder.AddD100().RollDice();
            RollDisplay100 = $"{roll}";
        }
    }
}
