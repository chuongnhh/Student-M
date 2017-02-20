using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess;

namespace BusinessLogic
{
    public class InitializeDatabase
    {
        public InitializeDatabase()
        {
            (new MasteringItDbContext()).Database.Initialize(true);
        }
    }
}
