namespace Final_Project_Campfm01
{
    partial class LandingPage
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblSavingsAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCheckingAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblInvestmentsAmount = new System.Windows.Forms.Label();
            this.btnSavingsEdit = new System.Windows.Forms.Button();
            this.btnCheckingEdit = new System.Windows.Forms.Button();
            this.btnInvestmentsEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(181, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Summary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Savings:";
            // 
            // lblSavingsAmount
            // 
            this.lblSavingsAmount.AutoSize = true;
            this.lblSavingsAmount.Location = new System.Drawing.Point(251, 127);
            this.lblSavingsAmount.Name = "lblSavingsAmount";
            this.lblSavingsAmount.Size = new System.Drawing.Size(168, 25);
            this.lblSavingsAmount.TabIndex = 2;
            this.lblSavingsAmount.Text = "Savings Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Checking:";
            // 
            // lblCheckingAmount
            // 
            this.lblCheckingAmount.AutoSize = true;
            this.lblCheckingAmount.Location = new System.Drawing.Point(251, 186);
            this.lblCheckingAmount.Name = "lblCheckingAmount";
            this.lblCheckingAmount.Size = new System.Drawing.Size(181, 25);
            this.lblCheckingAmount.TabIndex = 4;
            this.lblCheckingAmount.Text = "Checking Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Investments:";
            // 
            // lblInvestmentsAmount
            // 
            this.lblInvestmentsAmount.AutoSize = true;
            this.lblInvestmentsAmount.Location = new System.Drawing.Point(251, 243);
            this.lblInvestmentsAmount.Name = "lblInvestmentsAmount";
            this.lblInvestmentsAmount.Size = new System.Drawing.Size(206, 25);
            this.lblInvestmentsAmount.TabIndex = 6;
            this.lblInvestmentsAmount.Text = "Investments Amount";
            // 
            // btnSavingsEdit
            // 
            this.btnSavingsEdit.Location = new System.Drawing.Point(538, 122);
            this.btnSavingsEdit.Name = "btnSavingsEdit";
            this.btnSavingsEdit.Size = new System.Drawing.Size(112, 34);
            this.btnSavingsEdit.TabIndex = 7;
            this.btnSavingsEdit.Text = "Edit";
            this.btnSavingsEdit.UseVisualStyleBackColor = true;
            // 
            // btnCheckingEdit
            // 
            this.btnCheckingEdit.Location = new System.Drawing.Point(538, 181);
            this.btnCheckingEdit.Name = "btnCheckingEdit";
            this.btnCheckingEdit.Size = new System.Drawing.Size(112, 34);
            this.btnCheckingEdit.TabIndex = 8;
            this.btnCheckingEdit.Text = "Edit";
            this.btnCheckingEdit.UseVisualStyleBackColor = true;
            // 
            // btnInvestmentsEdit
            // 
            this.btnInvestmentsEdit.Location = new System.Drawing.Point(538, 238);
            this.btnInvestmentsEdit.Name = "btnInvestmentsEdit";
            this.btnInvestmentsEdit.Size = new System.Drawing.Size(112, 34);
            this.btnInvestmentsEdit.TabIndex = 9;
            this.btnInvestmentsEdit.Text = "Edit";
            this.btnInvestmentsEdit.UseVisualStyleBackColor = true;
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 376);
            this.Controls.Add(this.btnInvestmentsEdit);
            this.Controls.Add(this.btnCheckingEdit);
            this.Controls.Add(this.btnSavingsEdit);
            this.Controls.Add(this.lblInvestmentsAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCheckingAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSavingsAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LandingPage";
            this.Text = "LandingPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSavingsAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCheckingAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblInvestmentsAmount;
        private System.Windows.Forms.Button btnSavingsEdit;
        private System.Windows.Forms.Button btnCheckingEdit;
        private System.Windows.Forms.Button btnInvestmentsEdit;
    }
}