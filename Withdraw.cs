using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATMProcess
{
    public class Withdraw : IWithdraw
    {
        WithDrawInfo wi = new WithDrawInfo();

        public bool SetWithDrawAmount(decimal withdrawAmount)
        {
            wi.WithDrawAmount = withdrawAmount;
            return true;
        }

        public bool WithDraw(decimal withdrawAmount)
        {
            bool isAmountWithdraw = false;
            if (IsValidUser())
            {
                wi.CurrentBalance -= wi.WithDrawAmount;
                isAmountWithdraw = true;
            }

            return isAmountWithdraw;
        }

        public bool SetPinNumber(int pinNumber)
        {
            wi.ActualPinNumber = pinNumber;
            return true;
        }

        public bool SetName(string name)
        {
            wi.ActualName = name;
            return true;
        }

        public bool SetBalance(decimal balance)
        {
            wi.CurrentBalance = balance;
            return true;
        }

        public int GetPinNumber()
        {
            return wi.ActualPinNumber;
        }

        public string GetName()
        {
            return wi.ActualName;
        }

        public decimal GetBalance()
        {
            return wi.CurrentBalance;
        }

        public bool IsValidUser()
        {
            bool isValidUser = false;
            if (wi.ActualName.Contains(GetName()) && wi.ActualPinNumber.Equals(GetPinNumber()))
            {
                isValidUser = true;
            }

            return isValidUser;
        }

    }
}
