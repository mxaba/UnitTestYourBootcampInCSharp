namespace BootcampFunctions {
    public class TransportFee {
        public string transportFee(string shift){
            switch (shift.ToLower()) {
                case "morning":
                    return "R20";
                case "afternoon":
                    return "R10";
                case "nightshift":
                    return "free";
                default:
                    return "";
            }
        }
    }
}
