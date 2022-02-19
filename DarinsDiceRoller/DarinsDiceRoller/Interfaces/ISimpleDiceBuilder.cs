using DarinsDiceRoller.Services;

namespace DarinsDiceRoller.Interfaces
{
    public interface IDiceBuilder<T>
    {
        T AddD2(int numOfDice = 1);
        T AddD4(int numOfDice = 1);
        T AddD6(int numOfDice = 1);
        T AddD8(int numOfDice = 1);
        T AddD10(int numOfDice = 1);
        T AddD12(int numOfDice = 1);
        T AddD20(int numOfDice = 1);
        T AddD100(int numOfDice = 1);
        void Reset();
        int RollDice();
    }
}
