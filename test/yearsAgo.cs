using System;
using Xunit;

namespace Functions.test {
    public class YearsAgo
    {
        [Fact]
        public void yearsAgo() {
            var YearsAgo = new YearsAgoClass();
            Assert.Equal(0, YearsAgo.YearsAgo(2021));
            Assert.Equal(2, YearsAgo.YearsAgo(2019));
            Assert.Equal(6, YearsAgo.YearsAgo(2015));
        }
    }
}