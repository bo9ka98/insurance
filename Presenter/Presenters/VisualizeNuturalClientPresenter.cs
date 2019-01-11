using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Model;
using System.Collections;

namespace Presenter
{
    public class VisualizeNuturalClientPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IVisualizeNuturalClientView _view;
        private readonly IClientDataService<NuturalClient> _data;
        private NuturalClient client;
        public VisualizeNuturalClientPresenter(IKernel kernel, IVisualizeNuturalClientView view, IClientDataService<NuturalClient> data)
        {
            _kernel = kernel;
            _view = view;
            _data = data;

            _view.saveData += () => saveData(client);
            _view.EnterReturnWorkMenu += () => loadData();
            //_view.ViewData += TransmitDataOfCreatAtVisualizeNuturalClient;
        }

        private void saveData(NuturalClient nuturalClient)
        {
           
            _data.ListObject = new List<NuturalClient>() {nuturalClient};
            _kernel.Get<NuturalClientDao>().SerializeList(_data.ListObject);
        }

        private void loadData()
        {
            List<NuturalClient> list = _kernel.Get<NuturalClientDao>().DeserializeList();
        }

        public void Run()
        {
            _view.Show();
        }

        public void Run(NuturalClient nuturalClient)
        {
            client = nuturalClient;
            _view.SetManData(nuturalClient);
            _view.Show();
        }
    }
}
