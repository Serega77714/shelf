using System;

namespace Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string con = "Y";
            for (;con == "Y" || con == "y";)
            {
                Console.WriteLine("Enter the number of the day of the week");
                string number = Console.ReadLine();
                Console.WriteLine(Week(number));
                Console.WriteLine("Will you continue?-Y/N");
                con = Console.ReadLine();
             }
                           
        }

              static string Week(string number)
        {
            
                switch (number)
                {
                    case "1": return "Monday";
                        break;
                    case "2":
                    return "Tuesday";
                        break;
                    case "3":
                    return "Wednesday";
                        break;
                    case "4":
                    return "Thursday";
                        break;
                    case "5":
                    return "Friday";
                        break;
                    case "6":
                    return "Saturday";
                        break;
                    case "7":
                    return"Sunday";
                        break;
                   default:
                    return "Entered incorrect day of week ";
                    break;
                }
           
                
        }
    }
}
