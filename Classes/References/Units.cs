using System;
using System.Collections.Generic;
using System.Text;
using EPV.Data;
using EPV.Database;

namespace DispatcherService
{
    public class Units : EPVList<Unit>
    {
        public Units(EPVDatabase database) : base(database) { }
    }
}
