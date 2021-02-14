using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp
{
    public class Comparator
    {
        public static string GenerateReport(bool isPositive, Data[] inputData, double error, string[] expectedResult, string[] validResult)
        {
            string report = "";
            string testType = isPositive ? "P" : "N";
            for (int i = 0; i < inputData.Length; i++)
            {
                report += "TEST " + i + 1 + " " + testType + "\r\n"
                                + "X: " + inputData[i].ToString() + "\r\n"
                                + "EPS: " + error + "\r\n"
                                + "YE: " + expectedResult[i] + "\r\n"
                                + "YF: " + validResult[i] + "\r\n";
                if (expectedResult[i][0] == 'S' && validResult[i][0] == 'S')
                {
                    double exp = double.Parse(expectedResult[i].Split()[2].Replace('.', ','));
                    double valid = double.Parse(validResult[i].Split()[2].Replace('.', ','));
                    double diff = Math.Round(Math.Abs(exp - valid), 3);
                    report += "|SYE - SYF| = " + diff;
                    if (diff > error)
                        report += " > EPS\r\n!!NOT PASSED";
                    else
                        report += " <= EPS\r\nPASSED";
                }
                else
                {
                    if (expectedResult[i] == validResult[i])
                        report += "PASSED";
                    else report += "!!NOT PASSED";
                }
                report += "\r\n\r\n";
            }
            return report;
        }
    }
}
