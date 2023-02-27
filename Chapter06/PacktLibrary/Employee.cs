using System;
namespace Packet.Shared
{
	public class Employee:Person
	{
		public string EmployeeCode { get; set; }
		public DateTime HireDate { get; set; }

		// new keyword here """overrides""" the inherited method
		// usually it is better to override rather than hide using "virtual"
		public new void WriteToConsole()
		{
			Console.WriteLine("This method hides the inherited one");
		}

        public override string ToString()
        {
			// "base" keyword allows to access superclass
			return $"{Name} is a {base.ToString()}";
        }
    }
}

