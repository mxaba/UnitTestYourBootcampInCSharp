using System;
using Xunit;

namespace BootcampFunctions.test {
    public class CountRegNumber
    {
        [Fact]
        public void countRegNumberTwo() {
            var countRegNumber = new CountRegNumberClass();
            Assert.Equal(2, countRegNumber.CountRegNumber("CA 42665, AA 12 RT GP"));
        }

        [Fact]
        public void countRegNumberFour() {
            var countRegNumber = new CountRegNumberClass();
            Assert.Equal(4, countRegNumber.CountRegNumber("CA 42665, AA 12 RT GP, CAA 42665, CY 12 RT GP"));
        }

        [Fact]
        public void countRegNumberNine() {
            var countRegNumber = new CountRegNumberClass();
            Assert.Equal(9, countRegNumber.CountRegNumber("CA 42665, AA 12 RT GP, CA 42665, AA 12 RT GP, CA 42665, CA 42665, AA 12 RT GP, CAA 42665, CY 12 RT GP"));
        }
    }
}
