using System;
using Xunit;

namespace BootcampFunctions.test {
    public class IsFromBellville
    {
        [Fact]
        public void isFromBellvilleShouldRetutnTrue() {
            var IsFromBellville = new FromBellvilleClass();
            Assert.Equal(true, IsFromBellville.IsFromBellville("CY"));
        }

        [Fact]
        public void isFromBellvilleShouldRetutnFalse() {
            var IsFromBellville = new FromBellvilleClass();
            Assert.Equal(false, IsFromBellville.IsFromBellville("GP"));
        }
    }
}