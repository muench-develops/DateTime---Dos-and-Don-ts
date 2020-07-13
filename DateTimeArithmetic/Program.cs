using System;
using System.Globalization;

namespace DateTimeArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            // represents a time interval
            var timeSpan = new TimeSpan(60,100,200);
            // Timespan converts all inputs to a representation of an actual time
            // It automatically calculates correct amount of days, hours, minutes, seconds, milliseconds and ticks based on data 
            //Console.WriteLine(timeSpan.Days);
            //Console.WriteLine(timeSpan.Hours);
            //Console.WriteLine(timeSpan.Minutes);
            //Console.WriteLine(timeSpan.Seconds);

            //How to use Timespan
            var startDate = DateTimeOffset.UtcNow;
            var endDate = startDate.AddSeconds(50);

            TimeSpan difference = endDate - startDate;

            Console.WriteLine($"Difference in Seconds {difference.Seconds}");

            //Get week of Year
            var isoWeek = ISOWeek.GetWeekOfYear(startDate.DateTime);
            Console.WriteLine($"It's Calendar Week: {isoWeek}");

            //Extend Contract - Adding only 30 days can be false, if you for example want a contract to end at the end of a month
            var contractdateToExtend = new DateTimeOffset(2020, 2, 28, 0, 0, 0, TimeSpan.Zero);
            Console.WriteLine($"Extending Date {contractdateToExtend}. After adding 1 Month it will extend at {contractdateToExtend.extendContract(1)}");

        }
    }
}
