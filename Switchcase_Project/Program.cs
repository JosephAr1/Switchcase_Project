using System;

namespace Switchcase_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int Day_number;
            Console.WriteLine("Enter a number between 1 to 7, to check the day of a week");
            Day_number = Convert.ToInt32(Console.ReadLine());


            switch (Day_number)
            {
             case 1:
            Console.WriteLine(Day_number.ToString() + "st day of the week is Monday");
            break;

            case 2:
            Console.WriteLine(Day_number.ToString() + "nd Day of the week is Tuesday");
            break;
            case 3:
            Console.WriteLine(Day_number.ToString() + "rd Day of the week is Wednesday");
            break;
            case 4:
            Console.WriteLine(Day_number.ToString() + "th Day of the week is Thursday");
            break;
            case 5:
            Console.WriteLine(Day_number.ToString() + "th Day of the week is Friday");
            break;
            case 6:
            Console.WriteLine(Day_number.ToString() + "th Day of the week is Saturday");
            break;
            case 7:
            Console.WriteLine(Day_number.ToString() + "th Day of the week is Sunday");
            break;
            default:
            Console.WriteLine("You entered a wrong number");
            break;
            }         
            Console.WriteLine("Thank You");
        }
    }
}