using System;

namespace CollectionExercises
{
    class Test
    {
        static void Main(string[] args)
        {
            var names = new[] {"Hello","SUPERMAN"};
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }
}
