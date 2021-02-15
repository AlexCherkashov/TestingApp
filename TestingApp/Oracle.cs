using System;
using System.Collections.Generic;
using System.Linq;

namespace TestingApp
{
    public static class Oracle
    {
        public static string GetAnswers(Data inputData)
        {
            bool stepIsDouble = Double.TryParse(inputData.Step, out double step);
            bool methodIsDouble = Double.TryParse(inputData.Method, out double method);
            List<string> output = new List<string>();

            if (inputData.LeftBorder >= inputData.RightBorder)
                output.Add("Левая граница диапазона должна быть < правой границы диапазона!");

            if (!stepIsDouble)
                output.Add("Шаг интегрирования должен быть числом");
            else if (step > 0.5 || step < 0.000001)
                output.Add("Шаг интегрирования должен быть в пределах [0.000001;0.5]");

            if (!methodIsDouble)
                output.Add("Четвертый параметр должен быть числом");
            else if (method > 3 || method < 1)
                output.Add("Четвертый параметр определяет метод интегрирования и должен быть в пределах [1;3]");

            if (inputData.Coeffs.Count == 0)
                output.Add("Число параметров не соответствует ожидаемому и должно быть, как минимум 5!");

            if (output.Count == 0)
            {
                double result = 0;
                for (int i = 0; i < inputData.Coeffs.Count(); i++)
                    result += inputData.Coeffs[i] * ((Math.Pow(inputData.RightBorder, i + 1) / (i + 1))
                                                    - (Math.Pow(inputData.LeftBorder, i + 1) / (i + 1)));
                return "S = " + Math.Round(result, 4);
            }

            return string.Join("\r\n", output);
        }
    }
}
