using Ninject;
using Model;

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

            _view.ViewDataMan += ViewDataMan;
        }

        private void ViewDataMan(NuturalClient nuturalClient)
        {
            _kernel.Get<VisualizeNuturalClientPresenter>().Run(nuturalClient);
            //_view.Close();
        }
        public void Run()
        {
            _view.Show();
        }

        public void Run(string surname, string name, string middlename)
        {
            _view.setSurname_Name_MiddleNameOnForm(surname,name,middlename);
            _view.Show();
        }
    }
}
