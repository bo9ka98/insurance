using System;
using System.Windows.Forms;
using Ninject;
using Presenter;

namespace View
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Ninject.StandardKernel kernel = new StandardKernel();
            kernel.Bind<ApplicationContext>().ToConstant(new ApplicationContext());

            kernel.Bind<IStartLoginView>().To<StartLoginView>();
            kernel.Bind<IWorkMenuView>().To<WorkMenuView>();
            kernel.Bind<ISearchNuturalClientView>().To<SearchNuturalClientFormView>();
            kernel.Bind<ISearchLegalClientView>().To<SearchLegalClientFormView>();

            kernel.Bind<StartLoginPresenter>().ToSelf();
            kernel.Bind<WorkMenuPresenter>().ToSelf();
            kernel.Bind<SearchNuturalClientPresenter>().ToSelf();
            kernel.Bind<SearchLegalClientPresenter>().ToSelf();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            kernel.Get<StartLoginPresenter>().Run();
            Application.Run(kernel.Get<ApplicationContext>());
            //Application.Run(new VisualizeNuturalClientFormView());
        }
    }
}
