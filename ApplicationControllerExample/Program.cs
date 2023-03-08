using ApplicationControllerExample.Common;
using ApplicationControllerExample.Forms;
using ApplicationControllerExample.Presenter;
using ApplicationControllerExample.View;
using System;
using System.Windows.Forms;

namespace ApplicationControllerExample
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var controller = new ApplicationController(new LightInjectAdapter())
                 .RegisterView<IStartFormView, StartForm>()
                 .RegisterView<IMainFormView, MainForm>()
                 .RegisterView<IChildFormView, ChildForm>()
                 .RegisterInstance(new ApplicationContext());

            controller.Run<StartFormPresenter>(); 
        }
    }
}
