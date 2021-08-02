using System;
using Xunit;

namespace BootcampFunctions.test {
    public class YearsAgo
    {
        [Fact]
        public void yearsAgoFor2021() {
            var YearsAgo = new YearsAgoClass();
            Assert.Equal(0, YearsAgo.YearsAgo(2021));
        }

        [Fact]
        public void yearsAgoShouldReturn2() {
            var YearsAgo = new YearsAgoClass();
            Assert.Equal(2, YearsAgo.YearsAgo(2019));
        }

        [Fact]
        public void yearsAgoShouldReturn6() {
            var YearsAgo = new YearsAgoClass();
            Assert.Equal(6, YearsAgo.YearsAgo(2015));
        }

        [Fact]
        public void yearsAgoShouldReturn21() {
            var YearsAgo = new YearsAgoClass();
            Assert.Equal(21, YearsAgo.YearsAgo(2000));
        }
    }
}