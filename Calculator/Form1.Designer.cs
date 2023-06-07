namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            acButton = new Button();
            number1 = new Button();
            number2 = new Button();
            number4 = new Button();
            number6 = new Button();
            number5 = new Button();
            number3 = new Button();
            ceButton = new Button();
            number7 = new Button();
            number8 = new Button();
            number9 = new Button();
            posnegButton = new Button();
            number0 = new Button();
            dotButton = new Button();
            clearOneDigitButton = new Button();
            percButton = new Button();
            reverseButton = new Button();
            exponent2Button = new Button();
            divisionButton = new Button();
            squareRootButton = new Button();
            multiplationButton = new Button();
            plusButton = new Button();
            minusButton = new Button();
            equalButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // acButton
            // 
            acButton.Location = new Point(184, 117);
            acButton.Name = "acButton";
            acButton.Size = new Size(80, 80);
            acButton.TabIndex = 1;
            acButton.Text = "C";
            acButton.UseVisualStyleBackColor = true;
            acButton.Click += btn_clear_Click;
            // 
            // number1
            // 
            number1.Location = new Point(12, 461);
            number1.Name = "number1";
            number1.Size = new Size(80, 80);
            number1.TabIndex = 2;
            number1.Text = "1";
            number1.UseVisualStyleBackColor = true;
            number1.Click += btnNumber_Click;
            // 
            // number2
            // 
            number2.Location = new Point(98, 461);
            number2.Name = "number2";
            number2.Size = new Size(80, 80);
            number2.TabIndex = 3;
            number2.Text = "2";
            number2.UseVisualStyleBackColor = true;
            number2.Click += btnNumber_Click;
            // 
            // number4
            // 
            number4.Location = new Point(12, 375);
            number4.Name = "number4";
            number4.Size = new Size(80, 80);
            number4.TabIndex = 4;
            number4.Text = "4";
            number4.UseVisualStyleBackColor = true;
            number4.Click += btnNumber_Click;
            // 
            // number6
            // 
            number6.Location = new Point(184, 375);
            number6.Name = "number6";
            number6.Size = new Size(80, 80);
            number6.TabIndex = 5;
            number6.Text = "6";
            number6.UseVisualStyleBackColor = true;
            number6.Click += btnNumber_Click;
            // 
            // number5
            // 
            number5.Location = new Point(98, 375);
            number5.Name = "number5";
            number5.Size = new Size(80, 80);
            number5.TabIndex = 6;
            number5.Text = "5";
            number5.UseVisualStyleBackColor = true;
            number5.Click += btnNumber_Click;
            // 
            // number3
            // 
            number3.Location = new Point(184, 461);
            number3.Name = "number3";
            number3.Size = new Size(80, 80);
            number3.TabIndex = 7;
            number3.Text = "3";
            number3.UseVisualStyleBackColor = true;
            number3.Click += btnNumber_Click;
            // 
            // ceButton
            // 
            ceButton.Location = new Point(98, 117);
            ceButton.Name = "ceButton";
            ceButton.Size = new Size(80, 80);
            ceButton.TabIndex = 8;
            ceButton.Text = "CE";
            ceButton.UseVisualStyleBackColor = true;
            // 
            // number7
            // 
            number7.Location = new Point(12, 289);
            number7.Name = "number7";
            number7.Size = new Size(80, 80);
            number7.TabIndex = 9;
            number7.Text = "7";
            number7.UseVisualStyleBackColor = true;
            number7.Click += btnNumber_Click;
            // 
            // number8
            // 
            number8.Location = new Point(98, 289);
            number8.Name = "number8";
            number8.Size = new Size(80, 80);
            number8.TabIndex = 10;
            number8.Text = "8";
            number8.UseVisualStyleBackColor = true;
            number8.Click += btnNumber_Click;
            // 
            // number9
            // 
            number9.Location = new Point(184, 289);
            number9.Name = "number9";
            number9.Size = new Size(80, 80);
            number9.TabIndex = 11;
            number9.Text = "9";
            number9.UseVisualStyleBackColor = true;
            number9.Click += btnNumber_Click;
            // 
            // posnegButton
            // 
            posnegButton.Location = new Point(12, 547);
            posnegButton.Name = "posnegButton";
            posnegButton.Size = new Size(80, 80);
            posnegButton.TabIndex = 12;
            posnegButton.Text = "+/-";
            posnegButton.UseVisualStyleBackColor = true;
            posnegButton.Click += btn_plus_Minus_Click;
            // 
            // number0
            // 
            number0.Location = new Point(98, 547);
            number0.Name = "number0";
            number0.Size = new Size(80, 80);
            number0.TabIndex = 14;
            number0.Text = "0";
            number0.UseVisualStyleBackColor = true;
            number0.Click += btnNumber_Click;
            // 
            // dotButton
            // 
            dotButton.Location = new Point(184, 547);
            dotButton.Name = "dotButton";
            dotButton.Size = new Size(80, 80);
            dotButton.TabIndex = 15;
            dotButton.Text = ".";
            dotButton.UseVisualStyleBackColor = true;
            dotButton.Click += btn_point_Click;
            // 
            // clearOneDigitButton
            // 
            clearOneDigitButton.BackColor = Color.Transparent;
            clearOneDigitButton.BackgroundImage = (Image)resources.GetObject("clearOneDigitButton.BackgroundImage");
            clearOneDigitButton.BackgroundImageLayout = ImageLayout.Center;
            clearOneDigitButton.Location = new Point(270, 117);
            clearOneDigitButton.Name = "clearOneDigitButton";
            clearOneDigitButton.Size = new Size(80, 80);
            clearOneDigitButton.TabIndex = 16;
            clearOneDigitButton.UseVisualStyleBackColor = false;
            clearOneDigitButton.Click += btn_BackSpace_Click;
            // 
            // percButton
            // 
            percButton.Location = new Point(12, 117);
            percButton.Name = "percButton";
            percButton.Size = new Size(80, 80);
            percButton.TabIndex = 17;
            percButton.Text = "%";
            percButton.UseVisualStyleBackColor = true;
            percButton.Click += btn_operator_Click;
            // 
            // reverseButton
            // 
            reverseButton.Location = new Point(12, 203);
            reverseButton.Name = "reverseButton";
            reverseButton.Size = new Size(80, 80);
            reverseButton.TabIndex = 18;
            reverseButton.Text = "1/x";
            reverseButton.UseVisualStyleBackColor = true;
            // 
            // exponent2Button
            // 
            exponent2Button.BackgroundImageLayout = ImageLayout.Zoom;
            exponent2Button.Location = new Point(98, 203);
            exponent2Button.Name = "exponent2Button";
            exponent2Button.Size = new Size(80, 80);
            exponent2Button.TabIndex = 19;
            exponent2Button.Text = "x^2";
            exponent2Button.UseVisualStyleBackColor = true;
            // 
            // divisionButton
            // 
            divisionButton.Location = new Point(270, 203);
            divisionButton.Name = "divisionButton";
            divisionButton.Size = new Size(80, 80);
            divisionButton.TabIndex = 20;
            divisionButton.Text = "÷";
            divisionButton.UseVisualStyleBackColor = true;
            divisionButton.Click += btn_operator_Click;
            // 
            // squareRootButton
            // 
            squareRootButton.Location = new Point(184, 203);
            squareRootButton.Name = "squareRootButton";
            squareRootButton.Size = new Size(80, 80);
            squareRootButton.TabIndex = 21;
            squareRootButton.Text = "√x";
            squareRootButton.UseVisualStyleBackColor = true;
            // 
            // multiplationButton
            // 
            multiplationButton.Location = new Point(270, 292);
            multiplationButton.Name = "multiplationButton";
            multiplationButton.Size = new Size(80, 80);
            multiplationButton.TabIndex = 22;
            multiplationButton.Text = "X";
            multiplationButton.UseVisualStyleBackColor = true;
            multiplationButton.Click += btn_operator_Click;
            // 
            // plusButton
            // 
            plusButton.Location = new Point(270, 461);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(80, 80);
            plusButton.TabIndex = 23;
            plusButton.Text = "+";
            plusButton.UseVisualStyleBackColor = true;
            plusButton.Click += btn_operator_Click;
            // 
            // minusButton
            // 
            minusButton.Location = new Point(270, 375);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(80, 80);
            minusButton.TabIndex = 24;
            minusButton.Text = "-";
            minusButton.UseVisualStyleBackColor = true;
            minusButton.Click += btn_operator_Click;
            // 
            // equalButton
            // 
            equalButton.BackColor = Color.Teal;
            equalButton.Location = new Point(270, 547);
            equalButton.Name = "equalButton";
            equalButton.Size = new Size(80, 80);
            equalButton.TabIndex = 25;
            equalButton.Text = "=";
            equalButton.UseVisualStyleBackColor = false;
            equalButton.Click += btn_equal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 47);
            label1.Name = "label1";
            label1.Size = new Size(45, 54);
            label1.TabIndex = 26;
            label1.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 633);
            Controls.Add(label1);
            Controls.Add(equalButton);
            Controls.Add(minusButton);
            Controls.Add(plusButton);
            Controls.Add(multiplationButton);
            Controls.Add(squareRootButton);
            Controls.Add(divisionButton);
            Controls.Add(exponent2Button);
            Controls.Add(reverseButton);
            Controls.Add(percButton);
            Controls.Add(clearOneDigitButton);
            Controls.Add(dotButton);
            Controls.Add(number0);
            Controls.Add(posnegButton);
            Controls.Add(number9);
            Controls.Add(number8);
            Controls.Add(number7);
            Controls.Add(ceButton);
            Controls.Add(number3);
            Controls.Add(number5);
            Controls.Add(number6);
            Controls.Add(number4);
            Controls.Add(number2);
            Controls.Add(number1);
            Controls.Add(acButton);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button acButton;
        private Button number1;
        private Button number2;
        private Button number4;
        private Button number6;
        private Button number5;
        private Button number3;
        private Button ceButton;
        private Button number7;
        private Button number8;
        private Button number9;
        private Button posnegButton;
        private Button number0;
        private Button dotButton;
        private Button clearOneDigitButton;
        private Button percButton;
        private Button reverseButton;
        private Button exponent2Button;
        private Button divisionButton;
        private Button squareRootButton;
        private Button multiplationButton;
        private Button plusButton;
        private Button minusButton;
        private Button equalButton;
        private Label label1;
    }
}