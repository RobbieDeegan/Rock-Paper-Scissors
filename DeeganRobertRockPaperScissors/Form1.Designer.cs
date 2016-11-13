namespace DeeganRobertRockPaperScissors
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
            this.buttonScissors = new System.Windows.Forms.Button();
            this.buttonPaper = new System.Windows.Forms.Button();
            this.buttonRock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playerChoiceTextBox = new System.Windows.Forms.Label();
            this.computerChoiceTextBox = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.computerScoreLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.drawLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonScissors
            // 
            this.buttonScissors.BackgroundImage = global::DeeganRobertRockPaperScissors.Properties.Resources.scissors;
            this.buttonScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonScissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScissors.Location = new System.Drawing.Point(549, 286);
            this.buttonScissors.Name = "buttonScissors";
            this.buttonScissors.Size = new System.Drawing.Size(181, 110);
            this.buttonScissors.TabIndex = 2;
            this.buttonScissors.Text = "Scissors";
            this.buttonScissors.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonScissors.UseVisualStyleBackColor = true;
            this.buttonScissors.Click += new System.EventHandler(this.buttonScissors_Click);
            // 
            // buttonPaper
            // 
            this.buttonPaper.BackgroundImage = global::DeeganRobertRockPaperScissors.Properties.Resources.paper;
            this.buttonPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPaper.Location = new System.Drawing.Point(308, 286);
            this.buttonPaper.Name = "buttonPaper";
            this.buttonPaper.Size = new System.Drawing.Size(181, 110);
            this.buttonPaper.TabIndex = 1;
            this.buttonPaper.Text = "Paper";
            this.buttonPaper.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonPaper.UseVisualStyleBackColor = true;
            this.buttonPaper.Click += new System.EventHandler(this.buttonPaper_Click);
            // 
            // buttonRock
            // 
            this.buttonRock.BackgroundImage = global::DeeganRobertRockPaperScissors.Properties.Resources.rock;
            this.buttonRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRock.Location = new System.Drawing.Point(73, 286);
            this.buttonRock.Name = "buttonRock";
            this.buttonRock.Size = new System.Drawing.Size(181, 110);
            this.buttonRock.TabIndex = 0;
            this.buttonRock.Text = "Rock";
            this.buttonRock.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonRock.UseMnemonic = false;
            this.buttonRock.UseVisualStyleBackColor = true;
            this.buttonRock.Click += new System.EventHandler(this.buttonRock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(433, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Player Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(433, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Computer Score";
            // 
            // playerChoiceTextBox
            // 
            this.playerChoiceTextBox.AutoSize = true;
            this.playerChoiceTextBox.BackColor = System.Drawing.Color.Transparent;
            this.playerChoiceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerChoiceTextBox.ForeColor = System.Drawing.Color.White;
            this.playerChoiceTextBox.Location = new System.Drawing.Point(68, 84);
            this.playerChoiceTextBox.Name = "playerChoiceTextBox";
            this.playerChoiceTextBox.Size = new System.Drawing.Size(159, 25);
            this.playerChoiceTextBox.TabIndex = 9;
            this.playerChoiceTextBox.Text = "Player Choice";
            // 
            // computerChoiceTextBox
            // 
            this.computerChoiceTextBox.AutoSize = true;
            this.computerChoiceTextBox.BackColor = System.Drawing.Color.Transparent;
            this.computerChoiceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerChoiceTextBox.ForeColor = System.Drawing.Color.White;
            this.computerChoiceTextBox.Location = new System.Drawing.Point(68, 171);
            this.computerChoiceTextBox.Name = "computerChoiceTextBox";
            this.computerChoiceTextBox.Size = new System.Drawing.Size(193, 25);
            this.computerChoiceTextBox.TabIndex = 10;
            this.computerChoiceTextBox.Text = "Computer Choice";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(714, 411);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.AutoSize = true;
            this.playerScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScoreLabel.Location = new System.Drawing.Point(654, 33);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(25, 25);
            this.playerScoreLabel.TabIndex = 12;
            this.playerScoreLabel.Text = "0";
            // 
            // computerScoreLabel
            // 
            this.computerScoreLabel.AutoSize = true;
            this.computerScoreLabel.BackColor = System.Drawing.Color.White;
            this.computerScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerScoreLabel.Location = new System.Drawing.Point(654, 122);
            this.computerScoreLabel.Name = "computerScoreLabel";
            this.computerScoreLabel.Size = new System.Drawing.Size(25, 25);
            this.computerScoreLabel.TabIndex = 13;
            this.computerScoreLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(433, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Draw Count";
            // 
            // drawLabel
            // 
            this.drawLabel.AutoSize = true;
            this.drawLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawLabel.Location = new System.Drawing.Point(654, 205);
            this.drawLabel.Name = "drawLabel";
            this.drawLabel.Size = new System.Drawing.Size(25, 25);
            this.drawLabel.TabIndex = 15;
            this.drawLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeeganRobertRockPaperScissors.Properties.Resources.fight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 446);
            this.Controls.Add(this.drawLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.computerScoreLabel);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.computerChoiceTextBox);
            this.Controls.Add(this.playerChoiceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonScissors);
            this.Controls.Add(this.buttonPaper);
            this.Controls.Add(this.buttonRock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPaper;
        private System.Windows.Forms.Button buttonScissors;
        private System.Windows.Forms.Button buttonRock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label playerChoiceTextBox;
        private System.Windows.Forms.Label computerChoiceTextBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.Label computerScoreLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label drawLabel;
    }
}

