using System;
using Xunit;

namespace BootcampFunctions.test {
    public class CountAllPaarl
    {
        [Fact]
        public void ShouldReturnThree() {
            var countAllPaarl = new BootcampFunctions.CountAllPaarl();
            var OnlyPaarlTwo = countAllPaarl.countAllPaarl("CL 900, CJ 678 543, CA 34567, CJ 67890, CN 7864, CJ 8765");

            Assert.Equal(3, OnlyPaarlTwo);
        }

        [Fact]
        public void ShouldReturnOne() {
            var countAllPaarl = new BootcampFunctions.CountAllPaarl();
            var OnlyPaarlOne = countAllPaarl.countAllPaarl("CL 900, CPJ 678 543, CA 34567, CY 67890, CN 7864, CJ 8765");

            Assert.Equal(1, OnlyPaarlOne);
        }

        [Fact]
        public void ShouldReturnZero() {
            var countAllPaarl = new BootcampFunctions.CountAllPaarl();
            var OnlyPaarlOne = countAllPaarl.countAllPaarl("CL 900, CPJ 678 543, CA 34567, CY 67890, CN 7864, CN 8765");

            Assert.Equal(0, OnlyPaarlOne);
        }
    }
}