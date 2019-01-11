using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Model;

namespace Presenter
{
    public class VisualizeNuturalClientPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IVisualizeNuturalClientView _view;

        public VisualizeNuturalClientPresenter(IKernel kernel, IVisualizeNuturalClientView view)
        {
            _kernel = kernel;
            _view = view;

            _view.ViewData += TransmitDataOfCreatAtVisualizeNuturalClient;
        }

        private void TransmitDataOfCreatAtVisualizeNuturalClient(Man man)
        {
            
        }
        public void Run()
        {
            _view.Show();
        }

        public void Run(Man man)
        {
            _view.SetManData(man);
            _view.Show();
        }
    }
}
