
namespace ATMProcess
{
    using System;
    using System.Collections.Generic;

    public class BasicInfo
    {
        internal int ActualPinNumber { get; set; }
        internal string ActualName { get; set; }
        internal decimal CurrentBalance { get; set; }
        internal Dictionary<int, string> MiniStatement { get; set; } 
    }

    public class WithDrawInfo : BasicInfo
    {
        internal int UserPinNumber { get; set; }
        internal string UserName { get; set; }
        internal decimal WithDrawAmount { get; set; }
    }


}
