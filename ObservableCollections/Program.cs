using System;
using System.Collections.ObjectModel;

namespace ObservableCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<Person> observableCollections = new ObservableCollection<Person>
            {
                new Person("Henry", "Ford", 76),
                new Person("Homer", "Simpson", 49),
            };

            observableCollections.CollectionChanged += people_CollectionChanged;

            observableCollections.Add(new Person("Ruslan", "Ivanov", 45));
            observableCollections.RemoveAt(0);
            observableCollections.Move(0, 1);
            observableCollections[0] = new("Marcus", "Aurelius", 65);

            Console.WriteLine();
            foreach (var item in observableCollections)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            observableCollections.Clear();
        }

        private static void people_CollectionChanged(object sender,
            System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine($"Action for this event: {e.Action}");

            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    Console.WriteLine("Here are the NEW items:");
                    foreach (var item in e.NewItems)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    Console.WriteLine("Here are the OLD items:");
                    foreach (var item in e.OldItems)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
                    Console.WriteLine("Here are the OLD items:");
                    foreach (var item in e.OldItems)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Here are the NEW items:");
                    foreach (var item in e.NewItems)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
                    Console.WriteLine("Here are the OLD items:");
                    foreach (var item in e.OldItems)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Here are the NEW items:");
                    foreach (var item in e.NewItems)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
                    Console.WriteLine(sender.ToString());
                    break;
            }
        }
    }
}
