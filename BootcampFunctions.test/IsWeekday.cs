using System;
using Xunit;

namespace BootcampFunctions.test {
    public class IsWeekday
    {
        [Fact]
        public void ShouldReturnTrueOnMonday() {
            var isWeekday = new BootcampFunctions.IsWeekday();
            Assert.Equal(true, isWeekday.isWeekday("monday"));
        }

        [Fact]
        public void ShouldReturnTrueOnFriday() {
            var isWeekday = new BootcampFunctions.IsWeekday();
            Assert.Equal(true, isWeekday.isWeekday("Friday"));
        }

        [Fact]
        public void ShouldReturnTrueOnThursday() {
            var isWeekday = new BootcampFunctions.IsWeekday();
            Assert.Equal(true, isWeekday.isWeekday("Thursday"));
        }

        [Fact]
        public void ShouldReturnFalseOnSunday() {
            var isWeekday = new BootcampFunctions.IsWeekday();
            Assert.Equal(false, isWeekday.isWeekday("Sunday"));
        }

        [Fact]
        public void ShouldReturnFalseOnSaturday() {
            var isWeekday = new BootcampFunctions.IsWeekday();
            Assert.Equal(false, isWeekday.isWeekday("Saturday"));
        }
    }
} 