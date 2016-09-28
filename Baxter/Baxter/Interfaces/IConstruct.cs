using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baxter.Interfaces
{
    public interface IConstruct
    {
        Guid Id { get; }

        IResponse Execute(IContext context, ICommand command);

        IResponse Initialize();

        bool IsValid();

        bool HasAccess(IContext context);

        IResponse Create();

        IHelp  Help { get; }

        IGroup<IRule> Rules { get; }
         
        IGroup<IContext> Contexts { get; }

        IGroup<ICommand> Commands { get; }
    }
}
