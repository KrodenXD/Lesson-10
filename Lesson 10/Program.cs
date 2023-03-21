using System;

namespace Lesson_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods methods = new Methods();
            string name = Convert.ToString(Console.ReadLine());
            string surname = Convert.ToString(Console.ReadLine());
            Console.WriteLine(methods.IsValid(name));
            Console.WriteLine(methods.IsValid(surname));
        }
    }
}
