using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternMobile.Model
{
  internal class MobileContext
    {
        private IMobileState currentState;
        private HashSet<string> stateHistory;

        public MobileContext()
        {
            currentState = new OffState();
            stateHistory = new HashSet<string>();
            stateHistory.Add(currentState.GetStateName());
        }

        public void SetState(IMobileState state)
        {
            currentState = state;
            stateHistory.Add(state.GetStateName());
        }

        public void PressPowerButton()
        {
            currentState.PressPowerButton(this);
        }

        public void DisplayStateHistory()
        {
            Console.WriteLine("State Transition History:");
            foreach (var state in stateHistory)
            {
                Console.WriteLine(state);
            }
        }
    }
}
