using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp
{
    public static class Oracle
    {
        public static string GetAnswers(Data inputData)
        {
            bool stepIsDouble = Double.TryParse(inputData.Step, out double step);
            bool methodIsDouble = Double.TryParse(inputData.Method, out double method);
            string output = "";

            if (inputData.LeftBorder >= inputData.RightBorder)
            {
                if (output != "") output += "\r\n";
                output += "Левая граница диапазона должна быть < правой границы диапазона!";
            }
            if (!stepIsDouble || step > 0.5 || step < 0.000001)
            {
                if (output != "") output += "\r\n";
                output += "Шаг интегрирования должен быть в пределах [0.000001;0.5]";
            }
            if (!methodIsDouble || method > 3 || method < 1)
            {
                if (output != "") output += "\r\n";
                output += "Четвертый параметр определяет метод интегрирования и должен быть в пределах [1;3]";
            }
            if (inputData.Coeffs.Count == 0)
            {
                if (output != "") output += "\r\n";
                output += "Число параметров не соответствует ожидаемому и должно быть, как минимум 5!";
            }
            if (output == "")
            {
                double result = 0;
                for (int i = 0; i < inputData.Coeffs.Count(); i++)
                    result += inputData.Coeffs[i] * ((Math.Pow(inputData.RightBorder, i + 1) / (i + 1))
                                                    - (Math.Pow(inputData.LeftBorder, i + 1) / (i + 1)));
                output = "S = " + result;
            }
            return output;
        }
    }
}
