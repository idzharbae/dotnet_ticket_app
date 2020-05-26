using System;

namespace AuthApp.Internal.Util {
    public class Parser {
         public static Guid ParseGuid(string input) {
            try {
                return Guid.Parse(input);
            } catch(Exception) {
                return default(Guid);
            }
        }
    }
}