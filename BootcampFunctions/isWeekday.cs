namespace BootcampFunctions {
    public class IsWeekday {
        public bool isWeekday(string name) {
            string weekdays = "friday monday tuesday wednesday thursday";
            name = name.ToLower();
            return weekdays.Contains(name);
        }
    }
}