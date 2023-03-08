using ApplicationControllerExample.Common;
using ApplicationControllerExample.Model;
using ApplicationControllerExample.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            View.Show();
        }
    }
}
