namespace BootcampFunctions {
    public class FromWhere {
        public string fromWhere(string city) {
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
