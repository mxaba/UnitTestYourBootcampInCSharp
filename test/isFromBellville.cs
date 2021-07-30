using System;
using Xunit;

namespace Functions.test {
    public class IsFromBellville
    {
        [Fact]
        public void isFromBellville() {
            var IsFromBellville = new FromBellvilleClass();
            Assert.Equal(true, IsFromBellville.IsFromBellville("CY"));
            Assert.Equal(false, IsFromBellville.IsFromBellville("GP"));
        }
    }
}