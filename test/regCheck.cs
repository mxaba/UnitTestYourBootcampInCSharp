using System;
using Xunit;

namespace BootcampFunctions.test {
    public class RegCheck
    {
        [Fact]
        public void regCheckShouldReturnFalseNotMatch() {
            var RegCheck = new RegCheckClass();
            Assert.Equal(true, RegCheck.RegCheck("MCB 764 GP", "GP"));
            Assert.Equal(false, RegCheck.RegCheck("CA 98 CA", "GP"));
            Assert.Equal(false, RegCheck.RegCheck("CA 98 CA", "CY"));
            Assert.Equal(false, RegCheck.RegCheck("CA 98 CA", "CK"));
        }

        [Fact]
        public void regCheckShouldReturnTruetMatch() {
            var RegCheck = new RegCheckClass();
            Assert.Equal(true, RegCheck.RegCheck("MCB 764 GP", "GP"));
            Assert.Equal(true, RegCheck.RegCheck("CA 98 CA", "CA"));
            Assert.Equal(true, RegCheck.RegCheck("CA 980990", "CA"));
            Assert.Equal(true, RegCheck.RegCheck("CY 090 098", "CY"));
        }
    }
}