using System;

namespace OcarinaStudios.MathRacing.Math
{
    public class MathCalculator: IMathObserver
    {
        public static Action<int> OnResultObserver;
        private int _result;
        public void Subtract(int x, int y)
        {
            _result = x - 1;
            Notify();
        }

        public void Divide(int x, int y)
        {
            _result = x / y;
            Notify();
        }

        public void Multiply(int x, int y)
        {
            _result = x * y;
            Notify();
        }

        public void Sum(int x, int y)
        {
            _result = x + y;
            Notify();
        }
        public void Notify()
        {
            OnResultObserver?.Invoke(_result);
        }
    }
}