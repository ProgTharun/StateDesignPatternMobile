using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternMobile.Model
{
    internal class SleepState : IMobileState
    {
        public void PressPowerButton(MobileContext context)
        {
            Console.WriteLine("Going To Sleep...");
            context.SetState(new OffState());
        }

        public string GetStateName()
        {
            return "SleepState";
        }
    }


}

