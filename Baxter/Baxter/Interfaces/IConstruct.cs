using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baxter.Interfaces
{
    public interface IConstruct
    {
        IResponse Deploy();

        IResponse Execute(IContext context, ICommand command);

        IResponse Initialize();

        IResponse Cost();

        IResponse Changes();

        IResponse Features();

        IResponse Stats();
    }
}
