using Baxter.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baxter.Basic
{
    public class Identity : Construct
    {
        /// contains national id
        /// first name
        /// last name
        /// user name
        /// email address
        /// locale
        /// 

        public override static Identity Create()
        {
            return new Identity();
        }
    }
}
