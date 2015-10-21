using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Org.Kevoree.Log.Api
{
    public interface ILoggerNode: ILogger
    {
        ILogger createInstance(string name);
    }
}
