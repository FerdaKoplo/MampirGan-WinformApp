using MampirGanWinformApp.Implementation;
using MampirGanWinformApp.StateMachine.Event;
using MampirGanWinformApp.Views.Interfaces.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampirGanWinformApp.Presenter
{
    public class RegisterPresenter
    {
        private readonly IRegisterView _view;
        private readonly IAuthService _service;
        private readonly AuthStateMachine _stateMachine;

        public RegisterPresenter(IRegisterView view, IAuthService service)
        {
            _view = view;
            _service = service;
            _stateMachine = new AuthStateMachine();
        }

        public void HandleRegister()
        {
            _stateMachine.Trigger(AuthEvent.SubmitRegister);

            bool result = _service.Register(_view.Email, _view.Username, _view.Password);
            if (result)
            {
                _stateMachine.Trigger(AuthEvent.Success);
                _view.NavigateToLogin();
            }
            else
            {
                _stateMachine.Trigger(AuthEvent.Fail);
                _view.ShowMessage("Email atau username sudah digunakan.");
            }
        }
    }
}
