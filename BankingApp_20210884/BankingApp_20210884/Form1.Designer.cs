namespace BankingApp_20210884
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelectAccount = new System.Windows.Forms.Label();
            this.cmboxAccountType = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdrawal = new System.Windows.Forms.Button();
            this.lblInterest = new System.Windows.Forms.Label();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.lblOverdraftPermitted = new System.Windows.Forms.Label();
            this.txtOverdraftPermitted = new System.Windows.Forms.TextBox();
            this.rbtNormalCustomer = new System.Windows.Forms.RadioButton();
            this.rbtBankCustomer = new System.Windows.Forms.RadioButton();
            this.grpBoxCustomerDetails = new System.Windows.Forms.GroupBox();
            this.chkBoxCustomerBankStaff = new System.Windows.Forms.CheckBox();
            this.txtCustomerContactDetails = new System.Windows.Forms.TextBox();
            this.lblCustomerContactDetails = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lstBoxTransactionsHistory = new System.Windows.Forms.ListBox();
            this.lblTransactionHistory = new System.Windows.Forms.Label();
            this.btnCalculateInterest = new System.Windows.Forms.Button();
            this.btnAddInterest = new System.Windows.Forms.Button();
            this.grpBoxCustomerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(563, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank App";
            // 
            // lblSelectAccount
            // 
            this.lblSelectAccount.AutoSize = true;
            this.lblSelectAccount.Location = new System.Drawing.Point(123, 184);
            this.lblSelectAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectAccount.Name = "lblSelectAccount";
            this.lblSelectAccount.Size = new System.Drawing.Size(77, 13);
            this.lblSelectAccount.TabIndex = 1;
            this.lblSelectAccount.Text = "Account Type:";
            // 
            // cmboxAccountType
            // 
            this.cmboxAccountType.FormattingEnabled = true;
            this.cmboxAccountType.Location = new System.Drawing.Point(197, 181);
            this.cmboxAccountType.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxAccountType.Name = "cmboxAccountType";
            this.cmboxAccountType.Size = new System.Drawing.Size(140, 21);
            this.cmboxAccountType.TabIndex = 2;
            this.cmboxAccountType.SelectedIndexChanged += new System.EventHandler(this.cmboxAccountType_SelectedIndexChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(152, 234);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 13);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(197, 231);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(76, 20);
            this.txtAmount.TabIndex = 4;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(62, 321);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(80, 34);
            this.btnDeposit.TabIndex = 5;
            this.btnDeposit.Text = "Deposit ";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdrawal
            // 
            this.btnWithdrawal.Location = new System.Drawing.Point(149, 321);
            this.btnWithdrawal.Margin = new System.Windows.Forms.Padding(2);
            this.btnWithdrawal.Name = "btnWithdrawal";
            this.btnWithdrawal.Size = new System.Drawing.Size(80, 34);
            this.btnWithdrawal.TabIndex = 5;
            this.btnWithdrawal.Text = "Withdrawal";
            this.btnWithdrawal.UseVisualStyleBackColor = true;
            this.btnWithdrawal.Click += new System.EventHandler(this.btnWithdrawal_Click);
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(153, 259);
            this.lblInterest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(45, 13);
            this.lblInterest.TabIndex = 3;
            this.lblInterest.Text = "Interest:";
            // 
            // txtInterest
            // 
            this.txtInterest.Enabled = false;
            this.txtInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterest.Location = new System.Drawing.Point(197, 256);
            this.txtInterest.Margin = new System.Windows.Forms.Padding(2);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(76, 20);
            this.txtInterest.TabIndex = 4;
            // 
            // lblOverdraftPermitted
            // 
            this.lblOverdraftPermitted.AutoSize = true;
            this.lblOverdraftPermitted.Location = new System.Drawing.Point(100, 282);
            this.lblOverdraftPermitted.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOverdraftPermitted.Name = "lblOverdraftPermitted";
            this.lblOverdraftPermitted.Size = new System.Drawing.Size(101, 13);
            this.lblOverdraftPermitted.TabIndex = 3;
            this.lblOverdraftPermitted.Text = "Overdraft Permitted:";
            // 
            // txtOverdraftPermitted
            // 
            this.txtOverdraftPermitted.Enabled = false;
            this.txtOverdraftPermitted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOverdraftPermitted.Location = new System.Drawing.Point(197, 279);
            this.txtOverdraftPermitted.Margin = new System.Windows.Forms.Padding(2);
            this.txtOverdraftPermitted.Name = "txtOverdraftPermitted";
            this.txtOverdraftPermitted.Size = new System.Drawing.Size(76, 20);
            this.txtOverdraftPermitted.TabIndex = 4;
            // 
            // rbtNormalCustomer
            // 
            this.rbtNormalCustomer.AutoSize = true;
            this.rbtNormalCustomer.Checked = true;
            this.rbtNormalCustomer.Location = new System.Drawing.Point(506, 76);
            this.rbtNormalCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.rbtNormalCustomer.Name = "rbtNormalCustomer";
            this.rbtNormalCustomer.Size = new System.Drawing.Size(105, 17);
            this.rbtNormalCustomer.TabIndex = 6;
            this.rbtNormalCustomer.TabStop = true;
            this.rbtNormalCustomer.Text = "Normal Customer";
            this.rbtNormalCustomer.UseVisualStyleBackColor = true;
            this.rbtNormalCustomer.CheckedChanged += new System.EventHandler(this.rbtNormalCustomer_CheckedChanged);
            // 
            // rbtBankCustomer
            // 
            this.rbtBankCustomer.AutoSize = true;
            this.rbtBankCustomer.Location = new System.Drawing.Point(623, 76);
            this.rbtBankCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.rbtBankCustomer.Name = "rbtBankCustomer";
            this.rbtBankCustomer.Size = new System.Drawing.Size(97, 17);
            this.rbtBankCustomer.TabIndex = 6;
            this.rbtBankCustomer.Text = "Bank Customer";
            this.rbtBankCustomer.UseVisualStyleBackColor = true;
            // 
            // grpBoxCustomerDetails
            // 
            this.grpBoxCustomerDetails.Controls.Add(this.chkBoxCustomerBankStaff);
            this.grpBoxCustomerDetails.Controls.Add(this.txtCustomerContactDetails);
            this.grpBoxCustomerDetails.Controls.Add(this.lblCustomerContactDetails);
            this.grpBoxCustomerDetails.Controls.Add(this.txtCustomerName);
            this.grpBoxCustomerDetails.Controls.Add(this.lblCustomerName);
            this.grpBoxCustomerDetails.Controls.Add(this.txtCustomerID);
            this.grpBoxCustomerDetails.Controls.Add(this.lblCustomerID);
            this.grpBoxCustomerDetails.Location = new System.Drawing.Point(126, 113);
            this.grpBoxCustomerDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grpBoxCustomerDetails.Name = "grpBoxCustomerDetails";
            this.grpBoxCustomerDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grpBoxCustomerDetails.Size = new System.Drawing.Size(621, 51);
            this.grpBoxCustomerDetails.TabIndex = 7;
            this.grpBoxCustomerDetails.TabStop = false;
            this.grpBoxCustomerDetails.Text = "Customer Details";
            // 
            // chkBoxCustomerBankStaff
            // 
            this.chkBoxCustomerBankStaff.AutoSize = true;
            this.chkBoxCustomerBankStaff.Enabled = false;
            this.chkBoxCustomerBankStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxCustomerBankStaff.Location = new System.Drawing.Point(488, 17);
            this.chkBoxCustomerBankStaff.Margin = new System.Windows.Forms.Padding(2);
            this.chkBoxCustomerBankStaff.Name = "chkBoxCustomerBankStaff";
            this.chkBoxCustomerBankStaff.Size = new System.Drawing.Size(86, 17);
            this.chkBoxCustomerBankStaff.TabIndex = 2;
            this.chkBoxCustomerBankStaff.Text = "Bank Staff";
            this.chkBoxCustomerBankStaff.UseVisualStyleBackColor = true;
            // 
            // txtCustomerContactDetails
            // 
            this.txtCustomerContactDetails.Enabled = false;
            this.txtCustomerContactDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerContactDetails.Location = new System.Drawing.Point(345, 15);
            this.txtCustomerContactDetails.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerContactDetails.Name = "txtCustomerContactDetails";
            this.txtCustomerContactDetails.Size = new System.Drawing.Size(122, 20);
            this.txtCustomerContactDetails.TabIndex = 1;
            // 
            // lblCustomerContactDetails
            // 
            this.lblCustomerContactDetails.AutoSize = true;
            this.lblCustomerContactDetails.Location = new System.Drawing.Point(259, 18);
            this.lblCustomerContactDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerContactDetails.Name = "lblCustomerContactDetails";
            this.lblCustomerContactDetails.Size = new System.Drawing.Size(82, 13);
            this.lblCustomerContactDetails.TabIndex = 0;
            this.lblCustomerContactDetails.Text = "Contact Details:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(170, 15);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(76, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(133, 18);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(38, 13);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Name:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(42, 15);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(76, 20);
            this.txtCustomerID.TabIndex = 1;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(20, 18);
            this.lblCustomerID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(21, 13);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Text = "ID:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(152, 210);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(49, 13);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = "Balance:";
            // 
            // txtBalance
            // 
            this.txtBalance.Enabled = false;
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(197, 207);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(2);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(76, 20);
            this.txtBalance.TabIndex = 4;
            // 
            // lstBoxTransactionsHistory
            // 
            this.lstBoxTransactionsHistory.FormattingEnabled = true;
            this.lstBoxTransactionsHistory.Location = new System.Drawing.Point(446, 195);
            this.lstBoxTransactionsHistory.Name = "lstBoxTransactionsHistory";
            this.lstBoxTransactionsHistory.Size = new System.Drawing.Size(922, 160);
            this.lstBoxTransactionsHistory.TabIndex = 8;
            // 
            // lblTransactionHistory
            // 
            this.lblTransactionHistory.AutoSize = true;
            this.lblTransactionHistory.Location = new System.Drawing.Point(443, 181);
            this.lblTransactionHistory.Name = "lblTransactionHistory";
            this.lblTransactionHistory.Size = new System.Drawing.Size(103, 13);
            this.lblTransactionHistory.TabIndex = 9;
            this.lblTransactionHistory.Text = "Transactions History";
            // 
            // btnCalculateInterest
            // 
            this.btnCalculateInterest.Location = new System.Drawing.Point(234, 321);
            this.btnCalculateInterest.Name = "btnCalculateInterest";
            this.btnCalculateInterest.Size = new System.Drawing.Size(80, 34);
            this.btnCalculateInterest.TabIndex = 10;
            this.btnCalculateInterest.Text = "Calculate Interest";
            this.btnCalculateInterest.UseVisualStyleBackColor = true;
            this.btnCalculateInterest.Click += new System.EventHandler(this.btnCalculateInterest_Click);
            // 
            // btnAddInterest
            // 
            this.btnAddInterest.Location = new System.Drawing.Point(320, 321);
            this.btnAddInterest.Name = "btnAddInterest";
            this.btnAddInterest.Size = new System.Drawing.Size(80, 34);
            this.btnAddInterest.TabIndex = 10;
            this.btnAddInterest.Text = "Add Interest";
            this.btnAddInterest.UseVisualStyleBackColor = true;
            this.btnAddInterest.Click += new System.EventHandler(this.btnAddInterest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 373);
            this.Controls.Add(this.btnAddInterest);
            this.Controls.Add(this.btnCalculateInterest);
            this.Controls.Add(this.lblTransactionHistory);
            this.Controls.Add(this.lstBoxTransactionsHistory);
            this.Controls.Add(this.grpBoxCustomerDetails);
            this.Controls.Add(this.rbtBankCustomer);
            this.Controls.Add(this.rbtNormalCustomer);
            this.Controls.Add(this.btnWithdrawal);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.txtOverdraftPermitted);
            this.Controls.Add(this.lblOverdraftPermitted);
            this.Controls.Add(this.txtInterest);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.cmboxAccountType);
            this.Controls.Add(this.lblSelectAccount);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Mariano Ruiz - 20210884";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxCustomerDetails.ResumeLayout(false);
            this.grpBoxCustomerDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSelectAccount;
        private System.Windows.Forms.ComboBox cmboxAccountType;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdrawal;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.Label lblOverdraftPermitted;
        private System.Windows.Forms.TextBox txtOverdraftPermitted;
        private System.Windows.Forms.RadioButton rbtNormalCustomer;
        private System.Windows.Forms.RadioButton rbtBankCustomer;
        private System.Windows.Forms.GroupBox grpBoxCustomerDetails;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.CheckBox chkBoxCustomerBankStaff;
        private System.Windows.Forms.TextBox txtCustomerContactDetails;
        private System.Windows.Forms.Label lblCustomerContactDetails;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.ListBox lstBoxTransactionsHistory;
        private System.Windows.Forms.Label lblTransactionHistory;
        private System.Windows.Forms.Button btnCalculateInterest;
        private System.Windows.Forms.Button btnAddInterest;
    }
}

