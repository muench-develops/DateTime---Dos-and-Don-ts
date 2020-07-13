using System;
using System.Collections.Generic;
using System.Text;

namespace DateTimeArithmetic
{
    static class extendDateTimeOffset
    {
        public static DateTimeOffset extendContract(this DateTimeOffset current, int months)
        {
            //Get the previous day at 11:59 pm of the wished ending day
            var newContractDate = current.AddMonths(months).AddTicks(-1);

            return new DateTimeOffset(newContractDate.Year, //new ending year
                newContractDate.Month, // new ending month
                DateTime.DaysInMonth(newContractDate.Year, newContractDate.Month), //Get the right amount of days in the month
                23,59,59, current.Offset); // 23:59:59
        }
    }
}
