using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public class WorkMenuPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IWorkMenuView _view;


        public WorkMenuPresenter(IKernel kernel, IWorkMenuView view)
        {
            _kernel = kernel;
            _view = view;

            //_view.EnterLogin += () => EnterLogin(_view.LoginString, _view.PassString, _view.SuperuserFlag);
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
