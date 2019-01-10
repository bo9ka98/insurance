using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public class CreatNuturalClienPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly ICreatNuturalClienView _view;


        public CreatNuturalClienPresenter(IKernel kernel, ICreatNuturalClienView view)
        {
            _kernel = kernel;
            _view = view;

            //_view.EnterLogin += () => null;
        }

        public void Run()
        {
            _view.Show();
        }

        public void Run(string surname, string name, string middlename)
        {
            _view.SurnameNuturalClientStr = surname;
            _view.NameNuturalClientStr = name;
            _view.MinnleNameNuturalClientStr = middlename;
            _view.Show();
        }
    }
}
