using System;

namespace TicketApp.Internal.Util {
    public class TimeConverter {
        public static long DateToUnix(DateTime date) {
            return (long)(date.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        }
    }
}