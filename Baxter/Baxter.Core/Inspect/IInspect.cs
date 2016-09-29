using Baxter.Core.Constructs;
using Baxter.Core.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baxter.Core.Inspect
{
    public interface IInspect
    {
        Kind UnderlyingSystemKind { get; }

        Instance Invoke(string name,
                        BindingFlags invokeAttr,
                        Binder binder,
                        object target,
                        object[] args,
                        ParameterModifier[] modifiers,
                        Culture culture,
                        string[] namedParameters);

        Kind Method(string name);

        Kind Property(string name);

        Kind Properties();

    }
}
