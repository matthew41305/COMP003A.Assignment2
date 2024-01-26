/* Author: Matthew Hudson
 * Course: COMP003A
 * Purpose: Programming Basics
 */
namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String Section
            Console.Title = "COMP-003A - Assignment 2";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            string firstName = Console.ReadLine();
            string middleName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string inputAge = Console.ReadLine();
            int yearBorn = 2024 - Convert.ToInt32(inputAge);
            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}. ");

            

        }
    }
}
