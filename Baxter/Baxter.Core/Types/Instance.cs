using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baxter.Core.Types
{
    public class Instance : Construct
    {
        protected object _instance = new object();

        public static implicit operator string(Foo theFoo)
        {
            return theFoo.Value;
        }

        public static Construct Cast(Instance x)
        {
            return new Instance(x);
        }

        public static implicit operator Construct(Test x)
        {
            return new Core.Construct(x);
        }
    }
}
