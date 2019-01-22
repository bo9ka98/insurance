using Ninject;
using Model.entity;
using Model.service;

namespace Presenter
{
    public class NewPoliceCategoriPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly INewPoliceCategoriView _view;


        public NewPoliceCategoriPresenter(IKernel kernel, INewPoliceCategoriView view)
        {
            _kernel = kernel;
            _view = view;

            _view.RegistrPoliceCategori += RegistrPoliceCategori;
        }

        private void RegistrPoliceCategori(PoliceCategori policeCategori)
        {
            User user = _kernel.Get<UserControlService>().GetAuthoriaedUser();
            _kernel.Get<WorkMenuPresenter>().Run(user);
            _view.Close();

        }
        public void Run()
        {
            _view.Show();
        }
    }
}
