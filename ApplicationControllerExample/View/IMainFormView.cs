using ApplicationControllerExample.Common;
using ApplicationControllerExample.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationControllerExample.View
{
    public interface IMainFormView : IView
    {
        event Action RunChildForm;
        string SomeClassArg { get; set; }
    }
}
