using System;

namespace Task_1st.DaysOfTheWeek
{
    public class Program
    {
        static void Main(string[] args)
        {
            sbyte userInput = ReadingInput();

            Console.WriteLine($"The {userInput} day of the week is {GetDayOfTheWeek(userInput)}.");  
        }
       
        static sbyte ReadingInput()
        {
            Console.WriteLine("Enter a whole number from 1 to 7");

            sbyte result;

            var isNumber = sbyte.TryParse(Console.ReadLine(), out result);

            if (!isNumber || result < 1 || result > 7)
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

        static string GetDayOfTheWeek(sbyte numberOfDay)
        {
            switch (numberOfDay)
            {
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                case 7:
                    return "Sunday";
                default:
                    return String.Empty;
            }
        }
    }
}
