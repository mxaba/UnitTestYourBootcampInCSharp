using System;
using Xunit;

namespace Functions.test {
    public class CountAllPaarl
    {
        [Fact]
        public void countAllPaarl() {
            var countAllPaarl = new CountAllPaarlClass();
            var OnlyPaarlOne = countAllPaarl.CountAllPaarl("CL 900, CPJ 678 543, CA 34567, CY 67890, CN 7864, CJ 8765");
            var OnlyPaarlTwo = countAllPaarl.CountAllPaarl("CL 900, CJ 678 543, CA 34567, CJ 67890, CN 7864, CJ 8765");

            Assert.Equal(1, OnlyPaarlOne);
            Assert.Equal(3, OnlyPaarlTwo);
        }
    }
}
