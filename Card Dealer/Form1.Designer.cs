namespace Card_Dealer
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
            this.dealLabel = new System.Windows.Forms.Label();
            this.numCardsTextBox = new System.Windows.Forms.TextBox();
            this.dealButton = new System.Windows.Forms.Button();
            this.dealtCardsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.cardsLeftLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dealLabel
            // 
            this.dealLabel.AutoSize = true;
            this.dealLabel.Location = new System.Drawing.Point(43, 43);
            this.dealLabel.Name = "dealLabel";
            this.dealLabel.Size = new System.Drawing.Size(168, 17);
            this.dealLabel.TabIndex = 0;
            this.dealLabel.Text = "Number of Cards to Deal:";
            // 
            // numCardsTextBox
            // 
            this.numCardsTextBox.Location = new System.Drawing.Point(226, 40);
            this.numCardsTextBox.Name = "numCardsTextBox";
            this.numCardsTextBox.Size = new System.Drawing.Size(100, 22);
            this.numCardsTextBox.TabIndex = 1;
            // 
            // dealButton
            // 
            this.dealButton.Location = new System.Drawing.Point(133, 81);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(140, 37);
            this.dealButton.TabIndex = 2;
            this.dealButton.Text = "Deal Cards";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.DealButton_Click_1);
            // 
            // dealtCardsListBox
            // 
            this.dealtCardsListBox.FormattingEnabled = true;
            this.dealtCardsListBox.ItemHeight = 16;
            this.dealtCardsListBox.Location = new System.Drawing.Point(36, 155);
            this.dealtCardsListBox.Name = "dealtCardsListBox";
            this.dealtCardsListBox.Size = new System.Drawing.Size(313, 164);
            this.dealtCardsListBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Value of Hand:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cards Left in Deck:";
            // 
            // valueLabel
            // 
            this.valueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valueLabel.Location = new System.Drawing.Point(226, 349);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(100, 23);
            this.valueLabel.TabIndex = 6;
            // 
            // cardsLeftLabel
            // 
            this.cardsLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardsLeftLabel.Location = new System.Drawing.Point(226, 387);
            this.cardsLeftLabel.Name = "cardsLeftLabel";
            this.cardsLeftLabel.Size = new System.Drawing.Size(100, 23);
            this.cardsLeftLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 450);
            this.Controls.Add(this.cardsLeftLabel);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dealtCardsListBox);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.numCardsTextBox);
            this.Controls.Add(this.dealLabel);
            this.Name = "Form1";
            this.Text = "Card Dealer";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dealLabel;
        private System.Windows.Forms.TextBox numCardsTextBox;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.ListBox dealtCardsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label cardsLeftLabel;
    }
}

