namespace TestingApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputError = new System.Windows.Forms.NumericUpDown();
            this.radioNegative = new System.Windows.Forms.RadioButton();
            this.radioPositive = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.InputTestCaseCount = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxInputCoeff = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputRightBorder = new System.Windows.Forms.NumericUpDown();
            this.inputLeftBorder = new System.Windows.Forms.NumericUpDown();
            this.buttonGenerateTests = new System.Windows.Forms.Button();
            this.buttonSaveResult = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputTestCaseCount)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputRightBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputLeftBorder)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.inputError);
            this.groupBox1.Controls.Add(this.radioNegative);
            this.groupBox1.Controls.Add(this.radioPositive);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.InputTestCaseCount);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки генерации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Допустимая погрешность";
            // 
            // inputError
            // 
            this.inputError.DecimalPlaces = 5;
            this.inputError.Location = new System.Drawing.Point(158, 101);
            this.inputError.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.inputError.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.inputError.Name = "inputError";
            this.inputError.Size = new System.Drawing.Size(99, 20);
            this.inputError.TabIndex = 4;
            this.inputError.Value = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            // 
            // radioNegative
            // 
            this.radioNegative.AutoSize = true;
            this.radioNegative.Location = new System.Drawing.Point(137, 64);
            this.radioNegative.Name = "radioNegative";
            this.radioNegative.Size = new System.Drawing.Size(87, 17);
            this.radioNegative.TabIndex = 3;
            this.radioNegative.TabStop = true;
            this.radioNegative.Text = "Негативный";
            this.radioNegative.UseVisualStyleBackColor = true;
            // 
            // radioPositive
            // 
            this.radioPositive.AutoSize = true;
            this.radioPositive.Checked = true;
            this.radioPositive.Location = new System.Drawing.Point(29, 64);
            this.radioPositive.Name = "radioPositive";
            this.radioPositive.Size = new System.Drawing.Size(88, 17);
            this.radioPositive.TabIndex = 2;
            this.radioPositive.TabStop = true;
            this.radioPositive.Text = "Позитивный";
            this.radioPositive.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество тест-кейсов";
            // 
            // InputTestCaseCount
            // 
            this.InputTestCaseCount.Location = new System.Drawing.Point(158, 30);
            this.InputTestCaseCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.InputTestCaseCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.InputTestCaseCount.Name = "InputTestCaseCount";
            this.InputTestCaseCount.Size = new System.Drawing.Size(99, 20);
            this.InputTestCaseCount.TabIndex = 0;
            this.InputTestCaseCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxInputCoeff);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.inputRightBorder);
            this.groupBox2.Controls.Add(this.inputLeftBorder);
            this.groupBox2.Location = new System.Drawing.Point(12, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 138);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Исходные данные";
            // 
            // textBoxInputCoeff
            // 
            this.textBoxInputCoeff.Location = new System.Drawing.Point(12, 101);
            this.textBoxInputCoeff.Name = "textBoxInputCoeff";
            this.textBoxInputCoeff.Size = new System.Drawing.Size(245, 20);
            this.textBoxInputCoeff.TabIndex = 5;
            this.textBoxInputCoeff.Text = "1 2 3 4 5 6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Коэффициенты полинома (через пробел)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Правая граница";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Левая граница";
            // 
            // inputRightBorder
            // 
            this.inputRightBorder.Location = new System.Drawing.Point(158, 45);
            this.inputRightBorder.Minimum = new decimal(new int[] {
            99,
            0,
            0,
            -2147483648});
            this.inputRightBorder.Name = "inputRightBorder";
            this.inputRightBorder.Size = new System.Drawing.Size(99, 20);
            this.inputRightBorder.TabIndex = 1;
            this.inputRightBorder.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // inputLeftBorder
            // 
            this.inputLeftBorder.Location = new System.Drawing.Point(158, 18);
            this.inputLeftBorder.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.inputLeftBorder.Name = "inputLeftBorder";
            this.inputLeftBorder.Size = new System.Drawing.Size(99, 20);
            this.inputLeftBorder.TabIndex = 0;
            // 
            // buttonGenerateTests
            // 
            this.buttonGenerateTests.Location = new System.Drawing.Point(46, 301);
            this.buttonGenerateTests.Name = "buttonGenerateTests";
            this.buttonGenerateTests.Size = new System.Drawing.Size(190, 30);
            this.buttonGenerateTests.TabIndex = 2;
            this.buttonGenerateTests.Text = "Генерация тест-кейсов";
            this.buttonGenerateTests.UseVisualStyleBackColor = true;
            this.buttonGenerateTests.Click += new System.EventHandler(this.buttonGenerateTests_Click);
            // 
            // buttonSaveResult
            // 
            this.buttonSaveResult.Location = new System.Drawing.Point(46, 337);
            this.buttonSaveResult.Name = "buttonSaveResult";
            this.buttonSaveResult.Size = new System.Drawing.Size(190, 30);
            this.buttonSaveResult.TabIndex = 3;
            this.buttonSaveResult.Text = "Сохранение результатов";
            this.buttonSaveResult.UseVisualStyleBackColor = true;
            this.buttonSaveResult.Click += new System.EventHandler(this.buttonSaveResult_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxOutput);
            this.groupBox3.Location = new System.Drawing.Point(302, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 355);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вывод";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(6, 19);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(300, 330);
            this.textBoxOutput.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 389);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonSaveResult);
            this.Controls.Add(this.buttonGenerateTests);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Автоматизированное тестирование";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputTestCaseCount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputRightBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputLeftBorder)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown inputError;
        private System.Windows.Forms.RadioButton radioNegative;
        private System.Windows.Forms.RadioButton radioPositive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown InputTestCaseCount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxInputCoeff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown inputRightBorder;
        private System.Windows.Forms.NumericUpDown inputLeftBorder;
        private System.Windows.Forms.Button buttonGenerateTests;
        private System.Windows.Forms.Button buttonSaveResult;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxOutput;
    }
}

