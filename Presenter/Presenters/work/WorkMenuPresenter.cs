using Ninject;
using Model;

namespace Presenter
{
    public class WorkMenuPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IWorkMenuView _view;


        public WorkMenuPresenter(IKernel kernel, IWorkMenuView view)
        {
            _kernel = kernel;
            _view = view;

            _view.EnterButtonLogOut += () => EnterButtonLogOut();
            _view.EnterButtonNext += () => EnterButtonNext(_view.SelectionClientTipeStr);
        }

        public void EnterButtonNext(string clientType)
        {
            if (clientType == _view.FisClientStr)
            {
                _kernel.Get<SearchIndividClientPresenter>().Run();
                _view.Close();
            }else if(clientType == _view.JurClientStr)
            {
                _kernel.Get<SelectLegalClientPresenter>().Run();
                _view.Close();
            }

        }
        public void EnterButtonLogOut()
        {
            _kernel.Get<StartLoginPresenter>().Run();
            _view.Close();
        }
        public void Run()
        {
            _view.Show();
        }

        public void Run(User user)
        {
            _view.SetUserDataView(user);
            _view.Show();
        }
    }
}
