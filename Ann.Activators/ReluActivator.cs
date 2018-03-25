using System;

namespace Ann.Activators
{
    public class ReluActivator : Activator
    {
        public override double CalculateDeriviative(double input)
        {
            return input < 0 ? 0 : 1;
        }

        public override double CalculateValue(double input)
        {
            return Math.Max(0, input);
        }
    }
}
