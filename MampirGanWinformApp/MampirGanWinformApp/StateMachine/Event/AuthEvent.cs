using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampirGanWinformApp.StateMachine.Event
{
    public enum AuthEvent
    {
        SubmitLogin,
        SubmitRegister,
        Success,
        Fail
    }
}
