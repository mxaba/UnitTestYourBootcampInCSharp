using System;
using Xunit;

namespace Functions.test {
    public class RegCheck
    {
        [Fact]
        public void regCheck() {
            var RegCheck = new RegCheckClass();
            Assert.Equal(true, RegCheck.RegCheck("MCB 764 GP", "GP"));
            Assert.Equal(false, RegCheck.RegCheck("CA 98 CA", "GP"));
        }
    }
}