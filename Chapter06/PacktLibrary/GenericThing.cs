using System;
namespace Packet.Shared
{
	public class GenericThing<T> where T : IComparable
	{
        public T? Data = default(T);

        public string Process(T input) =>
            Data.CompareTo(input)==0
                ? "Same"
                : "Not same";

    }
}

