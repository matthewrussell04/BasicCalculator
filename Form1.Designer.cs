namespace BasicCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.calcDisplay = new System.Windows.Forms.Label();
            this.one = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.historyDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calcDisplay
            // 
            this.calcDisplay.BackColor = System.Drawing.Color.White;
            this.calcDisplay.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.calcDisplay.Location = new System.Drawing.Point(12, 39);
            this.calcDisplay.Name = "calcDisplay";
            this.calcDisplay.Size = new System.Drawing.Size(366, 65);
            this.calcDisplay.TabIndex = 0;
            this.calcDisplay.Text = "Welcome";
            this.calcDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(58, 166);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(62, 54);
            this.one.TabIndex = 1;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.five.Location = new System.Drawing.Point(126, 226);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(62, 54);
            this.five.TabIndex = 2;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.two.Location = new System.Drawing.Point(126, 166);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(62, 54);
            this.two.TabIndex = 3;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.three.Location = new System.Drawing.Point(194, 166);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(62, 54);
            this.three.TabIndex = 4;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.six.Location = new System.Drawing.Point(194, 226);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(62, 54);
            this.six.TabIndex = 5;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.nine.Location = new System.Drawing.Point(194, 286);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(62, 54);
            this.nine.TabIndex = 6;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.eight.Location = new System.Drawing.Point(126, 286);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(62, 54);
            this.eight.TabIndex = 7;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.seven.Location = new System.Drawing.Point(58, 286);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(62, 54);
            this.seven.TabIndex = 8;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.four.Location = new System.Drawing.Point(58, 226);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(62, 54);
            this.four.TabIndex = 9;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.add.Location = new System.Drawing.Point(294, 166);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(36, 35);
            this.add.TabIndex = 10;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // equals
            // 
            this.equals.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.equals.Location = new System.Drawing.Point(294, 348);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(36, 35);
            this.equals.TabIndex = 11;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.divide.Location = new System.Drawing.Point(294, 289);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(36, 35);
            this.divide.TabIndex = 12;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.multiply.Location = new System.Drawing.Point(294, 248);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(36, 35);
            this.multiply.TabIndex = 13;
            this.multiply.Text = "X";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // subtract
            // 
            this.subtract.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.subtract.Location = new System.Drawing.Point(294, 207);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(36, 35);
            this.subtract.TabIndex = 14;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.clear.Location = new System.Drawing.Point(294, 125);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(36, 35);
            this.clear.TabIndex = 15;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.zero.Location = new System.Drawing.Point(126, 346);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(62, 54);
            this.zero.TabIndex = 16;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // historyDisplay
            // 
            this.historyDisplay.BackColor = System.Drawing.Color.White;
            this.historyDisplay.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyDisplay.Location = new System.Drawing.Point(12, 15);
            this.historyDisplay.Name = "historyDisplay";
            this.historyDisplay.Size = new System.Drawing.Size(366, 24);
            this.historyDisplay.TabIndex = 17;
            // 
            // Form1
            // 
            this.AcceptButton = this.equals;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(390, 459);
            this.Controls.Add(this.historyDisplay);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.add);
            this.Controls.Add(this.four);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.six);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.five);
            this.Controls.Add(this.one);
            this.Controls.Add(this.calcDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label calcDisplay;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Label historyDisplay;
    }
}

