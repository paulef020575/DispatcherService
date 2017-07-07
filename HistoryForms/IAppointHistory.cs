using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DispatcherService
{
    public interface IAppointHistory
    {
        bool Expanded { get; }
        int Id { get; }
        string Vehicle { get; }
        string Driver { get; }
        string DriverPhone { get; }
        string Cargo { get; }
        string WhereTo { get; }
        DateTime DateFrom { get; }
        DateTime? DateTo { get; }
        string Operation { get; }
        string Point { get; }
        string Reason { get; }
    }
}
