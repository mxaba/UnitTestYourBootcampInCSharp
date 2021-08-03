using System;

namespace BootcampFunctions {
    public class YearsAgo {
        public int yearsAgo(int year) {
            var currentYear = DateTime.Now;;
            return currentYear.Year - year;
        }
    }
}
