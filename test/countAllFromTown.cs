using System;
using Xunit;

namespace BootcampFunctions.test {
    public class CountAllFromTown
    {
        [Fact]
        public void countAllFromTownCA() {
            var countAllFromTown = new CountAllFromTownClass();
            var cityCA = countAllFromTown.CountAllFromTown("CA 900, CP 678 543, CA 34567, CJ 67890, CN 7864, CJ 8765", "CA");
            Assert.Equal(2, cityCA);
        }

        [Fact]
        public void countAllFromTownCL() {
            var countAllFromTown = new CountAllFromTownClass();
            var cityCL = countAllFromTown.CountAllFromTown("CL 900, CL 678 543, CA 34567, CJ 67890, CN 7864, CL 8765", "CL");
            Assert.Equal(3, cityCL);
        }

        [Fact]
        public void countAllFromTownCY() {
            var countAllFromTown = new CountAllFromTownClass();
            var cityCL = countAllFromTown.CountAllFromTown("CL 900, CL 678 543, CY 34567, CY 67890, CN 7864, CL 8765", "CY");
            Assert.Equal(2, cityCL);
        }
    }
}
