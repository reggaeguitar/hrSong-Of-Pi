namespace hrSong_Of_Pi
{
    using System;
    using System.Linq;

    class Program
    {
        private static readonly int[] DigitsOfPi = 
        { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 8, 9, 7, 9, 3, 2, 3, 8, 4, 6, 2, 6, 4, 3, 3, 8, 3, 3 };

        static void Main()
        {
            int numCases = Int32.Parse(Console.ReadLine());
            while (numCases-- > 0)
            {
                var words = Console.ReadLine().Split(' ');
                Console.WriteLine(words.Where((word, i) => word.Length != DigitsOfPi[i]).Any()
                    ? "It's a pi song."
                    : "It's not a pi song.");
            }
        }
    }
}
