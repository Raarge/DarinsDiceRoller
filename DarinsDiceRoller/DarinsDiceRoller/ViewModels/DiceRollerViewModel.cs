using Android.Content.Res;
using DarinsDiceRoller.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DarinsDiceRoller.ViewModels
{
    public class DiceRollerViewModel : BindableObject
    {
        public DiceRollerViewModel()
        {
            RollDie20 = new Command(Roll20);
            RollDie12 = new Command(Roll12);
            RollDie10 = new Command(Roll10);
            RollDie8 = new Command(Roll8);
            RollDie6 = new Command(Roll6);
            RollDie4 = new Command(Roll4);
            RollDie100 = new Command(Roll100);
            
        }

        public ICommand RollDie20 { get; }
        public ICommand RollDie12 { get; }
        public ICommand RollDie10 { get; }
        public ICommand RollDie8 { get; }
        public ICommand RollDie6 { get; }
        public ICommand RollDie4 { get; }
        public ICommand RollDie100 { get; }
        

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
            Random rnd = new Random();
            
            roll = rnd.Next(1, 21);
            if(roll == 1)
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
            Random rnd = new Random();

            roll = rnd.Next(1, 13);
            RollDisplay12 = $"{roll}";
            
        }

        void Roll10()
        {
            Random rnd = new Random();

            roll = rnd.Next(1, 11);
            RollDisplay10 = $"{roll}";
            
        }

        void Roll8()
        {
            Random rnd = new Random();

            roll = rnd.Next(1, 9);
            RollDisplay8 = $"{roll}";
            
        }

        void Roll6()
        {
            Random rnd = new Random();

            roll = rnd.Next(1, 7);
            RollDisplay6 = $"{roll}";
            
        }

        void Roll4()
        {
            Random rnd = new Random();

            roll = rnd.Next(1, 5);
            RollDisplay4 = $"{roll}";
            
        }

        void Roll100()
        {
            Random rnd = new Random();

            roll = rnd.Next(1, 101);
            RollDisplay100 = $"{roll}";
            
        }        
    }
}

