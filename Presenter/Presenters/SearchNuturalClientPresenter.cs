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

            _view.TransmitDataOfSearchAtCreatNuturalClient += TransmitDataOfSearchAtCreatNuturalClient;
        }

        private void TransmitDataOfSearchAtCreatNuturalClient(string surname, string name, string middleName)
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
