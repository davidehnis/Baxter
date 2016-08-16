using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baxter.Interfaces
{
    public interface IHelp
    {
        Guid Id { get; }

        string Short { get; }

        string Long { get; }
    }
}
