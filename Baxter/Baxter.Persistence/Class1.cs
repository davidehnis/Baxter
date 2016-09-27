using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baxter.Persistence
{
    public class Inclass
    {
        public void Go()
        {
            var connection = new SQLiteConnection("Data Source =:memory:; Version = 3; New = True; DateTimeFormat = Ticks");

            connection.
        }
    }
}
