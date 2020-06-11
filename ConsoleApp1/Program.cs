using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            
            DateTime today = DateTime.Today;
            string userRes = "yes";

            while (userRes == "yes")
            {

                Console.WriteLine("Enter a date of your birthday: ");
                DateTime userDate;
                if (DateTime.TryParse(Console.ReadLine(), out userDate))
                {

                    Console.WriteLine("The day of your birthday was: {0}", userDate.DayOfWeek);
                    int months = 0;
                    int days = 0;

                    DateTime nextBirthday = userDate.AddYears(today.Year - userDate.Year);

                    if (nextBirthday < today)
                    {
                        nextBirthday = nextBirthday.AddYears(1);
                    }


                    while (today.AddMonths(months + 1) <= nextBirthday)
                    {
                        months++;

                    }

                    days = nextBirthday.Subtract(today.AddMonths(months)).Days;

                    string wordMonths = "months";
                    string wordDays = "days";

                    if (months == 1)
                    {
                        wordMonths = "month";
                    }
                    if (days == 1)
                    {
                        wordDays = "day";
                    }
                    if (months >= 1 || days >= 1)
                    {
                        if (months == 0)
                        {
                            Console.WriteLine("Next birthday is in {0} {1}.", days, wordDays);
                        }
                        else if (days == 0)
                        {
                            Console.WriteLine("Next birthday is in {0} {1}.", months, wordMonths);
                        }
                        else
                        {
                            Console.WriteLine("Next birthday is in {0} {1} and {2} {3}.", months, wordMonths, days, wordDays);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Today is yours birthday. Happy birthday");
                    }

                    int age = today.Year - userDate.Year;
                    Console.WriteLine("You are {0} years old", age);
                    Console.WriteLine("Do you want to continue? [yes/no]");
                    userRes = Console.ReadLine().ToLower();
                }
                else
                {
                    Console.WriteLine("You have entered an incorrect value.");
                    Console.WriteLine("Do you want to continue? [yes/no]");
                    userRes = Console.ReadLine().ToLower();
                }

            }

        }
    }

}
