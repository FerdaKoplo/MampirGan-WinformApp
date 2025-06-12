using MampirGanWinformApp.StateMachine.Event;
using MampirGanWinformApp.StateMachine.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampirGanWinformApp.Implementation
{
    public class AuthStateMachine
    {
        public AuthState CurrentAuthState { get; private set; } = AuthState.Idle;

        private static readonly Dictionary<(AuthState, AuthEvent), AuthState> transitions = new()
        {
            { (AuthState.Idle, AuthEvent.Submit), AuthState.Validating },
            { (AuthState.Validating, AuthEvent.Success), AuthState.Authenticated },
            { (AuthState.Validating, AuthEvent.Error), AuthState.Failed },
            { (AuthState.Failed, AuthEvent.Submit), AuthState.Validating }
        };

        public void Trigger(AuthEvent authEvent)
        {
            if (transitions.TryGetValue((CurrentAuthState, authEvent), out var NextState))
                CurrentAuthState = NextState;
            else
                throw new InvalidOperationException($"Event invalid{CurrentAuthState} with event {CurrentAuthState}");
        }
    }
}
