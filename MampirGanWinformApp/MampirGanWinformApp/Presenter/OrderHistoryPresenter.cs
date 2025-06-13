//using MampirGanWinformApp.Service.Interface;
//using MampirGanWinformApp.View.Interface;

//namespace MampirGanWinformApp.Presenter
//{
//    public class OrderHistoryPresenter
//    {
//        private readonly IOrderHistoryView _view;
//        private readonly IOrderHistoryService _service;

//        public OrderHistoryPresenter(IOrderHistoryView view, IOrderHistoryService service)
//        {
//            _view = view;
//            _service = service;
//        }

//        public void LoadAll()
//        {
//            var orders = _service.GetAll();
//            _view.DisplayOrders(orders);
//        }

//        public void LoadByCustomer(string customerName)
//        {
//            var orders = _service.GetByCustomer(customerName);
//            _view.DisplayOrders(orders);
//        }
//    }
//}
