using System;
using Xunit;

namespace BootcampFunctions.test {
    public class YearsAgo
    {
        [Fact]
        public void yearsAgoFor2021() {
            var YearsAgo = new BootcampFunctions.YearsAgo();
            Assert.Equal(0, YearsAgo.yearsAgo(2021));
        }

        [Fact]
        public void yearsAgoShouldReturn2() {
            var YearsAgo = new BootcampFunctions.YearsAgo();
            Assert.Equal(2, YearsAgo.yearsAgo(2019));
        }

        [Fact]
        public void yearsAgoShouldReturn6() {
            var YearsAgo = new BootcampFunctions.YearsAgo();
            Assert.Equal(6, YearsAgo.yearsAgo(2015));
        }

        [Fact]
        public void yearsAgoShouldReturn21() {
            var YearsAgo = new BootcampFunctions.YearsAgo();
            Assert.Equal(21, YearsAgo.yearsAgo(2000));
        }
    }
}