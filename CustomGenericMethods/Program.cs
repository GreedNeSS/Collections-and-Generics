using System;

namespace CustomGenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Henry", "Ford", 45);
            Person p2 = new Person("Homer", "Simonov", 49);

            Console.WriteLine($"Before Swap() p1: {p1}, p2: {p2}");
            GenericMethods.Swap<Person>(ref p1, ref p2);
            Console.WriteLine($"After Swap() p1: {p1}, p2: {p2}");

            string str1 = "Hello";
            string str2 = "World";

            Console.WriteLine($"Before Swap() str1: {str1}, str2: {str2}");
            GenericMethods.Swap<string>(ref str1, ref str2);
            Console.WriteLine($"After Swap() str1: {str1}, str2: {str2}");

            GenericMethods.DisplayBaseClass<Person>();
            GenericMethods.DisplayBaseClass<int>();
            GenericMethods.DisplayBaseClass<string>();
        }
    }
}
