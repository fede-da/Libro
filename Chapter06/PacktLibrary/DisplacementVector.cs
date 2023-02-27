using System;
namespace Packet.Shared
{
	public struct DisplacementVector
	{
		public int x;
		public int y;

		public DisplacementVector(int inX,int inY)
		{
			x = inX;
			y = inY;
		}

		public static DisplacementVector operator +(
			DisplacementVector vector1,
            DisplacementVector vector2)
		{
			return new DisplacementVector(
			vector1.x + vector2.y,
			vector1.y + vector2.x);
		}
	}
}

