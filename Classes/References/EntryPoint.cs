using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DispatcherService.Classes
{
    public class EntryPoint
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public EntryPoint(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override bool Equals(object obj)
        {
            EntryPoint point = obj as EntryPoint;

            if (point != null)
                return Id.Equals(point.Id);

            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
