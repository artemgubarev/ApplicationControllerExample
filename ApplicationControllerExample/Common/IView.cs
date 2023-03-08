using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationControllerExample.Common
{
    public interface IView
    {
        void Show();
        void Close();
    }
}
