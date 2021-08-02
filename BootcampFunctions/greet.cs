namespace BootcampFunctions {
    public class Greet {
        public string greet(string name) {
            if (name is string){
                return $"Hello, {name}";
            } else {
                return "Plase pass a string";
            }
        }
    }
}