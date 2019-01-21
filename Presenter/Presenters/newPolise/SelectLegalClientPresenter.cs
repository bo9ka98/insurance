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

            _viewSearch.TransmitDataLegalSatC += TransmitDataLegalSatC;
            _viewCreat.TransmitDataLegalCatV += TransmitDataLegalCatV;
        }

        private void TransmitDataLegalSatC(AliasCompanu aliasCompanu)
        {
            Run(aliasCompanu);
            _viewSearch.Close();
        }

        private void TransmitDataLegalCatV(LegalСlient legalClient)
        {
            Run(legalClient);
            _viewCreat.Close();
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
            _viewVisual.SetLegalClientData(legalСlient);
            _viewVisual.Show();
        }
    }
}
