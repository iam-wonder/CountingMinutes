using System;

namespace CountingMinutes
{
    internal class Program
    {
        public static string minuteCount(string str) 
        { 
            return str; 
        } 
        static void Main(string[] args)
        {
            Console.Write("Enter the time seperated by - :");
            string x = Console.ReadLine();
            
            string[] safe=x.ToUpper().Split("-");
            int temp1=0; 
            if (safe[0].Contains("PM"))
            {
                temp1 = safe[0].IndexOf("PM");
            } 
            else if (safe[0].Contains("AM"))
            {
                temp1 = safe[0].IndexOf("AM");
            }
            DateTime time1 = DateTime.ParseExact(safe[0],"h:mm tt", null);
        //  DateTime time2 = DateTime.ParseExact(safe[1],"hh:mm tt", null); 

            /*TimeSpan timeDifference = time1.Subtract(time2);
            int minutes = (int)timeDifference.TotalMinutes;*/

           // Console.WriteLine(minutes);
            Console.WriteLine(time1);
            Console.WriteLine(temp1);
            Console.ReadKey();

        }
    }
}
