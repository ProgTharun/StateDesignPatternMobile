using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternMobile.Model
{
    internal class OnState : IMobileState
    {
        public void PressPowerButton(MobileContext context)
        {
            Console.WriteLine("Turning On...");
            context.SetState(new SleepState());
        }

        public string GetStateName()
        {
            return "OnState";
        }
    }

}

