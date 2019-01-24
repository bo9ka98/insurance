using System;
using System.Windows.Forms;
using Ninject;
using Presenter;
using Presenter.Presenters;
using Presenter.Views;
using Model.service;
using Model.entity;
using Model.dao;


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

            // registr user for issue police
            kernel.Bind<ISearchIndividClientView>().To<SearchNuturalClientFormView>();
            kernel.Bind<ISearchLegalClientView>().To<SearchLegalClientFormView>();
            kernel.Bind<ICreatIndividClienView>().To<CreatNuturalClienFormView>();
            kernel.Bind<ICreatLegalClientView>().To<CreatLegalClientFormView>();
            kernel.Bind<IVisualizeNuturalClientView>().To<VisualizeNuturalClientFormView>();
            kernel.Bind<IVisualizeLegalClientView>().To<VisualizeLegalClientFormView>();

            // new police
            kernel.Bind<INewPoliceCategoriView>().To<NewPoliceCategoriForm>();
            kernel.Bind<INewInsuranceCasesView>().To<NewInsuranceCasesForm>();

            kernel.Bind<StartLoginPresenter>().ToSelf();
            kernel.Bind<WorkMenuPresenter>().ToSelf();

            kernel.Bind<SearchIndividClientPresenter>().ToSelf();
            kernel.Bind<CreatIndividClienPresenter>().ToSelf();
            kernel.Bind<VisualizeNuturalClientPresenter>().ToSelf();
            kernel.Bind<SelectLegalClientPresenter>().ToSelf();

            //new police
            kernel.Bind<NewPoliceCategoriPresenter>().ToSelf();
            kernel.Bind<NewInsuranceCasesPresenter>().ToSelf();

            //service
            kernel.Bind<IClientDataService<IndividClient>>().To<ClientDataService>().InSingletonScope();
            kernel.Bind<IndividClientDao>().ToSelf().InSingletonScope();
            kernel.Bind<UserControlService>().ToSelf().InSingletonScope();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            kernel.Get<StartLoginPresenter>().Run();
            Application.Run(kernel.Get<ApplicationContext>());
            //Application.Run(new VisualizeNuturalClientFormView());
        }
    }
}
