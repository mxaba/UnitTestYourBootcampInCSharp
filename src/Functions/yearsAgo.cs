using System;

namespace Functions {
    public class YearsAgoClass {
        public int YearsAgo(int year) {
            var currentYear = DateTime.Now;;
            return currentYear.Year - year;
        }
    }
}