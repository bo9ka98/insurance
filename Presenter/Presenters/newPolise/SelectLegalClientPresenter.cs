using System;
using Ninject;
using Model;

namespace Presenter
{
    public class SelectLegalClientPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly ISearchLegalClientView _viewSearch;
        private readonly ICreatLegalClientView _viewCreat;
        private readonly IVisualizeLegalClientView _viewVisual;

        public SelectLegalClientPresenter(IKernel kernel, ISearchLegalClientView viewSearch,
            ICreatLegalClientView viewCreat, IVisualizeLegalClientView viewVisual)
        {
            _kernel = kernel;
            _viewSearch = viewSearch;
            _viewCreat = viewCreat;
            _viewVisual = viewVisual;

           
            _viewCreat.TransmitDataLegalCatV += TransmitDataLegalCatV;
            _viewSearch.TransmitDataLegalSatC += TransmitDataLegalSatC;
        }

        private void TransmitDataLegalCatV(LegalСlient legalClient)
        {
            Run(legalClient);
        }

        private void TransmitDataLegalSatC(AliasCompanu aliasCompanu)
        {
            Run(aliasCompanu);
            _viewSearch.Close();
        }

        public void Run()
        {
            _viewSearch.Show();
        }

        public void Run(AliasCompanu aliasCompanu)
        {
            _viewCreat.setAliasCompanu(aliasCompanu);
            _viewCreat.Show();
        }

        public void Run(LegalСlient legalСlient)
        {

            _viewVisual.Show();
        }
    }
}
