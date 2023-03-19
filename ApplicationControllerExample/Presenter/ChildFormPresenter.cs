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
            view.SameArgTextChange += (text) => SameArgTextChange(text);
        }

        private void SameArgTextChange(string text)
        {
            _someClass.SomeField = text;
        }

        public override void Run(SomeClass argument)
        {
            throw new System.NotImplementedException();
        }

        public override void RunWithRef(ref SomeClass argument)
        {
            _someClass = argument;
            View.SomeClassArg = _someClass.SomeField;
            View.Show();
        }

        

    }
}
