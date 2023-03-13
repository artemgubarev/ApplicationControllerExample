using ApplicationControllerExample.Common;
using ApplicationControllerExample.Model;
using ApplicationControllerExample.View;

namespace ApplicationControllerExample.Presenter
{
    public class MainFormPresenter : BasePresenter<IMainFormView, SomeClass>
    {
        SomeClass _someClass;

        public MainFormPresenter(IApplicationController controller, IMainFormView view) 
            : base(controller, view)
        {
            View.RunChildForm += () => RunChildForm();
        }

        private void RunChildForm()
        {
            Controller.Run<ChildFormPresenter, SomeClass>(_someClass);
        }

        public override void Run(SomeClass argument)
        {
            _someClass = argument;
            View.SomeClassArg = _someClass.SomeField;
            View.Show();
        }
    }
}
