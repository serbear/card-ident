using System.Drawing;
using System.Windows.Forms;

namespace card_ident
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbOne = new System.Windows.Forms.PictureBox();
            this.pbTwo = new System.Windows.Forms.PictureBox();
            this.pbThree = new System.Windows.Forms.PictureBox();
            this.pbFour = new System.Windows.Forms.PictureBox();
            this.pbFive = new System.Windows.Forms.PictureBox();
            this.lblTaskMessage = new System.Windows.Forms.Label();
            this.flpFiveCards = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCardName = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFive)).BeginInit();
            this.flpFiveCards.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbOne
            // 
            this.pbOne.Location = new System.Drawing.Point(8, 8);
            this.pbOne.Margin = new System.Windows.Forms.Padding(8);
            this.pbOne.Name = "pbOne";
            this.pbOne.Size = new System.Drawing.Size(44, 50);
            this.pbOne.TabIndex = 2;
            this.pbOne.TabStop = false;
            // 
            // pbTwo
            // 
            this.pbTwo.Location = new System.Drawing.Point(68, 8);
            this.pbTwo.Margin = new System.Windows.Forms.Padding(8);
            this.pbTwo.Name = "pbTwo";
            this.pbTwo.Size = new System.Drawing.Size(53, 50);
            this.pbTwo.TabIndex = 3;
            this.pbTwo.TabStop = false;
            // 
            // pbThree
            // 
            this.pbThree.Location = new System.Drawing.Point(137, 8);
            this.pbThree.Margin = new System.Windows.Forms.Padding(8);
            this.pbThree.Name = "pbThree";
            this.pbThree.Size = new System.Drawing.Size(53, 50);
            this.pbThree.TabIndex = 4;
            this.pbThree.TabStop = false;
            // 
            // pbFour
            // 
            this.pbFour.Location = new System.Drawing.Point(206, 8);
            this.pbFour.Margin = new System.Windows.Forms.Padding(8);
            this.pbFour.Name = "pbFour";
            this.pbFour.Size = new System.Drawing.Size(53, 50);
            this.pbFour.TabIndex = 5;
            this.pbFour.TabStop = false;
            // 
            // pbFive
            // 
            this.pbFive.Location = new System.Drawing.Point(275, 8);
            this.pbFive.Margin = new System.Windows.Forms.Padding(8);
            this.pbFive.Name = "pbFive";
            this.pbFive.Size = new System.Drawing.Size(53, 50);
            this.pbFive.TabIndex = 6;
            this.pbFive.TabStop = false;
            // 
            // lblTaskMessage
            // 
            this.lblTaskMessage.Location = new System.Drawing.Point(3, 0);
            this.lblTaskMessage.Name = "lblTaskMessage";
            this.lblTaskMessage.Padding = new System.Windows.Forms.Padding(0, 16, 0, 16);
            this.lblTaskMessage.Size = new System.Drawing.Size(115, 45);
            this.lblTaskMessage.TabIndex = 8;
            this.lblTaskMessage.Text = "Click me to identify me!";
            this.lblTaskMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpFiveCards
            // 
            this.flpFiveCards.AutoSize = true;
            this.flpFiveCards.Controls.Add(this.pbOne);
            this.flpFiveCards.Controls.Add(this.pbTwo);
            this.flpFiveCards.Controls.Add(this.pbThree);
            this.flpFiveCards.Controls.Add(this.pbFour);
            this.flpFiveCards.Controls.Add(this.pbFive);
            this.flpFiveCards.Location = new System.Drawing.Point(0, 45);
            this.flpFiveCards.Margin = new System.Windows.Forms.Padding(0);
            this.flpFiveCards.Name = "flpFiveCards";
            this.flpFiveCards.Size = new System.Drawing.Size(336, 66);
            this.flpFiveCards.TabIndex = 9;
            // 
            // pnlButtons
            // 
            this.pnlButtons.AutoSize = true;
            this.pnlButtons.Controls.Add(this.btnShuffle);
            this.pnlButtons.Controls.Add(this.btnExit);
            this.pnlButtons.Location = new System.Drawing.Point(3, 159);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(162, 47);
            this.pnlButtons.TabIndex = 13;
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(3, 3);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(75, 41);
            this.btnShuffle.TabIndex = 1;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(84, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 41);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 556);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(791, 0);
            this.panel3.TabIndex = 12;
            // 
            // lblCardName
            // 
            this.lblCardName.Location = new System.Drawing.Point(3, 111);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Padding = new System.Windows.Forms.Padding(16);
            this.lblCardName.Size = new System.Drawing.Size(101, 45);
            this.lblCardName.TabIndex = 11;
            this.lblCardName.Text = "My name is...";
            this.lblCardName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblTaskMessage);
            this.flowLayoutPanel1.Controls.Add(this.flpFiveCards);
            this.flowLayoutPanel1.Controls.Add(this.lblCardName);
            this.flowLayoutPanel1.Controls.Add(this.pnlButtons);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(791, 556);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 556);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFive)).EndInit();
            this.flpFiveCards.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

        private System.Windows.Forms.Panel pnlButtons;

        #endregion
        private System.Windows.Forms.PictureBox pbOne;
        private System.Windows.Forms.PictureBox pbTwo;
        private System.Windows.Forms.PictureBox pbThree;
        private System.Windows.Forms.PictureBox pbFour;
        private System.Windows.Forms.PictureBox pbFive;
        private System.Windows.Forms.Label lblTaskMessage;
        private System.Windows.Forms.FlowLayoutPanel flpFiveCards;
        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShuffle;
    }
}