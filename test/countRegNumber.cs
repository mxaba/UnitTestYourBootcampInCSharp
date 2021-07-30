using System;
using Xunit;

namespace Functions.test {
    public class CountRegNumber
    {
        [Fact]
        public void countAllPaarl() {
            var countRegNumber = new CountRegNumberClass();
            AssemblyLoadEventArgs.Equals(2, countRegNumber.CountRegNumber("CA 42665, AA 12 RT GP"));
            AssemblyLoadEventArgs.Equals(4, countRegNumber.CountRegNumber("CA 42665, AA 12 RT GP, CAA 42665, CY 12 RT GP"));
        }
    }
}
