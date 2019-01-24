using System;
using Ninject;
using Model.service;
using Model.entity;

namespace Presenter
{
    public class VisualizeNuturalClientPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IVisualizeNuturalClientView _view;
        private readonly IClientDataService<IndividClient> _data;
        private IndividClient client;

        public VisualizeNuturalClientPresenter(IKernel kernel,
            IVisualizeNuturalClientView view, IClientDataService<IndividClient> data)
        {
            _kernel = kernel;
            _view = view;
            _data = data;

            _view.saveData += () => saveData(client);
            _view.EnterReturnWorkMenu += () => loadData();
            //_view.ViewData += TransmitDataOfCreatAtVisualizeNuturalClient;
        }

        private void saveData(IndividClient individClient)
        {

            _data.AddListIndividClientDao(individClient);
        }

        private void loadData()
        {

        }

        public void Run()
        {
            _view.Show();
        }

        public void Run(IndividClient nuturalClient)
        {
            //client = nuturalClient;
            _view.SetIndividClientData(nuturalClient);
            _view.Show();
        }
    }
}
