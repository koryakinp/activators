using System;

namespace Ann.Activators
{
    public class SoftmaxActivator
    {
        public double[] CalculateDeriviative(double[] input, double[] error)
        {
            var output = new double[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                var temp = 0.0;
                for (int j = 0; j < input.Length; j++)
                {
                    var o1 = input[i];
                    var o2 = input[j];
                    var ds = i == j ? o1 * (1 - o1) : -o1 * o2;

                    temp += ds * error[j];
                }

                output[i] = temp;
            }

            return output;
        }

        public double[] CalculateValue(double[] input)
        {
            var output = new double[input.Length];
            double sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += Math.Exp(input[i]);
            }

            for (int i = 0; i < input.Length; i++)
            {
                output[i] = Math.Exp(input[i]) / sum;
            }

            return output;
        }

        public ActivatorType GetActivatorType()
        {
            return ActivatorType.Softmax;
        }
    }
}
