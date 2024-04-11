using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp_20210884
{
    public class InvestmentAccount : Account
    {
        private double interestRate;
        private double feeForFailed;

        public double InterestRate { get => interestRate; set => interestRate = value; }
        public double FeeForFailed { get => feeForFailed; set => feeForFailed = value; }


        public InvestmentAccount(double _balance, double _interestRate, double _feeForFailed) : base(_balance)
        {
            interestRate = _interestRate;
            feeForFailed = _feeForFailed;
        }

        public override double CalculateInterest()
        {
            var interest = interestRate / 100;
            return balance * interest ;
        }
    }
}
