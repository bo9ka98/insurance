using System;
using Ninject;

namespace Presenter
{
    public class SearchLegalClientPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly ISearchLegalClientView _view;

        public SearchLegalClientPresenter(IKernel kernel, ISearchLegalClientView view)
        {
            _kernel = kernel;
            _view = view;

            _view.TransmitDataOfSearchAtCreatLegalClient += TransmitDataOfSearchAtCreatlegalClient;

        }

        private void TransmitDataOfSearchAtCreatlegalClient(string organisationName, string utn)
        {

        }
        public void Run()
        {
            _view.Show();
        }
    }
}
