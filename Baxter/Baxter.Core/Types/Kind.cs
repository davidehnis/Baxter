using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Baxter.Core.Types
{
    public class Kind : ISerializable
    {
        protected static Dictionary<Kind, Instance> _kinds = new Dictionary<Kind, Instance>();

        public static Type KindOf(Kind kind)
        {
            return typeof(Kind);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

        protected void Register()
        {

        }
    }
}
