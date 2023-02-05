namespace BMI_Calculator
{
    partial class BMICalculatorForm
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
            this.BMICalculatorFormTitleLabel = new System.Windows.Forms.Label();
            this.enterWeightLabel = new System.Windows.Forms.Label();
            this.enterHeightLabel = new System.Windows.Forms.Label();
            this.calculatedBMILabel = new System.Windows.Forms.Label();
            this.interpretedBMILabel = new System.Windows.Forms.Label();
            this.calculateBMIButtion = new System.Windows.Forms.Button();
            this.interpretBMIButton = new System.Windows.Forms.Button();
            this.enteredWeightTextBox = new System.Windows.Forms.TextBox();
            this.enteredHeightTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BMICalculatorFormTitleLabel
            // 
            this.BMICalculatorFormTitleLabel.AutoSize = true;
            this.BMICalculatorFormTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMICalculatorFormTitleLabel.Location = new System.Drawing.Point(25, 50);
            this.BMICalculatorFormTitleLabel.Name = "BMICalculatorFormTitleLabel";
            this.BMICalculatorFormTitleLabel.Size = new System.Drawing.Size(348, 29);
            this.BMICalculatorFormTitleLabel.TabIndex = 0;
            this.BMICalculatorFormTitleLabel.Text = "Welcome to the BMI Calculator!";
            // 
            // enterWeightLabel
            // 
            this.enterWeightLabel.AutoSize = true;
            this.enterWeightLabel.Location = new System.Drawing.Point(25, 100);
            this.enterWeightLabel.Name = "enterWeightLabel";
            this.enterWeightLabel.Size = new System.Drawing.Size(172, 20);
            this.enterWeightLabel.TabIndex = 1;
            this.enterWeightLabel.Text = "Enter your weight in lbs";
            // 
            // enterHeightLabel
            // 
            this.enterHeightLabel.AutoSize = true;
            this.enterHeightLabel.Location = new System.Drawing.Point(26, 150);
            this.enterHeightLabel.Name = "enterHeightLabel";
            this.enterHeightLabel.Size = new System.Drawing.Size(196, 20);
            this.enterHeightLabel.TabIndex = 2;
            this.enterHeightLabel.Text = "Enter your height in inches";
            // 
            // calculatedBMILabel
            // 
            this.calculatedBMILabel.AccessibleDescription = "Displays the calculated BMI";
            this.calculatedBMILabel.AccessibleName = "acc_calculatedBMILabel";
            this.calculatedBMILabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.calculatedBMILabel.Location = new System.Drawing.Point(25, 275);
            this.calculatedBMILabel.Name = "calculatedBMILabel";
            this.calculatedBMILabel.Size = new System.Drawing.Size(350, 50);
            this.calculatedBMILabel.TabIndex = 3;
            this.calculatedBMILabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // interpretedBMILabel
            // 
            this.interpretedBMILabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.interpretedBMILabel.Location = new System.Drawing.Point(25, 425);
            this.interpretedBMILabel.Name = "interpretedBMILabel";
            this.interpretedBMILabel.Size = new System.Drawing.Size(350, 50);
            this.interpretedBMILabel.TabIndex = 4;
            this.interpretedBMILabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.interpretedBMILabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // calculateBMIButtion
            // 
            this.calculateBMIButtion.AccessibleDescription = "Button to calculate BMI";
            this.calculateBMIButtion.AccessibleName = "acc_calculateBMIButton";
            this.calculateBMIButtion.Location = new System.Drawing.Point(30, 200);
            this.calculateBMIButtion.Name = "calculateBMIButtion";
            this.calculateBMIButtion.Size = new System.Drawing.Size(350, 50);
            this.calculateBMIButtion.TabIndex = 5;
            this.calculateBMIButtion.Text = "Calculate BMI";
            this.calculateBMIButtion.UseVisualStyleBackColor = true;
            this.calculateBMIButtion.Click += new System.EventHandler(this.calculateBMIButtion_Click);
            // 
            // interpretBMIButton
            // 
            this.interpretBMIButton.AccessibleDescription = "Button to interpret BMI data";
            this.interpretBMIButton.AccessibleName = "acc_interpretBMIButton";
            this.interpretBMIButton.Location = new System.Drawing.Point(25, 350);
            this.interpretBMIButton.Name = "interpretBMIButton";
            this.interpretBMIButton.Size = new System.Drawing.Size(350, 50);
            this.interpretBMIButton.TabIndex = 6;
            this.interpretBMIButton.Text = "Interpret BMI";
            this.interpretBMIButton.UseVisualStyleBackColor = true;
            this.interpretBMIButton.Click += new System.EventHandler(this.interpretBMIButton_Click);
            // 
            // enteredWeightTextBox
            // 
            this.enteredWeightTextBox.Location = new System.Drawing.Point(273, 97);
            this.enteredWeightTextBox.Name = "enteredWeightTextBox";
            this.enteredWeightTextBox.Size = new System.Drawing.Size(100, 26);
            this.enteredWeightTextBox.TabIndex = 7;
            // 
            // enteredHeightTextBox
            // 
            this.enteredHeightTextBox.Location = new System.Drawing.Point(273, 147);
            this.enteredHeightTextBox.Name = "enteredHeightTextBox";
            this.enteredHeightTextBox.Size = new System.Drawing.Size(100, 26);
            this.enteredHeightTextBox.TabIndex = 8;
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Location = new System.Drawing.Point(177, 491);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(45, 30);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 562);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.enteredHeightTextBox);
            this.Controls.Add(this.enteredWeightTextBox);
            this.Controls.Add(this.interpretBMIButton);
            this.Controls.Add(this.calculateBMIButtion);
            this.Controls.Add(this.interpretedBMILabel);
            this.Controls.Add(this.calculatedBMILabel);
            this.Controls.Add(this.enterHeightLabel);
            this.Controls.Add(this.enterWeightLabel);
            this.Controls.Add(this.BMICalculatorFormTitleLabel);
            this.Name = "BMICalculatorForm";
            this.Text = "BMI Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BMICalculatorFormTitleLabel;
        private System.Windows.Forms.Label enterWeightLabel;
        private System.Windows.Forms.Label enterHeightLabel;
        private System.Windows.Forms.Label calculatedBMILabel;
        private System.Windows.Forms.Label interpretedBMILabel;
        private System.Windows.Forms.Button calculateBMIButtion;
        private System.Windows.Forms.Button interpretBMIButton;
        private System.Windows.Forms.TextBox enteredWeightTextBox;
        private System.Windows.Forms.TextBox enteredHeightTextBox;
        private System.Windows.Forms.Button exitButton;
    }
}

