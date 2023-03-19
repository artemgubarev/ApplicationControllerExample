using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationControllerExample.Common
{
    public interface IPresenter
    {
        void Run();
    }

   // public interface IPresenter<in TArg>
    public interface IPresenter<TArg>
    {
        void Run(TArg argument);
        void RunWithRef(ref TArg argument);
    }
}
