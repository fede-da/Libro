using System;
namespace PacktLibrary
{
	// "sealed" keyword prevents hineritance
	public sealed class ScroogeMcDuck
	{
		
	}

	public class Singer
	{
		public virtual void Sing()
		{

		}
	}

	public class LadyGaga : Singer
	{
		// Classes who extends LadyGaga cannot override
		// this method, beacuse it's "sealed"
		//N.B. : Only overridden method can be sealed
        public sealed override void Sing()
        {
			Console.WriteLine("Singing with style...");
        }
    }
}



