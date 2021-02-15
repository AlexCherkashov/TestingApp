using System.Collections.Generic;

namespace TestingApp
{
    public class Data
    {
        public readonly double LeftBorder;
        public readonly double RightBorder;
        public readonly string Step;
        public readonly string Method;
        public readonly List<double> Coeffs;

        public Data(double leftBorder, double rightBorder, string step, string method, List<double> coeffs)
        {
            LeftBorder = leftBorder;
            RightBorder = rightBorder;
            Step = step;
            Method = method;
            Coeffs = coeffs;
        }

        public override string ToString()
        {
            return LeftBorder + " " + RightBorder + " " + Step + " " + Method + " " + string.Join(" ", Coeffs);
        }
    }
}
