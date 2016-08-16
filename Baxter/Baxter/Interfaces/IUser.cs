using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baxter.Interfaces
{
    public interface IUser : IConstruct
    {
        string Name { get; }
    }
}
