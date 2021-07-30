using System;

namespace Functions {
    public class YearsAgoClass {
        public int YearsAgo(int year) {
            var currentYear = new DateTime().Year;
            return currentYear - year;
        }
    }
}