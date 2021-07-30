using System;
using Xunit;

namespace Functions.test {
    public class IsWeekday
    {
        [Fact]
        public void isWeekday() {
            var isWeekday = new IsWeekdayClass();
            Assert.Equal(true, isWeekday.IsWeekday("monday"));
            Assert.Equal(true, isWeekday.IsWeekday("Friday"));
            Assert.Equal(true, isWeekday.IsWeekday("Thursday"));
            Assert.Equal(false, isWeekday.IsWeekday("Sunday"));
        }
    }
}