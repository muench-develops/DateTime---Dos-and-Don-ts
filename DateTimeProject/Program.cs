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
            //var now = DateTime.Now;

            //var sydneyTimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("E. Australia Standard Time");

            //var sydneyTime = TimeZoneInfo.ConvertTime(now, sydneyTimeZoneInfo);

            //Console.WriteLine(now);
            //Console.WriteLine(sydneyTime);


            //DateTimeOffset should be preferred over using DateTime
            //Console.WriteLine(DateTime.Now);
            //Contains timezone and provides offset based on UTC
            //Console.WriteLine(DateTimeOffset.Now); 

            //How to parse Dates
            //Problem is 9 month or day? So we need to specify the date
            //const string date = "9/11/2019 12:00:00 PM";
            //var parsedDate = DateTime.ParseExact(date, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);

            //Console.WriteLine(parsedDate);

            //Handling offset
            const string dateWithOffset = "2019-08-02 10:00:00 PM +02:00";
            //Datetime parse is leveraging the local system's timezone
            //If we parse that date and print it out:
            var parsedDateWithOffset = DateTime.Parse(dateWithOffset);
            // +02:00 will be converted in local timezone, so it could happen that the date will actually change based on the timezone you're living in.
            Console.WriteLine(parsedDateWithOffset);
            //Shows us if it was unspecified, local or utc
            Console.WriteLine(parsedDateWithOffset.Kind);

            var parsedDateWithOffsetUtc = DateTime.Parse(dateWithOffset, 
                CultureInfo.InvariantCulture, 
                DateTimeStyles.AdjustToUniversal);

            Console.WriteLine(parsedDateWithOffsetUtc);
            Console.WriteLine(parsedDateWithOffsetUtc.Kind);


            //How to format datetime in ISO8601
            //Recommend: If you save your data in text file, database or send it across the world
            const string dateToFormat = "10/11/2019 11:00:00 PM";
            var parsedDateToFormat =
                DateTimeOffset.ParseExact(dateToFormat, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
            var formattedDateToFormat = parsedDateToFormat.ToOffset(TimeSpan.FromHours(10));
            Console.WriteLine(formattedDateToFormat.ToString("O"));


            //You should work with DateTimeOffset (Contains the offset to UTC) and UTC / ISO 8601

        }
    }
}
