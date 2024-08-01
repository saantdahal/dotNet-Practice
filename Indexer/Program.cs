using System;

namespace Indexer
{
    internal class Program
    {
        public class TempRecord
        {
            // Array of temperature values
            private float[] temps = new float[] { 56.2f, 55.6f, 40f };

            // Indexer declaration with get and set accessors
            public float this[int index]
            {
                get
                {
                    if (index < 0 || index >= temps.Length)
                    {
                        throw new IndexOutOfRangeException("Index is out of range.");
                    }
                    return temps[index];
                }
                set
                {
                    if (index < 0 || index >= temps.Length)
                    {
                        throw new IndexOutOfRangeException("Index is out of range.");
                    }
                    temps[index] = value;
                }
            }
        }

        static void Main(string[] args)
        {
            // Create an instance of TempRecord
            var tempRecord = new TempRecord();

            // Safely set values within the array bounds
            try
            {
                tempRecord[0] = 58.3F;
                tempRecord[1] = 60.1F;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Use the indexer's get accessor
            for (int i = 0; i < 3; i++) // Use 3 since temps has 3 elements
            {
                Console.WriteLine($"Element #{i} = {tempRecord[i]}");
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
