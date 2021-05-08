using System;
namespace Examples
{
    class Exchanger
    {
        public double Seed { get; private set; } = 1;
        readonly double accuracy = 0.1;
        public readonly double inputValue;
        public readonly double correctOutputValue;
        public Exchanger(double inputValue, double correctOutputValue)
        {
            this.inputValue = inputValue;
            this.correctOutputValue = correctOutputValue;
        }
        public void FindCourse()
        {
            Seed = inputValue * Seed < correctOutputValue ? Seed + accuracy : Seed - accuracy;
            Console.WriteLine(Seed);
        }
    }
}
