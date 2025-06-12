using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MampirGanWinformApp.StateMachine.Event;
using MampirGanWinformApp.StateMachine.State;

namespace MampirGanWinformApp.StateMachine.Implementation
{
    public class CartStateMachine
    {
        public CartState CurrentCartState { get; set; } = CartState.Empty;

        public static readonly Dictionary<(CartState, CartEvent), CartState> CartTransitions = new()
        {
            { (CartState.Empty, CartEvent.AddItem), CartState.Active},
            { (CartState.Active, CartEvent.AddItem), CartState.Active},
            { (CartState.Active, CartEvent.RemoveItem), CartState.Active},
            { (CartState.Active, CartEvent.ClearCart), CartState.Empty},
            { (CartState.Active, CartEvent.Checkout), CartState.CheckedOut},
            { (CartState.CheckedOut, CartEvent.Exit), CartState.CheckedOut}
        };

        public void HandleEventCart(CartEvent CartEvent)
        {
            if (CartTransitions.TryGetValue((CurrentCartState, CartEvent), out var NextState))
            {
                CurrentCartState = NextState;
            }
            else
            {
                throw new InvalidOperationException($"Event Invalid {CartEvent} di dalam state {CurrentCartState}");
            }
        }
    }
}
