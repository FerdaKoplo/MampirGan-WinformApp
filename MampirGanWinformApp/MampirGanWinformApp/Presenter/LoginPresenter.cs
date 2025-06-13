//using MampirGanWinformApp.Implementation;
//using MampirGanWinformApp.Model;
//using MampirGanWinformApp.StateMachine.Event;
//using MampirGanWinformApp.Views.Forms.Customer;
//using MampirGanWinformApp.Views.Interfaces.Auth;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MampirGanWinformApp.Presenter
//{
//    public class LoginPresenter
//    {
//        private readonly ILoginView _view;
//        private readonly IAuthService _service;
//        private readonly AuthStateMachine _stateMachine;

//        public LoginPresenter(ILoginView view, IAuthService service)
//        {
//            _view = view;
//            _service = service;
//            _stateMachine = new AuthStateMachine();
//        }

//        public void HandleLogin()
//        {
//            _stateMachine.Trigger(AuthEvent.SubmitLogin);
//            var user = _service.Login(_view.Username, _view.Password);

//            if (user != null)
//            {
//                _stateMachine.Trigger(AuthEvent.Success);

//                if (user.Role == UserRole.Customer)
//                {
//                    var dashboard = new DashboardCustomerForm();
//                    dashboard.Show();
//                }
//                else
//                {
//                    _view.ShowMessage("Role tidak dikenali.");
//                }
//            }
//            else
//            {
//                _stateMachine.Trigger(AuthEvent.Fail);
//                _view.ShowMessage("Login gagal. Username atau password salah.");
//            }
//        }
//    }

//}
