using ApplicationControllerExample.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationControllerExample.View
{
    public interface IMainFormView : IView
    {
        event Action RunChildForm;
    }
}
