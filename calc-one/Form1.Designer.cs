namespace calc_one
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
            btnOne = new Button();
            btnTwo = new Button();
            btnThree = new Button();
            btnSix = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnNine = new Button();
            btnEight = new Button();
            btnSeven = new Button();
            btnZero = new Button();
            btnEqual = new Button();
            calculationWindow = new RichTextBox();
            btnSubtract = new Button();
            btnAddition = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            SuspendLayout();
            // 
            // btnOne
            // 
            btnOne.Location = new Point(22, 146);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(71, 50);
            btnOne.TabIndex = 0;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnOne_Click;
            // 
            // btnTwo
            // 
            btnTwo.Location = new Point(121, 146);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(71, 50);
            btnTwo.TabIndex = 1;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            // 
            // btnThree
            // 
            btnThree.Location = new Point(219, 146);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(71, 50);
            btnThree.TabIndex = 2;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            // 
            // btnSix
            // 
            btnSix.Location = new Point(219, 229);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(71, 50);
            btnSix.TabIndex = 5;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            // 
            // btnFive
            // 
            btnFive.Location = new Point(121, 229);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(71, 50);
            btnFive.TabIndex = 4;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            // 
            // btnFour
            // 
            btnFour.Location = new Point(22, 229);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(71, 50);
            btnFour.TabIndex = 3;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            // 
            // btnNine
            // 
            btnNine.Location = new Point(219, 314);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(71, 50);
            btnNine.TabIndex = 8;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            // 
            // btnEight
            // 
            btnEight.Location = new Point(121, 314);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(71, 50);
            btnEight.TabIndex = 7;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            // 
            // btnSeven
            // 
            btnSeven.Location = new Point(22, 314);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(71, 50);
            btnSeven.TabIndex = 6;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(122, 391);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(71, 50);
            btnZero.TabIndex = 9;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(219, 392);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(71, 50);
            btnEqual.TabIndex = 10;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            // 
            // calculationWindow
            // 
            calculationWindow.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calculationWindow.Location = new Point(22, 26);
            calculationWindow.Name = "calculationWindow";
            calculationWindow.ReadOnly = true;
            calculationWindow.RightToLeft = RightToLeft.Yes;
            calculationWindow.Size = new Size(268, 96);
            calculationWindow.TabIndex = 11;
            calculationWindow.Text = "0";
            calculationWindow.TextChanged += calculationWindow_TextChanged;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(21, 370);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(34, 32);
            btnSubtract.TabIndex = 12;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            // 
            // btnAddition
            // 
            btnAddition.Location = new Point(61, 370);
            btnAddition.Name = "btnAddition";
            btnAddition.Size = new Size(34, 32);
            btnAddition.TabIndex = 13;
            btnAddition.Text = "+";
            btnAddition.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(61, 410);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(34, 32);
            btnDivide.TabIndex = 15;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(21, 410);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(34, 32);
            btnMultiply.TabIndex = 14;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 450);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnAddition);
            Controls.Add(btnSubtract);
            Controls.Add(calculationWindow);
            Controls.Add(btnEqual);
            Controls.Add(btnZero);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Calc-One";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOne;
        private Button btnTwo;
        private Button btnThree;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnNine;
        private Button btnEight;
        private Button btnSeven;
        private Button btnZero;
        private Button btnEqual;
        private RichTextBox calculationWindow;
        private Button btnSubtract;
        private Button btnAddition;
        private Button btnDivide;
        private Button btnMultiply;
    }
}
