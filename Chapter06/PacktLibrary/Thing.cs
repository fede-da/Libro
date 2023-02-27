using System;
namespace Packet.Shared
{
	public class Thing
	{
		public object? Data = default(object);

		public string Process(object input) =>
			Data == input
				? "Same"
				: "Not same";

	}
}

