namespace GuessTheNumber
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
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.guessTextBox = new System.Windows.Forms.TextBox();
            this.newGameButton = new System.Windows.Forms.Button();
            this.instructionsLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(43, 23);
            this.instructionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(257, 16);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "I have a number between 1 and 1000";
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.Location = new System.Drawing.Point(144, 115);
            this.feedbackLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(0, 16);
            this.feedbackLabel.TabIndex = 1;
            // 
            // guessTextBox
            // 
            this.guessTextBox.Location = new System.Drawing.Point(124, 89);
            this.guessTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.guessTextBox.Name = "guessTextBox";
            this.guessTextBox.Size = new System.Drawing.Size(133, 22);
            this.guessTextBox.TabIndex = 2;
            this.guessTextBox.TextChanged += new System.EventHandler(this.guessTextBox_TextChanged);
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(111, 166);
            this.newGameButton.Margin = new System.Windows.Forms.Padding(4);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(156, 36);
            this.newGameButton.TabIndex = 3;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // instructionsLabel1
            // 
            this.instructionsLabel1.AutoSize = true;
            this.instructionsLabel1.Location = new System.Drawing.Point(12, 48);
            this.instructionsLabel1.Name = "instructionsLabel1";
            this.instructionsLabel1.Size = new System.Drawing.Size(370, 16);
            this.instructionsLabel1.TabIndex = 0;
            this.instructionsLabel1.Text = "can you guess my number? Please enter your guess:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 240);
            this.Controls.Add(this.instructionsLabel1);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.guessTextBox);
            this.Controls.Add(this.feedbackLabel);
            this.Controls.Add(this.instructionsLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.TextBox guessTextBox;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Label instructionsLabel1;
    }
}

