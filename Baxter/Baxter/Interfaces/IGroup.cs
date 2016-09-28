using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baxter.Interfaces
{
    public interface IGroup<T> : IConstruct
    {
        IResponse Add(T item);

        IResponse Remove(T item);
    }
}
