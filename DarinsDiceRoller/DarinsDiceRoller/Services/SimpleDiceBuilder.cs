using DarinsDiceRoller.Interfaces;
using System;

namespace DarinsDiceRoller.Services
{
    public class SimpleDiceBuilder : IDiceBuilder<SimpleDiceBuilder>
    {
        private int D2DiceCount;
        private int D4DiceCount;
        private int D6DiceCount;
        private int D8DiceCount;
        private int D10DiceCount;
        private int D12DiceCount;
        private int D20DiceCount;
        private int D100DiceCount;

        public SimpleDiceBuilder()
        {
            this.Reset();
        }

        public SimpleDiceBuilder AddD10(int numOfDice = 1)
        {
            D10DiceCount = numOfDice;
            return this;
        }

        public SimpleDiceBuilder AddD100(int numOfDice = 1)
        {
            D100DiceCount = numOfDice;
            return this;
        }

        public SimpleDiceBuilder AddD12(int numOfDice = 1)
        {
            D12DiceCount = numOfDice;
            return this;
        }

        public SimpleDiceBuilder AddD2(int numOfDice = 1)
        {
            D2DiceCount = numOfDice;
            return this;
        }

        public SimpleDiceBuilder AddD20(int numOfDice = 1)
        {
            D20DiceCount = numOfDice;
            return this;
        }

        public SimpleDiceBuilder AddD4(int numOfDice = 1)
        {
            D4DiceCount = numOfDice;
            return this;
        }

        public SimpleDiceBuilder AddD6(int numOfDice = 1)
        {
            D6DiceCount = numOfDice;
            return this;
        }

        public SimpleDiceBuilder AddD8(int numOfDice = 1)
        {
            D8DiceCount = numOfDice;
            return this;
        }

        public void Reset()
        {
            D2DiceCount = 0;
            D4DiceCount = 0;
            D6DiceCount = 0;
            D8DiceCount = 0;
            D10DiceCount = 0;
            D12DiceCount = 0;
            D20DiceCount = 0;
            D100DiceCount = 0;
        }

        public int RollDice()
        {
            int rollValue = 0;
            var random = new Random();

            for(int i = 0; i < D2DiceCount; i++)
            {
                var testValue = random.Next(1,3);
                Console.WriteLine($"D2 Roll [{i}]: {testValue}");
                rollValue += testValue;
            }
            for (int i = 0; i < D4DiceCount; i++)
            {
                var testValue = random.Next(1, 5);
                Console.WriteLine($"D4 Roll [{i}]: {testValue}");
                rollValue += testValue;
            }
            for (int i = 0; i < D6DiceCount; i++)
            {
                var testValue = random.Next(1, 7);
                Console.WriteLine($"D6 Roll [{i}]: {testValue}");
                rollValue += testValue;
            }
            for (int i = 0; i < D8DiceCount; i++)
            {
                var testValue = random.Next(1, 9);
                Console.WriteLine($"D8 Roll [{i}]: {testValue}");
                rollValue += testValue;
            }
            for (int i = 0; i < D10DiceCount; i++)
            {
                var testValue = random.Next(1, 11);
                Console.WriteLine($"D10 Roll [{i}]: {testValue}");
                rollValue += testValue;
            }
            for (int i = 0; i < D12DiceCount; i++)
            {
                var testValue = random.Next(1, 13);
                Console.WriteLine($"D12 Roll [{i}]: {testValue}");
                rollValue += testValue;
            }
            for (int i = 0; i < D20DiceCount; i++)
            {
                var testValue = random.Next(1, 21);
                Console.WriteLine($"D20 Roll [{i}]: {testValue}");
                rollValue += testValue;
            }
            for (int i = 0; i < D100DiceCount; i++)
            {
                var testValue = random.Next(1, 101);
                Console.WriteLine($"D100 Roll [{i}]: {testValue}");
                rollValue += testValue;
            }
            return rollValue;
        }
    }
}
