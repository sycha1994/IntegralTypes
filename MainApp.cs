using System;

namespace IntegralTypes
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string greeting = "Good morning.";

            Console.WriteLine(greeting.Substring(0, 5));
            Console.WriteLine(greeting.Substring(5));
            Console.WriteLine();

            string[] arr = greeting.Split(
                new string[] { " " }, StringSplitOptions.None);
            Console.WriteLine("Word Count : {0}", arr.Length);

            foreach (string element in arr)
                Console.WriteLine("{0}", element);
        }
    }
}
