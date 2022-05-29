using System;

namespace Task_1st.MultipleTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            long output = ReadingInput();

            GetMultipTable(output);
        }
        static long ReadingInput()
        {
            Console.WriteLine("Enter a whole number to obtain a multiplication table");

            long result;

            var isNumber = long.TryParse(Console.ReadLine(), out result);

            if (!isNumber)
            {
                Console.WriteLine("Invalid value");

                return ReadingInput();
            }
            else
            {
                Console.Clear();

                return result;
            }
        }

        static void GetMultipTable(long userImput)
        {
            for (int i = 1; i <= 10; i++)
            {
                try
                {
                    checked
                    {
                        Console.WriteLine($"{userImput} x {i} = {userImput * i}");
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"The result of multiplication by {i} goes beyond the values of long");
                }

            }
        }
    }
}
