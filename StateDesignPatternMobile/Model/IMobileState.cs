using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternMobile.Model
{
    internal interface IMobileState
    {
        void PressPowerButton(MobileContext context);
        string GetStateName();
    }

}
