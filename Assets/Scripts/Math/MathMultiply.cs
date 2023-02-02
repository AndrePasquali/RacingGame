namespace OcarinaStudios.MathRacing.Math
{
    public class MathMultiply: IMathCommand
    {
        private int _x;
        private int _y;
        
        private MathCalculator _calculator;

        public MathMultiply(int x, int y, MathCalculator calculator)
        {
            _x = x;
            _y = y;
            _calculator = calculator;
        }
        
        public void Execute()
        {
            _calculator.Multiply(_x, _y);
        }
    }
}