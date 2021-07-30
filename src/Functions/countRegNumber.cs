namespace Functions {
    public class CountRegNumberClass {
        public int CountRegNumber(string name) {
            return name.Split(", ").Length;
        }
    }
}