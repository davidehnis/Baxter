using Baxter.Core.Applied;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baxter.Core.Types
{
    public class Test
    {
        public static Datum A()
        {
            return null;
        }

        public static Test This { get; }

        public Scenerio Scenerio(Scenerio scenerio)
        {
            return scenerio;
        }
    }

    //Test.This.Scenario<>(input).Where<T>.IsTheInput.And<T>.Uses<X>.ToComplete(Action);
}
