namespace Functions {
    public class GreetPerson {
        public string Greet(string name) {
            if (name is string){
                return $"Hello, {name}";
            } else {
                return "Plase pass a string";
            }
        }
    }
}