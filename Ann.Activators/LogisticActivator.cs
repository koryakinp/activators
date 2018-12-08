using System;

namespace Ann.Activators
{
    public class LogisticActivator : Activator
    {
        public override double CalculateDeriviative(double input)
        {
            return input * (1 - input);
        }

        public override double CalculateValue(double input)
        {
            return 1 / (1 + Math.Exp(-input));
        }

        public override ActivatorType GetActivatorType()
        {
            return ActivatorType.Sigmoid;
        }
    }
}
