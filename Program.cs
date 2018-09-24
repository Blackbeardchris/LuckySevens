using System;

namespace luckysevens
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] myArray = new string [] { "Learn" , "app", "development"};

            int [] intArray = new int [] {232, 455, 3422, 42564};

            string word = myArray[1];

            Console.WriteLine(word);

            int arrayLength = intArray.Length;

            Console.WriteLine(arrayLength.ToString());
        }
    }
}
