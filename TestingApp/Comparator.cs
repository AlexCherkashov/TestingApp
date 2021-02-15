using System;

namespace TestingApp
{
    public class Comparator
    {
        public static string GenerateReport(bool isPositive, Data[] inputData, double error, string[] expectedResult, string[] validResult)
        {
            string[] reports = new string[inputData.Length];
            string testType = isPositive ? "P" : "N";

            for (int i = 0; i < inputData.Length; i++)
            {
                reports[i] = "TEST " + (i + 1) + " " + testType + "\r\n"
                                + "X: " + inputData[i].ToString() + "\r\n"
                                + "EPS: " + error + "\r\n"
                                + "YE: " + expectedResult[i] + "\r\n"
                                + "YF: " + validResult[i] + "\r\n";
                if (expectedResult[i][0] == 'S' && validResult[i][0] == 'S')
                {
                    double exp = double.Parse(expectedResult[i].Split()[2].Replace('.', ','));
                    double valid = double.Parse(validResult[i].Split()[2].Replace('.', ','));
                    double diff = Math.Round(Math.Abs(exp - valid), 3);
                    reports[i] += "|SYE - SYF| = " + diff;
                    if (diff > error)
                        reports[i] += " > EPS\r\n!!NOT PASSED";
                    else
                        reports[i] += " <= EPS\r\nPASSED";
                }
                else
                {
                    if (expectedResult[i] == validResult[i])
                        reports[i] += "PASSED";
                    else reports[i] += "!!NOT PASSED";
                }
            }

            return string.Join("\r\n\r\n", reports);
        }
    }
}
