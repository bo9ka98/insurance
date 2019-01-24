using Ninject;
using Model.entity;

namespace Presenter
{
    public class SearchIndividClientPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly ISearchIndividClientView _view;


        public SearchIndividClientPresenter(IKernel kernel, ISearchIndividClientView view)
        {
            _kernel = kernel;
            _view = view;

            _view.ViewDataAliasMan += ViewDataAliasMan;
        }

        private void ViewDataAliasMan(AliasMan aliasMan)
        {
            _kernel.Get<CreatIndividClienPresenter>().Run(aliasMan);
            _view.Close();

        }
        public void Run()
        {
            _view.Show();
        }
    }
}
