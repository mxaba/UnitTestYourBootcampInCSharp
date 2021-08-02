namespace BootcampFunctions {
    public class FromWhereClass {
        public string FromWhere(string city) {
            switch (city.ToLower()) {
                case "cy":
                    return "Bellville";
                case "cj":
                    return "Paarl";
                case "ca":
                    return "Cape Town";
                default:
                    return "Some other place!";
            }
        }
    }
}