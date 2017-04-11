using System;
using System.Collections.Generic;
using System.Text;
using EPV.Data;
using EPV.Database;

namespace DispatcherService
{
    public class Cargos : EPVList<Cargo>
    {
        public Cargos(EPVDatabase database) : base(database) { }
    }
}
