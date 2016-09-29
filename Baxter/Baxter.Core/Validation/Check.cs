using Baxter.Core.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baxter.Core
{
    public class Check : Construct
    {
        public static Kind That(Kind type)
        {
            return Kind.KindOf(type);
        }
    }
}
