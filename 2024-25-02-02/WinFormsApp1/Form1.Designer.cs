﻿namespace WinFormsApp1
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
            LaunchFizzBuzz = new Button();
            SecretNumberButton = new Button();
            DigitCounterButton = new Button();
            EvenOddButton = new Button();
            EnumButton = new Button();
            CreateWarriorbutton = new Button();
            NewBookFormButton = new Button();
            SuspendLayout();
            // 
            // LaunchFizzBuzz
            // 
            LaunchFizzBuzz.Location = new Point(54, 47);
            LaunchFizzBuzz.Margin = new Padding(4, 5, 4, 5);
            LaunchFizzBuzz.Name = "LaunchFizzBuzz";
            LaunchFizzBuzz.Size = new Size(267, 57);
            LaunchFizzBuzz.TabIndex = 0;
            LaunchFizzBuzz.Text = "Launch FizzBuzz";
            LaunchFizzBuzz.UseVisualStyleBackColor = true;
            LaunchFizzBuzz.Click += button1_Click;
            // 
            // SecretNumberButton
            // 
            SecretNumberButton.Location = new Point(54, 122);
            SecretNumberButton.Margin = new Padding(4, 5, 4, 5);
            SecretNumberButton.Name = "SecretNumberButton";
            SecretNumberButton.Size = new Size(267, 57);
            SecretNumberButton.TabIndex = 1;
            SecretNumberButton.Text = "LaunchSecretNumber";
            SecretNumberButton.UseVisualStyleBackColor = true;
            SecretNumberButton.Click += button2_Click;
            // 
            // DigitCounterButton
            // 
            DigitCounterButton.Location = new Point(54, 197);
            DigitCounterButton.Margin = new Padding(4, 5, 4, 5);
            DigitCounterButton.Name = "DigitCounterButton";
            DigitCounterButton.Size = new Size(267, 57);
            DigitCounterButton.TabIndex = 2;
            DigitCounterButton.Text = "LaunchDigitCounter";
            DigitCounterButton.UseVisualStyleBackColor = true;
            DigitCounterButton.Click += DigitCounterButton_Click;
            // 
            // EvenOddButton
            // 
            EvenOddButton.Location = new Point(54, 272);
            EvenOddButton.Margin = new Padding(4, 5, 4, 5);
            EvenOddButton.Name = "EvenOddButton";
            EvenOddButton.Size = new Size(267, 57);
            EvenOddButton.TabIndex = 3;
            EvenOddButton.Text = "Launch Even Odd";
            EvenOddButton.UseVisualStyleBackColor = true;
            EvenOddButton.Click += EvenOddButton_Click;
            // 
            // EnumButton
            // 
            EnumButton.Location = new Point(54, 349);
            EnumButton.Margin = new Padding(4, 5, 4, 5);
            EnumButton.Name = "EnumButton";
            EnumButton.Size = new Size(267, 57);
            EnumButton.TabIndex = 4;
            EnumButton.Text = "Show Enum";
            EnumButton.UseVisualStyleBackColor = true;
            EnumButton.Click += EnumButton_Click;
            // 
            // CreateWarriorbutton
            // 
            CreateWarriorbutton.Location = new Point(54, 431);
            CreateWarriorbutton.Margin = new Padding(4, 5, 4, 5);
            CreateWarriorbutton.Name = "CreateWarriorbutton";
            CreateWarriorbutton.Size = new Size(267, 57);
            CreateWarriorbutton.TabIndex = 5;
            CreateWarriorbutton.Text = "CreateWarrior";
            CreateWarriorbutton.UseVisualStyleBackColor = true;
            CreateWarriorbutton.Click += CreateWarriorbutton_Click;
            // 
            // NewBookFormButton
            // 
            NewBookFormButton.Location = new Point(54, 508);
            NewBookFormButton.Margin = new Padding(4, 5, 4, 5);
            NewBookFormButton.Name = "NewBookFormButton";
            NewBookFormButton.Size = new Size(267, 57);
            NewBookFormButton.TabIndex = 6;
            NewBookFormButton.Text = "Book";
            NewBookFormButton.UseVisualStyleBackColor = true;
            NewBookFormButton.Click += NewBookFormButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 595);
            Controls.Add(NewBookFormButton);
            Controls.Add(CreateWarriorbutton);
            Controls.Add(EnumButton);
            Controls.Add(EvenOddButton);
            Controls.Add(DigitCounterButton);
            Controls.Add(SecretNumberButton);
            Controls.Add(LaunchFizzBuzz);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button LaunchFizzBuzz;
        private Button SecretNumberButton;
        private Button DigitCounterButton;
        private Button EvenOddButton;
        private Button EnumButton;
        private Button CreateWarriorbutton;
        private Button NewBookFormButton;
    }
}
