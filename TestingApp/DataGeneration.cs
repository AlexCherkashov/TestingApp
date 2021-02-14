using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp
{
    public static class DataGeneration
    {
        public static Data[] Run(bool isPositive, double leftBorder, double rightBorder, List<double> coeffs, int testcaseCount)
        {
            Random random = new Random();
            Data[] output = new Data[testcaseCount];

            if (isPositive)
            {
                for (int i = 0; i < testcaseCount; i++)
                {
                    double step = Math.Round(random.NextDouble() * 0.499999 + 0.000001, 6);
                    int method = random.Next(1, 4);
                    output[i] = new Data(leftBorder, rightBorder, step.ToString(), method.ToString(), coeffs);
                }
            }
            else
            {
                for (int i = 0; i < testcaseCount; i++)
                {
                    //double step = random.Next(4, 10);
                    //int method = random.Next(4, 10);
                    int chose = random.Next(2);
                    string step;
                    string method;

                    if (chose == 0)
                    {
                        chose = random.Next(2);
                        step = chose == 0 ? "step" : random.Next(-5, 0).ToString();
                        method = random.Next(1, 4).ToString();
                    }
                    else
                    {
                        chose = random.Next(2);
                        method = chose == 0 ? "method" : random.Next(5, 20).ToString();
                        step = Math.Round(random.NextDouble() * 0.499999 + 0.000001, 5).ToString();
                    }

                    output[i] = new Data(leftBorder, rightBorder, step, method, coeffs);
                }
            }

            return output;
        }
    }
}
