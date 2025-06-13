using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampirGanWinformApp.StateMachine.State
{
    public enum AuthState
    {
        Idle,
        Validating,
        Success,
        Failed
    }
}
