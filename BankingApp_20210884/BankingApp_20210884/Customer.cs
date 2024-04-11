using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp_20210884
{
    public class Customer
    {
        private int customerID;
        private string name;
        private string contactDetails;
        private bool bankStaff;
        
        public List<Account> ListAccounts { get; set; }

        public int CustomerID { get => customerID; set => customerID = value; }
        public string Name { get => name; set => name = value; }
        public string ContactDetails { get => contactDetails; set => contactDetails = value; }
        public bool BankStaff { get => bankStaff; set => bankStaff = value; }

        public Customer(int _customerID, string _name, string _contactDetails, bool _bankStaff)
        {
            CustomerID = _customerID;
            Name = _name;
            ContactDetails = _contactDetails;
            BankStaff = _bankStaff;

            ListAccounts = new List<Account>();
        }


    }
}
