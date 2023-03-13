using ApplicationControllerExample.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationControllerExample.View
{
    public interface IStartFormView : IView
    {
        event Action RunMainForm;
        string SomeClassArg { get; }
    }
}
