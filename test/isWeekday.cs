using System;
using Xunit;

namespace BootcampFunctions.test {
    public class IsWeekday
    {
        [Fact]
        public void isWeekdayShouldReturnTrueMonday() {
            var isWeekday = new IsWeekdayClass();
            Assert.Equal(true, isWeekday.IsWeekday("monday"));
        }

        [Fact]
        public void isWeekdayShouldReturnTrueFriday() {
            var isWeekday = new IsWeekdayClass();
            Assert.Equal(true, isWeekday.IsWeekday("Friday"));
        }

        [Fact]
        public void isWeekdayShouldReturnTrueThursday() {
            var isWeekday = new IsWeekdayClass();
            Assert.Equal(true, isWeekday.IsWeekday("Thursday"));
        }

        [Fact]
        public void isWeekdayShouldReturnFalseSunday() {
            var isWeekday = new IsWeekdayClass();
            Assert.Equal(false, isWeekday.IsWeekday("Sunday"));
        }
    }
}