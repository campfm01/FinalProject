namespace Final_Project_Campfm01
{
    partial class SavingsPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lblSavingsAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnTransfertoChecking = new System.Windows.Forms.Button();
            this.txtUserEntry = new System.Windows.Forms.TextBox();
            this.btnTransfertoInvestments = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(244, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Savings Account";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(482, 201);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(112, 34);
            this.btnWithdraw.TabIndex = 10;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            // 
            // lblSavingsAmount
            // 
            this.lblSavingsAmount.AutoSize = true;
            this.lblSavingsAmount.Location = new System.Drawing.Point(231, 155);
            this.lblSavingsAmount.Name = "lblSavingsAmount";
            this.lblSavingsAmount.Size = new System.Drawing.Size(168, 25);
            this.lblSavingsAmount.TabIndex = 9;
            this.lblSavingsAmount.Text = "Savings Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Savings:";
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(640, 201);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(112, 34);
            this.btnDeposit.TabIndex = 11;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            // 
            // btnTransfertoChecking
            // 
            this.btnTransfertoChecking.Location = new System.Drawing.Point(482, 256);
            this.btnTransfertoChecking.Name = "btnTransfertoChecking";
            this.btnTransfertoChecking.Size = new System.Drawing.Size(270, 36);
            this.btnTransfertoChecking.TabIndex = 12;
            this.btnTransfertoChecking.Text = "Transfer to Checking";
            this.btnTransfertoChecking.UseVisualStyleBackColor = true;
            // 
            // txtUserEntry
            // 
            this.txtUserEntry.Location = new System.Drawing.Point(482, 152);
            this.txtUserEntry.Name = "txtUserEntry";
            this.txtUserEntry.Size = new System.Drawing.Size(270, 31);
            this.txtUserEntry.TabIndex = 13;
            // 
            // btnTransfertoInvestments
            // 
            this.btnTransfertoInvestments.Location = new System.Drawing.Point(482, 313);
            this.btnTransfertoInvestments.Name = "btnTransfertoInvestments";
            this.btnTransfertoInvestments.Size = new System.Drawing.Size(270, 36);
            this.btnTransfertoInvestments.TabIndex = 14;
            this.btnTransfertoInvestments.Text = "Transfer to Investments";
            this.btnTransfertoInvestments.UseVisualStyleBackColor = true;
            // 
            // SavingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 411);
            this.Controls.Add(this.btnTransfertoInvestments);
            this.Controls.Add(this.txtUserEntry);
            this.Controls.Add(this.btnTransfertoChecking);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.lblSavingsAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "SavingsPage";
            this.Text = "Savings Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label lblSavingsAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnTransfertoChecking;
        private System.Windows.Forms.TextBox txtUserEntry;
        private System.Windows.Forms.Button btnTransfertoInvestments;
    }
}