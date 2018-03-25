using System;

namespace Ann.Activators
{
    public class TanhActivator : Activator
    {
        public override double CalculateDeriviative(double input)
        {
            return 1 - Math.Pow(Math.Tanh(input), 2);
        }

        public override double CalculateValue(double input)
        {
            return Math.Tanh(input);
        }
    }
}
