using System;

namespace HolidayAndWeekendApp
{
    class Program
    {
        static void Main(string[] args)
        {      
            try
            {
                bool runApp = true;
                while (runApp)
                {
                    Console.WriteLine("Enter a date to see if it is a working day or not!");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("Enter your date in the following format DD-MM-YYYY");

                    string inputDate = Console.ReadLine();                    
                    bool tryParseDate = DateTime.TryParse(inputDate, out DateTime parsedDate);                                  

                    if (tryParseDate == true)
                    {
                        Console.WriteLine($"You entered: {parsedDate}");
                        Console.WriteLine("--------------------------------------------------");
                        if ((parsedDate.Day == 1 && parsedDate.Month == 1) || (parsedDate.Day == 7 && parsedDate.Month == 1) || (parsedDate.Day == 20 && parsedDate.Month == 4) || (parsedDate.Day == 1 && parsedDate.Month == 5) || (parsedDate.Day == 25 && parsedDate.Month == 5) || (parsedDate.Day == 3 && parsedDate.Month == 8) || (parsedDate.Day == 8 && parsedDate.Month == 9) || (parsedDate.Day == 12 && parsedDate.Month == 10) || (parsedDate.Day == 23 && parsedDate.Month == 10) || (parsedDate.Day == 8 && parsedDate.Month == 12) || parsedDate.DayOfWeek == DayOfWeek.Saturday || parsedDate.DayOfWeek == DayOfWeek.Sunday)
                        {
                            Console.WriteLine("Non-working day");
                        }
                        else
                        {
                            Console.WriteLine("Go to work! :)");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, try again. Use numbers only, and try to be careful about the order of the numbers and spaces");
                    }
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("Enter X to exit, or press anything else to continue checking dates:");                    
                    string exit = Console.ReadLine();
                    if (exit.ToUpper() == "X") Environment.Exit(0);
                    Console.Clear();
                }
                                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
