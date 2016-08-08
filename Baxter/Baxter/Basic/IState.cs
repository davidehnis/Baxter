using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baxter.Basic
{
    public interface IState
    {
        Guid Id { get; }

        string Name { get; }

        string Description { get; }

        //<summary>The data and time the parent entered this state</summary>
        DateTime Entry { get; }
    }
}
