using Ninject;
using Model.entity;

namespace Presenter
{
    class NewPoliceCategoriPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly INewPoliceCategoriPresenterView _view;


        public NewPoliceCategoriPresenter(IKernel kernel, INewPoliceCategoriPresenterView view)
        {
            _kernel = kernel;
            _view = view;

            _view.RegistrPoliceCategori += RegistrPoliceCategori;
        }

        private void RegistrPoliceCategori(PoliceCategori policeCategori)
        {
            //_kernel.Get<>
            _kernel.Get<WorkMenuPresenter>().Run();
            _view.Close();

        }
        public void Run()
        {
            _view.Show();
        }
    }
}
