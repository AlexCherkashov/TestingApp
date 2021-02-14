using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonGenerateTests_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = "";

            int testcaseCount = (int)InputTestCaseCount.Value;
            bool isPositive = radioPositive.Checked;
            double error = (double)inputError.Value;
            double leftBorder = (double)inputLeftBorder.Value;
            double rightBodred = (double)inputRightBorder.Value;
            string coeffString = textBoxInputCoeff.Text;

            if (leftBorder >= rightBodred)
            {
                MessageBox.Show("Левая граница должна быть меньше правой", "Ошибка!");
                return;
            }

            List<double> coeffs = new List<double>();
            try
            {
                foreach (string coeff in coeffString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    coeffs.Add(Convert.ToDouble(coeff));
                }
            }
            catch
            {
                MessageBox.Show("Коэффициенты введены неверно", "Ошибка!");
                return;
            }

            string[] expectedResult = new string[testcaseCount];
            string[] validResult = new string[testcaseCount];

            Data[] inputData = DataGeneration.Run(isPositive, leftBorder, rightBodred, coeffs, testcaseCount);

            for (int i = 0; i < testcaseCount; i++)
            {
                expectedResult[i] = Oracle.GetAnswers(inputData[i]);
                validResult[i] = Starter.Run("Integral3x.exe", inputData[i]);
            }

            textBoxOutput.Text = Comparator.GenerateReport(isPositive, inputData, error, expectedResult, validResult);
        }

        private void buttonSaveResult_Click(object sender, EventArgs e)
        {
            if (textBoxOutput.Text == "")
            {
                MessageBox.Show("А сохранять то нечего");
                return;
            }

            SaveFileDialog SF = new SaveFileDialog();
            SF.Filter = "Text (*.txt) |*.txt";
            if (SF.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(SF.FileName, false, Encoding.Default);
                sw.Write(textBoxOutput.Text);
                sw.Close();
                MessageBox.Show("Данные успешно сохранены");
            }
        }
    }
}
