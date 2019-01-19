using Ninject;
using Model;

namespace Presenter
{
    public class CreatIndividClienPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly ICreatIndividClienView _view;


        public CreatIndividClienPresenter(IKernel kernel, ICreatIndividClienView view)
        {
            _kernel = kernel;
            _view = view;

            _view.ViewDataMan += ViewDataMan;
        }

        private void ViewDataMan(IndividClient individClient)
        {
            _kernel.Get<VisualizeNuturalClientPresenter>().Run(individClient);
            //_view.Close();
        }
        public void Run()
        {
            _view.Show();
        }

        public void Run(AliasMan aliasMan)
        {
            _view.setAliasMan(aliasMan);
            _view.Show();
        }
    }
}
