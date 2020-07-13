using System;

namespace DateTimeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datetime Now, wenn möglich immer vermeiden, da local Zeit
            var now = DateTime.Now;

            TimeZoneInfo sydneyTimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("E. Australia Standard Time");

            var sydneyTime = TimeZoneInfo.ConvertTime(now, sydneyTimeZoneInfo);

            Console.WriteLine(now);
            Console.WriteLine(sydneyTime);

        }
    }
}
