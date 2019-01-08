using System;
using System.Windows.Forms;
using Ninject;
using Presenter;

namespace WindowsFormsApp1
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

            kernel.Bind<StartLoginPresenter>().ToSelf();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            kernel.Get<StartLoginPresenter>().Run();
            Application.Run(kernel.Get<ApplicationContext>());
        }
    }
}
