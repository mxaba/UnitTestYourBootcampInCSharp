using System;
using Xunit;

namespace BootcampFunctions.test {
    public class Greet
    {
        [Fact]
        public void ShouldGreetMcebo() {
            var greetClass = new GreetPerson();
            Assert.Equal("Hello, Mcebo", greetClass.Greet("Mcebo"));
        }

        [Fact]
        public void ShouldGreeAndre() {
            var greetClass = new GreetPerson();
            Assert.Equal("Hello, Andre", greetClass.Greet("Andre"));
        }

        [Fact]
        public void ShouldGreePeople() {
            var greetClass = new GreetPerson();
            Assert.Equal("Hello, People", greetClass.Greet("People"));
        }
    }
}
