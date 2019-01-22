using Ninject;
using Model.entity;

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
            _view.EnterIssuePolice += () => EnterIssuePolice(_view.SelectionClientTipeStr);

            _view.EnterNewPoliceCategori += () => EnterNewPoliceCategori();
        }

        public void EnterIssuePolice(string clientType)
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

        public void EnterNewPoliceCategori()
        {
            _kernel.Get<NewPoliceCategoriPresenter>().Run();
        }
        public void EnterButtonLogOut()
        {
            _kernel.Get<StartLoginPresenter>().Run();
            _view.Close();
        }

        public void Run()
        {
            _kernel.Get<IStartLoginView>().ShowError(null);
            _kernel.Get<IStartLoginView>().Show();
        }

        public void Run(User user)
        {
            _view.SetUserDataView(user);
            _view.Show();
        }
    }
}
