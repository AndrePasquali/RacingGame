namespace OcarinaStudios.MathRacing.Math
{
    public class MathDivide: IMathCommand
    {
        private int _x;
        private int _y;
        
        private MathCalculator _calculator;

        public MathDivide(int x, int y, MathCalculator calculator)
        {
            _calculator = calculator;
            _x = x;
            _y = y;
        }
        
        public void Execute()
        {
           _calculator.Divide(_x, _y);
        }
    }
}