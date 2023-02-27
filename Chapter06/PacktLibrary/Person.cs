
namespace Packet.Shared
{

    public class Person : IComparable<Person> // Compare 2 person
    {
        public string Name = "Empty";
        public DateTime DateOfBirth;
        public List<Person> Children = new List<Person>();

        public void WriteToConsole()
        {
            Console.WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }

        // This method is available al Type Level (static)
        public static Person Procreate(Person p1, Person p2)
        {
            var baby = new Person
            {
                Name = $"Baby of {p1.Name} and {p2.Name}"
            };
            p1.Children.Add(baby);
            p2.Children.Add(baby);
            return baby;
        }

        //This method is available at Object level
        public Person ProcreateWith(Person partner)
        {
            return Procreate(this, partner);
        }

        public static Person operator *(Person p1, Person p2)
        {
            return Person.Procreate(p1, p2);
        }

        public static int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException(
                    $"{nameof(number)} cannot be less than zero");
            }
            return localFactorial(number);

            int localFactorial(int localNumber)
            {
                if (localNumber < 1) return 1;
                return localNumber * localFactorial(localNumber - 1);
            }
        }

        public int MethodIWantToCall(string input) => input.Length;

        public int CompareTo(Person? other) => other == null ? 0 : Name.CompareTo(other.Name);

        //raises exception
        public void TimeTravel(DateTime when)
        {
            if(when<= DateOfBirth)
            {
                throw new PersonException("Can't travel so back so far");
            }
            else
            {
                Console.WriteLine("Let's go!");
            }
        }
    }
}
