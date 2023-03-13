using ApplicationControllerExample.Common;
using ApplicationControllerExample.Model;
using ApplicationControllerExample.View;

namespace ApplicationControllerExample.Presenter
{
    public class ChildFormPresenter : BasePresenter<IChildFormView, SomeClass>
    {
        SomeClass _someClass;

        public ChildFormPresenter(IApplicationController controller, IChildFormView view) 
            : base(controller, view)
        {
        }

        public override void Run(SomeClass argument)
        {
            _someClass = argument;
            View.SomeClassArg = _someClass.SomeField;
            View.Show();
        }
    }
}
