using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATMProcess
{
    public interface ICustomerBasicInfo
    {
        bool SetPinNumber(int pinNumber);
        bool SetName(string name);
        bool SetBalance(decimal balance);
        int GetPinNumber();
        string GetName();
        decimal GetBalance();
        bool IsValidUser();
    }

    public interface IWithdraw : ICustomerBasicInfo
    {
        bool SetWithDrawAmount(decimal withdrawAmount);
        bool WithDraw(decimal withdrawAmount);
    }

}
