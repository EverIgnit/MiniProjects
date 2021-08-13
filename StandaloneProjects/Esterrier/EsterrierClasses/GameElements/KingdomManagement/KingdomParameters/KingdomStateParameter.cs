namespace Esterrier.GameElements.KingdomManagement.KingdomParameters
{
    public class KingdomStateParameter
    {
        public int MaxValue { get; } = 10;
        private int _value = 5;
        public int Value { get => _value;
            set => _value = value < 0 ? 0 : value > MaxValue ? MaxValue : value; }
    }
}
