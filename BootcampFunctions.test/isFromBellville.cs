using System;
using Xunit;

namespace BootcampFunctions.test {
    public class IsFromBellville
    {
        [Fact]
        public void ShouldRetutnTrueWhenCYPassed() {
            var IsFromBellville = new BootcampFunctions.IsFromBellville();
            Assert.Equal(true, IsFromBellville.isFromBellville("CY"));
        }

        [Fact]
        public void ShouldRetutnFalseWhenAnythingPassedEpectCY() {
            var IsFromBellville = new BootcampFunctions.IsFromBellville();
            Assert.Equal(false, IsFromBellville.isFromBellville("GP"));
            Assert.Equal(false, IsFromBellville.isFromBellville("CA"));
            Assert.Equal(false, IsFromBellville.isFromBellville("CJ"));
        }
    }
}