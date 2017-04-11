using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DispatcherService
{
    public class ItemEventArgs : EventArgs
    {
        public object Item { get; private set; }

        private ItemEventArgs() : base() { }

        public ItemEventArgs(object item)
            : this()
        {
            Item = item;
        }
    }
}
