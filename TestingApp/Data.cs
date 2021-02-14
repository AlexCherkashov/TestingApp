using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return LeftBorder + " " + RightBorder + " " + Step + " " + Method + " " + ArrayToString(Coeffs);
        }

        private string ArrayToString(List<double> array)
        {
            string output = "";
            foreach (double a in array)
            {
                output += a + " ";
            }
            return output;
        }


    }
}
