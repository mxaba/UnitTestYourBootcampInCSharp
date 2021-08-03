using System;
using Xunit;

namespace BootcampFunctions.test {
    public class Greet
    {
        [Fact]
        public void ShouldGreetMcebo() {
            var greetClass = new BootcampFunctions.Greet();
            Assert.Equal("Hello, Mcebo", greetClass.greet("Mcebo"));
        }

        [Fact]
        public void ShouldGreeAndre() {
            var greetClass = new BootcampFunctions.Greet();
            Assert.Equal("Hello, Andre", greetClass.greet("Andre"));
        }

        [Fact]
        public void ShouldGreePeople() {
            var greetClass = new BootcampFunctions.Greet();
            Assert.Equal("Hello, People", greetClass.greet("People"));
        }
    }
}