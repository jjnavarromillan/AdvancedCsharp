using System;
using System.Timers;

namespace AdvancedCSharp
{
    public class MathService {
        public delegate void MathPerformedHandler(double result);
        public delegate double CalculationHandler(double value1, double value2);
        public event MathPerformedHandler MathPerformed;
        public void CalculateNumbers(double value1,double value2,CalculationHandler calculation) {
            Timer timer = new Timer(5000);
            MathPerformed(calculation(value1,value2));
        }
    }
}
