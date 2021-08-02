using System;
using Xunit;

namespace BootcampFunctions.test {
    public class CountAllPaarl
    {
        [Fact]
        public void countAllPaarlThree() {
            var countAllPaarl = new CountAllPaarlClass();
            var OnlyPaarlTwo = countAllPaarl.CountAllPaarl("CL 900, CJ 678 543, CA 34567, CJ 67890, CN 7864, CJ 8765");

            Assert.Equal(3, OnlyPaarlTwo);
        }

        [Fact]
        public void countAllPaarlOne() {
            var countAllPaarl = new CountAllPaarlClass();
            var OnlyPaarlOne = countAllPaarl.CountAllPaarl("CL 900, CPJ 678 543, CA 34567, CY 67890, CN 7864, CJ 8765");

            Assert.Equal(1, OnlyPaarlOne);
        }

        [Fact]
        public void countAllPaarlZero() {
            var countAllPaarl = new CountAllPaarlClass();
            var OnlyPaarlOne = countAllPaarl.CountAllPaarl("CL 900, CPJ 678 543, CA 34567, CY 67890, CN 7864, CN 8765");

            Assert.Equal(0, OnlyPaarlOne);
        }
    }
}
