using System.ComponentModel;

namespace TabAsocjacyjna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person1> list = new List<Person1>()
            { 
                new Person1{ Name = "Xena", Age = 21, Salary = 3400 },
                new (){ Name = "Star", Age = 35, Salary = 4321 }

             };

            list.Add(new Person1{ Name = "Bob", Age = 23, Salary = 2700 });
            list.Add(new Person1 { Name = "John", Age = 56, Salary = 3600 });
            list.Add(new Person1 { Name = "Andrea", Age = 32, Salary = 4500 });
            list.Add(new Person1 { Name = "Lucia", Age = 65, Salary = 3750 });
            list.Add(new Person1 { Name = "Aga", Age = 29, Salary = 5623 });


            double sum = list.Sum(x => x.Salary);
            double min = list.Min(x => x.Salary);
            double max = list.Max(x => x.Salary);
            double avg = list.Average(x => x.Salary);

            int dim = list.Count();

            var sortedList = list.OrderBy(x => x.Salary).ToList();
            var revSortedList = list.OrderByDescending(x => x.Salary).ToList();

            foreach (var x in sortedList) 
            { 
               Console.WriteLine( x.Name +"|"+ x.Salary +"|"+ x.Age);
            }



            Person[] termin = GetTable();

            foreach (Person person in termin)
            { 
                Console.WriteLine(person.Name + "|" + person.Age + "|" + person.Salary); 
            }

        }

        static Person[] GetTable()
        {
            List<Person> people = new List<Person>() 
            { 
                new Person("Itaka",35,23452),
                new Person("Atena", 46, 34343)
         
            };
                people.Add(new Person ( "Bob", 23, 25670));
                people.Add(new Person ( "Alice", 34, 3577));
                people.Add(new Person ( "Peter", 27, 5634));
                people.Add(new Person ("Andrea", 45, 4532));

            return people.ToArray();
        }
    }
}
