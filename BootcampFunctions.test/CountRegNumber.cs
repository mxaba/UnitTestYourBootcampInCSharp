using System;
using Xunit;

namespace BootcampFunctions.test {
    public class CountRegNumber
    {
        [Fact]
        public void ShouldCountRegNumberAndReturnTwo() {
            var countRegNumber = new BootcampFunctions.CountRegNumber();
            Assert.Equal(2, countRegNumber.countRegNumber("CA 42665, AA 12 RT GP"));
        }

        [Fact]
        public void ShouldCountRegNumberAndReturnFour() {
            var countRegNumber = new BootcampFunctions.CountRegNumber();
            Assert.Equal(4, countRegNumber.countRegNumber("CA 42665, AA 12 RT GP, CAA 42665, CY 12 RT GP"));
        }

        [Fact]
        public void ShouldCountRegNumberAndReturnNine() {
            var countRegNumber = new BootcampFunctions.CountRegNumber();
            Assert.Equal(9, countRegNumber.countRegNumber("CA 42665, AA 12 RT GP, CA 42665, AA 12 RT GP, CA 42665, CA 42665, AA 12 RT GP, CAA 42665, CY 12 RT GP"));
        }
    }
}