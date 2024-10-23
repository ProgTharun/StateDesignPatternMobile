using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternMobile.Model
{
    internal class OffState : IMobileState
    {
        public void PressPowerButton(MobileContext context)
        {
            Console.WriteLine("Turning Off...");
            context.SetState(new OnState());
        }

        public string GetStateName()
        {
            return "OffState";
        }
    }


}
