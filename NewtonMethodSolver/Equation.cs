using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonMethodSolver
{
    class Equation
    {
        private double epsilon;
        private double x0;

        public Equation(double x0, double epsilon)
        {
            this.x0 = x0;
            this.epsilon = epsilon;
        }

        public double GetSolution()
        {
            double x1 = x0 - F(x0) / DerivativeF(x0);
            while (Math.Abs(x1 - x0) > epsilon)
            {
                x0 = x1;
                x1 = x1 - F(x1) / DerivativeF(x1);
            }
            return Round(x1);
        }

        private double F(double x)
        {
            return x * x * x + 0.4 * x + 2;
        }

        private double DerivativeF(double x)
        {
            return 3 * x * x + 0.4;
        }

        private double Round(double number)
        {
            var dotIndex = epsilon.ToString().IndexOf(',');
            var numbersAfterDot = epsilon.ToString().Substring(dotIndex).Length - 1;
            return Math.Round(number, numbersAfterDot);
        }
    }
}
