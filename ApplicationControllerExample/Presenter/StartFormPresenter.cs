using ApplicationControllerExample.Common;
using ApplicationControllerExample.Model;
using ApplicationControllerExample.View;

namespace ApplicationControllerExample.Presenter
{
    public class StartFormPresenter : BasePresenter<IStartFormView>
    {
        public StartFormPresenter(IApplicationController controller, IStartFormView view) 
            : base(controller, view)
        {
            view.RunMainForm += () => RunMainForm();
        }

        private void RunMainForm()
        {
            var someclass = new SomeClass();
            Controller.Run<MainFormPresenter, SomeClass>(someclass);
            View.Close();   
        }
    }
}
