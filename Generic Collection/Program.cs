using System;
using System.Collections.Generic;

namespace Generic_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            UseGenericList();
            Console.WriteLine();

            UseGenericStack();
            Console.WriteLine();

            UseGenericQueue();
            Console.WriteLine();

            UseSortedSet();
            Console.WriteLine();

            UseDictionary();
            Console.WriteLine();
        }

        private static void UseGenericList()
        {
            List<Person> people = new List<Person>
            {
                new Person("Homer", "Simpson", 47),
                new Person("Marge", "Simpson", 45),
                new Person("Lisa", "Simpson", 9),
                new Person("Bart", "Simpson", 8),
            };

            Console.WriteLine($"Items in List: {people.Count}");

            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\n->Inserting new Person: " +
                "new Person(\"Maggie\", \"Simpson\", 2))");
            people.Insert(2, new Person("Maggie", "Simpson", 2));
            Console.WriteLine($"Items in List: {people.Count}");

            people.ForEach(p =>
            {
                Console.WriteLine(p);
            });

            Person[] arrayOfPeople = people.ToArray();
            Console.WriteLine("\npeople.ToArray()");

            foreach (var item in arrayOfPeople)
            {
                Console.WriteLine(item);
            }
        }

        private static void UseGenericStack()
        {
            Stack<Person> stackOfPeople = new Stack<Person>();

            stackOfPeople.Push(new Person("Homer", "Simpson", 47));
            stackOfPeople.Push(new Person("Marge", "Simpson", 45));
            stackOfPeople.Push(new Person("Lisa", "Simpson", 9));

            Console.WriteLine("\nStack iteration");

            foreach (var item in stackOfPeople)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Count people: {stackOfPeople.Count}");
            Console.WriteLine($"Fist person is: {stackOfPeople.Peek()}");
            Console.WriteLine($"Popped of {stackOfPeople.Pop()}");
            Console.WriteLine($"Fist person is: {stackOfPeople.Peek()}");
            Console.WriteLine($"Popped of {stackOfPeople.Pop()}");
            Console.WriteLine($"Fist person is: {stackOfPeople.Peek()}");
            Console.WriteLine($"Popped of {stackOfPeople.Pop()}");

            Console.WriteLine($"\nstackOfPeople.Count: {stackOfPeople.Count}");
            try
            {
                Console.WriteLine($"Fist person is: {stackOfPeople.Peek()}");
                Console.WriteLine($"Popped of {stackOfPeople.Pop()}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\n->Error: {e.Message}");
            }
        }

        private static void UseGenericQueue()
        {
            Queue<Person> queue = new Queue<Person>();
            queue.Enqueue(new Person("Homer", "Simpson", 47));
            queue.Enqueue(new Person("Marge", "Simpson", 45));
            queue.Enqueue(new Person("Lisa", "Simpson", 9));

            Console.WriteLine($"\n-> queue.Count: {queue.Count}");
            Console.WriteLine($"queue.Peek(): {queue.Peek()}");
            Console.WriteLine($"queue.Dequeue(): {queue.Dequeue()}");
            Console.WriteLine($"queue.Peek(): {queue.Peek()}");
            Console.WriteLine($"queue.Dequeue(): {queue.Dequeue()}");
            Console.WriteLine($"queue.Peek(): {queue.Peek()}");
            Console.WriteLine($"queue.Dequeue(): {queue.Dequeue()}");

            Console.WriteLine("queue.TryPeek(): {0}", 
                queue.TryPeek(out Person person) 
                ? person : "the queue is over");
            Console.WriteLine("queue.TryDequeue(): {0}",
                queue.TryDequeue(out Person person1) 
                ? person1 : "the queue is over");
        }

        private static void UseSortedSet()
        {
            SortedSet<Person> setOfPerson = new SortedSet<Person>(new SortPeopleByAge())
            {
                new Person("Homer", "Simpson", 47),
                new Person("Marge", "Simpson", 45),
                new Person("Lisa", "Simpson", 9),
                new Person("Bart", "Simpson", 8),
            };

            Console.WriteLine("\n-> SortedSet:");

            foreach (var person in setOfPerson)
            {
                Console.WriteLine(person);
            }

            setOfPerson.Add(new Person("Saku", "Jones", 1));
            setOfPerson.Add(new Person("Mikko", "Jones", 32));
            setOfPerson.Add(new Person("Mikko", "Jones", 2));
            setOfPerson.Add(new Person("Ruru", "Huea", 32));

            Console.WriteLine();

            foreach (var person in setOfPerson)
            {
                Console.WriteLine(person);
            }
        }

        private static void UseDictionary()
        {
            Console.WriteLine("\n-> Dictionary:");

            Dictionary<string, Person> peopleA = new Dictionary<string, Person>();
            peopleA.Add("Homer", new Person("Homer", "Simpson", 47));
            peopleA.Add("Marge", new Person("Marge", "Simpson", 45));
            peopleA.Add("Lisa", new Person("Lisa", "Simpson", 9));
            peopleA.Add("Bart", new Person("Bart", "Simpson", 8));

            Person homer = peopleA["Homer"];
            Console.WriteLine(homer);

            Dictionary<string, Person> peopleB = new Dictionary<string, Person>
            {
                { "Homer", new Person("Homer", "Simpson", 47) },
                { "Marge", new Person("Marge", "Simpson", 45) },
                { "Lisa", new Person("Lisa", "Simpson", 9) },
                { "Bart", new Person("Bart", "Simpson", 8) },
            };

            Person marge = peopleB["Marge"];
            Console.WriteLine(marge);

            Dictionary<string, Person> peopleC = new Dictionary<string, Person>
            {
                ["Homer"] = new Person("Homer", "Simpson", 47),
                ["Marge"] = new Person("Marge", "Simpson", 45),
                ["Lisa"] = new Person("Lisa", "Simpson", 9),
                ["Bart"] = new Person("Bart", "Simpson", 8),
            };

            Person bart = peopleC["Bart"];
            Console.WriteLine(bart);
        }
    }
}
