using Baxter.Core.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baxter.Core
{
    //<summary>a basic set of information</summary>
    public class Construct : Kind
    {
        protected object Indicate { get; set; }
        
        public bool IsNull { get; }

        public bool IsBlank { get; }
        
        public virtual Kind Kind()
        {
            return this;
        }

       

        public static Construct operator =(Construct right)
        {
            this = right;
        }
    }
}
