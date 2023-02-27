using System;
using Packet.Shared;

namespace ConsoleApp
{
    public class Chapter06Body
    {
        delegate int DelegateWithMatchingSignature(string s);

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello from ConsoleApp!");

            // Delegate examples
            Person p = new Person() { Name = "Nick" };
            var d = new DelegateWithMatchingSignature(p.MethodIWantToCall);
            Console.WriteLine($"Delegate has counted: {d(p.Name)} letters in {p.Name}");
            Person[] people =
            {
                new Person{Name="Matt"},
                new Person{Name="Megumin"},
                new Person{Name="Kaguya-sama"},
                new Person{Name="Gol.D Roger"},
            };

            Console.WriteLine("Who's here? (Unsorted)");
            foreach (var person in people)
                Console.WriteLine($"{person.Name}");
            Console.WriteLine($"Let's sort this array with compareTo");
            Array.Sort(people);
            foreach (var person in people)
                Console.WriteLine($"{person.Name}");
            Console.WriteLine($"And now with Compare (ordered by length)");
            Array.Reverse(people);
            Array.Sort(people, new PersonComparer());
            foreach (var person in people)
                Console.WriteLine($"{person.Name}");

            //  Not Generics
            var t1 = new Thing();
            t1.Data = 42;
            Console.WriteLine($"Thing with an integer: {t1.Process(42)}");

            var t2 = new Thing();
            t2.Data = "apple";
            Console.WriteLine($"Thing with a string: {t2.Process("apple")}");

            // Generics

            var gt1 = new GenericThing<int>();
            gt1.Data = 42;
            Console.WriteLine($"GenericThing with an integer: {gt1.Process(42)}");

            var gt2 = new GenericThing<string>();
            gt2.Data = "apple";
            Console.WriteLine($"Thing with a string: {gt2.Process("apple")}");

            // Generics method

            string number1 = "4";

            Console.WriteLine("{0} squared is {1}",
                arg0:number1,
                arg1:Squarer.Square<string>(number1));

            byte number2 = 3;
            Console.WriteLine("{0} squared is {1}",
                arg0: number2,
                //compiler can work it out on its own
                arg1: Squarer.Square(number2));

            // Working with struct
            var dv1 = new DisplacementVector(3, 5);
            var dv2 = new DisplacementVector(3, 5);
            var dv3 = dv1 + dv2;

            Console.WriteLine(
                $"({dv1.x},{dv1.y}) + ({dv2.x},{dv2.y}) = ({dv3.x},{dv3.y})");

            // Inheritance
            Employee john = new Employee {
                Name = "John",
                DateOfBirth=new DateTime(1990,3,28)
            };

            john.WriteToConsole();
            john.EmployeeCode = "fujnrn";
            john.HireDate = new DateTime(2014, 11, 23);
            Console.WriteLine($"{john.Name} was hired on {john.HireDate:dd/MM/yy}");

            // static inheritance
            string email1 = "pamela@test.com";
            string email2 = "pamela&test.com";

            Console.WriteLine(
                "{0} is a valid e-mail address: {1}",
                arg0: email1,
                arg1: email1.IsValidEmail());

            Console.WriteLine(
                "{0} is a valid e-mail address: {1}",
                arg0: email2,
                arg1: email2.IsValidEmail());
        }
    }
}