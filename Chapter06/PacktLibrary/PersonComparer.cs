using System;
namespace Packet.Shared
{
    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person? x, Person? y)
        {
            if (x == null || y == null) return 0;

            int ret = x.Name.Length.CompareTo(y.Name.Length);

            if (ret==0)
                return x.Name.CompareTo(y.Name);

            return ret;

        }
    }
}

