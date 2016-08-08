using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baxter.Interfaces
{
    public interface IResponse
    {
        string Request { get; }

        string Response { get; }

        string Error { get; }

        string Trace { get; }
    }
}
