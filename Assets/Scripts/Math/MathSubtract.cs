namespace OcarinaStudios.MathRacing.Math
{
    public class MathSubtract: IMathCommand
    {
        private int _x;
        private int _y;
        
        private MathCalculator _calculator;

        public MathSubtract(int x, int y, MathCalculator calculator)
        {
            _x = x;
            _y = y;
            _calculator = calculator;
        }
        public void Execute()
        {
            _calculator.Subtract(_x, _y);
        }
    }
}