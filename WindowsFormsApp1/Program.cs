using System;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using Ninject;
using Presenter;
using Model;


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
            kernel.Bind<ICreatNuturalClienView>().To<CreatNuturalClienFormView>();
            kernel.Bind<ICreatLegalClientView>().To<CreatLegalClientFormView>();
            kernel.Bind<IVisualizeNuturalClientView>().To<VisualizeNuturalClientFormView>();
            kernel.Bind<IVisualizeLegalClientView>().To<VisualizeLegalClientFormView>();

            kernel.Bind<StartLoginPresenter>().ToSelf();
            kernel.Bind<WorkMenuPresenter>().ToSelf();
            kernel.Bind<SearchNuturalClientPresenter>().ToSelf();
            //kernel.Bind<SearchLegalClientPresenter>().ToSelf();
            kernel.Bind<CreatNuturalClienPresenter>().ToSelf();
            //kernel.Bind<CreatLegalClientPresenter>().ToSelf();
            kernel.Bind<VisualizeNuturalClientPresenter>().ToSelf();
            kernel.Bind<SelectLegalClientPresenter>().ToSelf();

            kernel.Bind<IClientDataService<NuturalClient>>().To<NuturalClientDataService>().InSingletonScope();
            kernel.Bind<NuturalClientDao>().ToSelf().InSingletonScope();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            kernel.Get<StartLoginPresenter>().Run();
            Application.Run(kernel.Get<ApplicationContext>());
            //Application.Run(new VisualizeNuturalClientFormView());
        }
    }
}
