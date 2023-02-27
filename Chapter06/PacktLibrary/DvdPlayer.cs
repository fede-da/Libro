using static System.Console;

namespace Packet.Shared
{
	public class DvdPlayer:IPlayable
	{
		public DvdPlayer()
		{
		}

        public void Pause()
        {
            WriteLine("Dvd player pausing");
        }

        public void Play()
        {
            WriteLine("Dvd player is playing");
        }
    }
}

