using System;
using Xunit;

namespace BootcampFunctions.test {
    public class CountAllFromTown
    {
        [Fact]
        public void ShouldReturnAllPlatesFromCA() {
            var countAllFromTown = new BootcampFunctions.CountAllFromTown();
            var cityCA = countAllFromTown.countAllFromTown("CA 900, CP 678 543, CA 34567, CJ 67890, CN 7864, CJ 8765", "CA");
            Assert.Equal(2, cityCA);
        }

        [Fact]
        public void ShouldReturnAllPlatesFromCL() {
            var countAllFromTown = new BootcampFunctions.CountAllFromTown();
            var cityCL = countAllFromTown.countAllFromTown("CL 900, CL 678 543, CA 34567, CJ 67890, CN 7864, CL 8765", "CL");
            Assert.Equal(3, cityCL);
        }

        [Fact]
        public void ShouldReturnAllPlatesFromCY() {
            var countAllFromTown = new BootcampFunctions.CountAllFromTown();
            var cityCL = countAllFromTown.countAllFromTown("CL 900, CL 678 543, CY 34567, CY 67890, CN 7864, CL 8765", "CY");
            Assert.Equal(2, cityCL);
        }
    }
}