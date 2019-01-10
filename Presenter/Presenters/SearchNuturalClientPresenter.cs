using Ninject;

namespace Presenter
{
    public class SearchNuturalClientPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly ISearchNuturalClientView _view;


        public SearchNuturalClientPresenter(IKernel kernel, ISearchNuturalClientView view)
        {
            _kernel = kernel;
            _view = view;

            _view.EnterSearch += () => EnterSearch(_view.SurnameNuturalClientStr, _view.NameNuturalClientStr, _view.MinnleNameNuturalClientStr);
        }

        private void EnterSearch(string surname, string name, string middleName)
        {
            _kernel.Get<CreatNuturalClienPresenter>().Run(surname, name, middleName);
            _view.Close();
        }
        public void Run()
        {
            _view.Show();
        }
    }
}
