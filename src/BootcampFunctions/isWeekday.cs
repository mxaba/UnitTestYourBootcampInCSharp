namespace BootcampFunctions {
    public class IsWeekdayClass {
        public bool IsWeekday(string name) {
            string weekdays = "friday monday tuesday wednesday thursday";
            name = name.ToLower();
            return weekdays.Contains(name);
        }
    }
}