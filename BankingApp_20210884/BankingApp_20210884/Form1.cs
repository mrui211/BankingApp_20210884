using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp_20210884
{
    public partial class Form1 : Form
    {

        Customer c1 = new Customer(1,"Mariano", "0210147963", false);
        Customer c2 = new Customer(2, "Jhon", "0210874154", true);
        Customer customer;
        Account acc;
        double _interest = 0;
        double _failedFee = 0;

        public Form1()
        {
            InitializeComponent();

            c1.ListAccounts.Add(new EverydayAccount(1000));
            c1.ListAccounts.Add(new InvestmentAccount(500,4,10));
            c1.ListAccounts.Add(new OmniAccount(100,7,10,750));

            c2.ListAccounts.Add(new EverydayAccount(800));
            c2.ListAccounts.Add(new InvestmentAccount(500,4,10));
            c2.ListAccounts.Add(new OmniAccount(100, 7, 10, 750));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SelectCustomer();

            foreach (var account in Enum.GetValues(typeof(Account.accountTypes)))
                    cmboxAccountType.Items.Add(account);

        }

        public void SelectCustomer()
        {
            if (rbtNormalCustomer.Checked)
                customer = c1;
            else
                customer = c2;

            DisplayCustomerInfo();
        }

        public void DisplayCustomerInfo()
        {
            txtCustomerID.Text = customer.CustomerID.ToString();
            txtCustomerName.Text = customer.Name.ToString();
            txtCustomerContactDetails.Text = customer.ContactDetails.ToString();
            chkBoxCustomerBankStaff.Checked = customer.BankStaff;
        }

        private void rbtNormalCustomer_CheckedChanged(object sender, EventArgs e)
        {
            SelectCustomer();
            ClearFormInfo();
        }

        private void cmboxAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboxAccountType.Text == Account.accountTypes.EverydayAccount.ToString())
            {
                var account = customer.ListAccounts.OfType<EverydayAccount>().ToList();
                txtBalance.Text = account[0].Balance.ToString();
                acc = account[0];
                txtInterest.Text = "N/A";
                txtOverdraftPermitted.Text = "N/A";
            }
            if (cmboxAccountType.Text == Account.accountTypes.InvestmentAccount.ToString())
            {
                var account = customer.ListAccounts.OfType<InvestmentAccount>().ToList();
                txtBalance.Text = account[0].Balance.ToString();
                acc = account[0];
                txtInterest.Text = account[0].InterestRate.ToString();
                txtOverdraftPermitted.Text = "N/A";
                _failedFee = account[0].FeeForFailed;
            }
            if (cmboxAccountType.Text == Account.accountTypes.OmniAccount.ToString())
            {
                var account = customer.ListAccounts.OfType<OmniAccount>().ToList();
                txtBalance.Text = account[0].Balance.ToString();
                acc = account[0];
                txtInterest.Text = account[0].InterestRate.ToString();
                txtOverdraftPermitted.Text = account[0].OverdraftLimit.ToString();
                _failedFee = account[0].FeeForFailed;
            }
        }



        public void ClearFormInfo()
        {
            cmboxAccountType.Text = string.Empty; 
            txtBalance.Text = string.Empty;
            txtAmount.Text = string.Empty;
            txtInterest.Text = string.Empty;
            txtOverdraftPermitted.Text = string.Empty;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if(ValidateIsNumber(txtAmount.Text))
            {
                acc.Deposit(Convert.ToDouble(txtAmount.Text));
                lstBoxTransactionsHistory.Items.Add("Customer: " + customer.Name.ToString() + " deposited $" + txtAmount.Text + " into " + acc.GetType().Name + " #" + acc.UniqueID.ToString() + " on " + DateTime.Now.ToString() + "; Updated Balance: $" + acc.Balance);
            }
            cmboxAccountType_SelectedIndexChanged(sender, e);
        }

        public bool ValidateIsNumber(string num)
        {
            if (!string.IsNullOrEmpty(num))
            {
                if (double.TryParse(num, out double amount))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("The value entered is not a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please enter a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            var accountName = acc.GetType().Name;
            if (ValidateIsNumber(txtAmount.Text))
            {
                if (acc.Withdraw(Convert.ToDouble(txtAmount.Text)))
                    lstBoxTransactionsHistory.Items.Add("Customer: " + customer.Name.ToString() + " withdrew $" + txtAmount.Text + " from " + accountName + " #" + acc.UniqueID.ToString() + " on " + DateTime.Now.ToString() + "; Updated Balance: $" + acc.Balance);
                else
                {
                    if (customer.BankStaff)
                        _failedFee = _failedFee / 2;
                    MessageBox.Show("You don't hhave enough founds, please check current balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if  ((accountName.Equals(Account.accountTypes.InvestmentAccount.ToString()) && (acc.Balance >= _failedFee)) || (accountName.Equals(Account.accountTypes.OmniAccount.ToString()) && ((Convert.ToDouble(acc.Balance) - _failedFee ) >= (Convert.ToDouble(txtOverdraftPermitted.Text) * -1))))
                    {
                        acc.Withdraw(_failedFee);
                        lstBoxTransactionsHistory.Items.Add("Customer: " + customer.Name.ToString() + "; " + accountName + " #" + acc.UniqueID.ToString() + "; Withdraw Attempt: $" + txtAmount.Text + " on " + DateTime.Now.ToString()
                        + "; Transaction status: Failed; Fee: $" + _failedFee + "; Updated Balance: $" + acc.Balance);
                    }
                    else
                        MessageBox.Show("You don't have enough balance to cover the failed widreawal attempt fee transcaction of $" + _failedFee + ". Your current balance is $" + acc.Balance );
                }
            }

            cmboxAccountType_SelectedIndexChanged(sender, e);
        }

        private void btnCalculateInterest_Click(object sender, EventArgs e)
        {
            var accountName = acc.GetType().Name;
            if (accountName == Account.accountTypes.EverydayAccount.ToString())
            {
                MessageBox.Show("Not applicable for this type of account");
                return;
            }
            else
            {
                _interest = acc.CalculateInterest();
                lstBoxTransactionsHistory.Items.Add("Customer: " + customer.Name.ToString() + " ; interest calculated for " + acc.GetType().Name + " #" + acc.UniqueID.ToString() + " on " + DateTime.Now.ToString() + " is $" + _interest);
            }
        }

        private void btnAddInterest_Click(object sender, EventArgs e)
        {
            acc.Deposit(_interest);
            lstBoxTransactionsHistory.Items.Add("Customer: " + customer.Name.ToString() + " ; " +  acc.GetType().Name + " #" + acc.UniqueID.ToString() + " interest added: $" + _interest + 
                " ; " + "updated balance: $" + acc.Balance + " on " +  DateTime.Now.ToString());
             cmboxAccountType_SelectedIndexChanged(sender, e);
        }
    }
}
