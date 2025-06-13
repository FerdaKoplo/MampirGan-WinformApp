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
            { (AuthState.Idle, AuthEvent.SubmitLogin), AuthState.Validating },
            { (AuthState.Validating, AuthEvent.Success), AuthState.Success },
            { (AuthState.Validating, AuthEvent.Fail), AuthState.Failed },
            { (AuthState.Idle, AuthEvent.SubmitRegister), AuthState.Validating }
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
