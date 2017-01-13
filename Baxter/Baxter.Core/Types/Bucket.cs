using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baxter.Core.Types
{
    public class Bucket
    {
        protected Dictionary<Identifier, Instance> _bucket = new Dictionary<Identifier, Instance>();
        protected Kind _kind = new Kind();

        public Bucket(Kind kind)
        {
            _kind = kind;
        }

        public void Add(Parameter param)
        {

        }

        public void Remove(Parameter param)
        {

        }

        public Instance this[Identifier id]
        {
            get
            {
                return GetValue(key);
            }
            set
            {
                SetValue(key, value);
            }
        }

        protected Instance GetValue(Identifier id)
        {
            if ( _bucket.ContainsKey(id) )
            {
                return _bucket[id];
            }


        }

        public Kind Kind
        {
            get
            {
                return _kind;
            }
        }

        protected void SetValue(Instance instance)
        {

        }
    }
}
