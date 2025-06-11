using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MampirGanWinformApp.StateMachine.Event;
using MampirGanWinformApp.StateMachine.State;

namespace MampirGanWinformApp.StateMachine.Implementation
{
    public class CheckoutStateMachine
    {
        public CheckoutState CurrentCheckoutState { get; set; } = CheckoutState.Idle;

        private static readonly Dictionary<(CheckoutState, CheckoutEvent), CheckoutState> CheckoutTransitions = new()
        {
            {(CheckoutState.Idle, CheckoutEvent.ConfirmCheckout), CheckoutState.Confirming},
            {(CheckoutState.Confirming, CheckoutEvent.Pay), CheckoutState.Processing},
            {(CheckoutState.Processing, CheckoutEvent.Success), CheckoutState.Completed},
            {(CheckoutState.Completed, CheckoutEvent.Exit), CheckoutState.Completed},
            {(CheckoutState.Completed, CheckoutEvent.Reset), CheckoutState.Idle}
        };

        public void HandleEventCheckout(CheckoutEvent CheckoutEvent)
        {
            if (CheckoutTransitions.TryGetValue((CurrentCheckoutState, CheckoutEvent), out var NextState))
            {
                CurrentCheckoutState = NextState;
            }
            else
            {
                throw new InvalidOperationException($"Event Invalid {CheckoutEvent} di dalam state {CurrentCheckoutState}");
            }
        }
    }
}
