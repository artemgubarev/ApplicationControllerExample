using ApplicationControllerExample.Common;
using ApplicationControllerExample.Model;
using ApplicationControllerExample.View;
using System.Diagnostics;

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
            Controller.RunWithRef<ChildFormPresenter, SomeClass>(ref _someClass); 
        }

        public override void Run(SomeClass argument)
        {
            _someClass = argument;
            View.SomeClassArg = _someClass.SomeField;
            View.Show();

            _someClass.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == nameof(_someClass.SomeField))
                {
                    View.SomeClassArg = _someClass.SomeField;
                }
            };
        }

        public override void RunWithRef(ref SomeClass argument)
        {
            throw new System.NotImplementedException();
        }
    }
}
