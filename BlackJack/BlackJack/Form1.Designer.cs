namespace BlackJack
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
            this.dealButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hitButton = new System.Windows.Forms.Button();
            this.bet500Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.playerCashLabel = new System.Windows.Forms.Label();
            this.betCashLabel = new System.Windows.Forms.Label();
            this.doubleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dealButton
            // 
            this.dealButton.Location = new System.Drawing.Point(171, 135);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(146, 23);
            this.dealButton.TabIndex = 0;
            this.dealButton.Text = "Deal";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // standButton
            // 
            this.standButton.Location = new System.Drawing.Point(652, 135);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(144, 23);
            this.standButton.TabIndex = 2;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PlayerHandValue: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(649, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "DealerHandValue: ";
            // 
            // hitButton
            // 
            this.hitButton.Location = new System.Drawing.Point(379, 134);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(136, 23);
            this.hitButton.TabIndex = 5;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // bet500Button
            // 
            this.bet500Button.Location = new System.Drawing.Point(171, 265);
            this.bet500Button.Name = "bet500Button";
            this.bet500Button.Size = new System.Drawing.Size(175, 23);
            this.bet500Button.TabIndex = 6;
            this.bet500Button.Text = "Bet 500";
            this.bet500Button.UseVisualStyleBackColor = true;
            this.bet500Button.Click += new System.EventHandler(this.bet500Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Player Hand:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(652, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dealer Hand:";
            // 
            // playerCashLabel
            // 
            this.playerCashLabel.AutoSize = true;
            this.playerCashLabel.Location = new System.Drawing.Point(13, 13);
            this.playerCashLabel.Name = "playerCashLabel";
            this.playerCashLabel.Size = new System.Drawing.Size(69, 13);
            this.playerCashLabel.TabIndex = 9;
            this.playerCashLabel.Text = "Player Cash: ";
            // 
            // betCashLabel
            // 
            this.betCashLabel.AutoSize = true;
            this.betCashLabel.Location = new System.Drawing.Point(16, 41);
            this.betCashLabel.Name = "betCashLabel";
            this.betCashLabel.Size = new System.Drawing.Size(29, 13);
            this.betCashLabel.TabIndex = 10;
            this.betCashLabel.Text = "Bet: ";
            // 
            // doubleButton
            // 
            this.doubleButton.Location = new System.Drawing.Point(379, 265);
            this.doubleButton.Name = "doubleButton";
            this.doubleButton.Size = new System.Drawing.Size(136, 23);
            this.doubleButton.TabIndex = 11;
            this.doubleButton.Text = "Double";
            this.doubleButton.UseVisualStyleBackColor = true;
            this.doubleButton.Click += new System.EventHandler(this.doubleButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 461);
            this.Controls.Add(this.doubleButton);
            this.Controls.Add(this.betCashLabel);
            this.Controls.Add(this.playerCashLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bet500Button);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.dealButton);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button bet500Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label playerCashLabel;
        private System.Windows.Forms.Label betCashLabel;
        private System.Windows.Forms.Button doubleButton;
    }
}

