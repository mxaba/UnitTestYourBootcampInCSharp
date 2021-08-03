using System;
using Xunit;

namespace BootcampFunctions.test {
    public class RegCheck
    {
        [Fact]
        public void regCheckShouldReturnFalseWhenNotMatched() {
            var RegCheck = new BootcampFunctions.RegCheck();
            Assert.Equal(true, RegCheck.regCheck("MCB 764 GP", "GP"));
            Assert.Equal(false, RegCheck.regCheck("CA 98 CA", "GP"));
            Assert.Equal(false, RegCheck.regCheck("CA 98 CA", "CY"));
            Assert.Equal(false, RegCheck.regCheck("CA 98 CA", "CK"));
        }

        [Fact]
        public void regCheckShouldReturnTrueWhentMatched() {
            var RegCheck = new BootcampFunctions.RegCheck();
            Assert.Equal(true, RegCheck.regCheck("MCB 764 GP", "GP"));
            Assert.Equal(true, RegCheck.regCheck("CA 98 CA", "CA"));
            Assert.Equal(true, RegCheck.regCheck("CA 980990", "CA"));
            Assert.Equal(true, RegCheck.regCheck("CY 090 098", "CY"));
        }
    }
} 