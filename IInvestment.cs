using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace day1
{
    public interface IInvestment
    {
        double cost();
        double estimatedValue();
        double profits();        
        string dateAcquired();
    }
}
