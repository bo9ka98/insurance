using Ninject;

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

            _view.EnterButtonLogOut += () => EnterButtonLogOut();
            //_view.EnterLogin += () => EnterLogin(_view.LoginString, _view.PassString, _view.SuperuserFlag);
        }

        public void EnterButtonLogOut()
        {
            _kernel.Get<StartLoginPresenter>().Run();
            _view.Close();
        }
        public void Run()
        {
            _view.Show();
        }
    }
}
