namespace bmicsalva
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
            this.Runbutton = new System.Windows.Forms.Button();
            this.BmiCalculator = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.Weight = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.Label();
            this.BmiOutputBox = new System.Windows.Forms.TextBox();
            this.BMI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Runbutton
            // 
            this.Runbutton.Location = new System.Drawing.Point(201, 218);
            this.Runbutton.Name = "Runbutton";
            this.Runbutton.Size = new System.Drawing.Size(111, 33);
            this.Runbutton.TabIndex = 0;
            this.Runbutton.Text = "Run";
            this.Runbutton.UseVisualStyleBackColor = true;
            this.Runbutton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // BmiCalculator
            // 
            this.BmiCalculator.AutoSize = true;
            this.BmiCalculator.Location = new System.Drawing.Point(181, 65);
            this.BmiCalculator.Name = "BmiCalculator";
            this.BmiCalculator.Size = new System.Drawing.Size(154, 25);
            this.BmiCalculator.TabIndex = 1;
            this.BmiCalculator.Text = "BMI CALCULATOR";
            this.BmiCalculator.Click += new System.EventHandler(this.BmiCalculator_);
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WeightTextBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.WeightTextBox.Location = new System.Drawing.Point(201, 118);
            this.WeightTextBox.MaxLength = 3;
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(113, 31);
            this.WeightTextBox.TabIndex = 2;
            this.WeightTextBox.TextChanged += new System.EventHandler(this.WeightTextBox_TextChanged);
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(201, 173);
            this.HeightTextBox.MaxLength = 3;
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(113, 31);
            this.HeightTextBox.TabIndex = 3;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Location = new System.Drawing.Point(97, 127);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(98, 25);
            this.Weight.TabIndex = 4;
            this.Weight.Text = "Weight(kg)";
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Location = new System.Drawing.Point(96, 178);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(99, 25);
            this.Height.TabIndex = 5;
            this.Height.Text = "Height(cm)";
            // 
            // BmiOutputBox
            // 
            this.BmiOutputBox.Location = new System.Drawing.Point(407, 173);
            this.BmiOutputBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BmiOutputBox.Name = "BmiOutputBox";
            this.BmiOutputBox.ReadOnly = true;
            this.BmiOutputBox.Size = new System.Drawing.Size(55, 31);
            this.BmiOutputBox.TabIndex = 6;
            this.BmiOutputBox.TextChanged += new System.EventHandler(this.BmiOutputBox_TextChanged);
            // 
            // BMI
            // 
            this.BMI.AutoSize = true;
            this.BMI.Location = new System.Drawing.Point(359, 178);
            this.BMI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BMI.Name = "BMI";
            this.BMI.Size = new System.Drawing.Size(43, 25);
            this.BMI.TabIndex = 7;
            this.BMI.Text = "BMI";
            this.BMI.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 328);
            this.Controls.Add(this.BMI);
            this.Controls.Add(this.BmiOutputBox);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.BmiCalculator);
            this.Controls.Add(this.Runbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Runbutton;
        private Label BmiCalculator;
        private TextBox WeightTextBox;
        private TextBox HeightTextBox;
        private Label Weight;
        private Label Height;
        private TextBox BmiOutputBox;
        private Label BMI;
    }
}