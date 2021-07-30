using System;
using Xunit;

namespace Functions.test {
    public class functionsTests
    {
        [Fact]
        public void Greet() {
            var greetClass = new GreetPerson();
            Assert.Equal("Hello, Mcebo", greetClass.Greet("Mcebo"));
            Assert.Equal("Hello, Andre", greetClass.Greet("Andre"));
        }

        [Fact]
        public void Greet() {
            var greetClass = new GreetPerson();
            Assert.Equal("Hello, Mcebo", greetClass.Greet("Mcebo"));
            Assert.Equal("Hello, Andre", greetClass.Greet("Andre"));
        }
    }
}
