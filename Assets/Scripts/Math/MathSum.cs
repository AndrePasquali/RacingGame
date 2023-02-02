namespace OcarinaStudios.MathRacing.Math
{
    public class MathSum: IMathCommand
    {
        private int _x;
        private int _y;
        
        private MathCalculator _calculator;

        public MathSum(int x, int y, MathCalculator calculator)
        {
            _x = x;
            _y = y;
            _calculator = calculator;
        }
        public void Execute()
        {
           _calculator.Sum(_x, _y);
        }
    }
}