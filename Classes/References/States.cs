using System;
using System.Collections.Generic;
using System.Text;
using EPV.Data;
using EPV.Database;

namespace DispatcherService
{
    public class States : EPVList<State>
    {
        public States(EPVDatabase database) : base(database) { }
    }
}
