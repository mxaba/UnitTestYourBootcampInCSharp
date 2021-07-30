using System;
using Xunit;

namespace Functions.test {
    public class Greet
    {
        [Fact]
        public void greet() {
            var greetClass = new GreetPerson();
            Assert.Equal("Hello, Mcebo", greetClass.Greet("Mcebo"));
            Assert.Equal("Hello, Andre", greetClass.Greet("Andre"));
        }
    }
}
