using System;
using System.Globalization;

namespace DateTimeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Avoid Datetime.Now because its the local time
            //If you are in different locations you will always get different times
            //Can cause problems
            var now = DateTime.Now;

            var sydneyTimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("E. Australia Standard Time");

            var sydneyTime = TimeZoneInfo.ConvertTime(now, sydneyTimeZoneInfo);

            Console.WriteLine(now);
            Console.WriteLine(sydneyTime);

            //How to parse Dates
            //Problem is 9 month or day? So we need to specify the date
            var date = "9/10/2019 10:00:00 PM";
            var parsedDate = DateTime.ParseExact(date, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);

            Console.WriteLine(parsedDate);

            //Handling poffset
            var dateWithOffset = "2019-07-01 10:00:00 PM +02:00";
            //Datetime parse is leveraging the local system's timezone
            //If we parse that date and print it out:
            var parsedDateWithOffset = DateTime.Parse(dateWithOffset);
            Console.WriteLine(parsedDateWithOffset);




        }
    }
}
