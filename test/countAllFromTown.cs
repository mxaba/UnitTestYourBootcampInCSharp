using System;
using Xunit;

namespace Functions.test {
    public class CountAllFromTown
    {
        [Fact]
        public void countAllFromTown() {
            var countAllFromTown = new CountAllFromTownClass();
            var cityCL = countAllFromTown.CountAllFromTown("CL 900, CL 678 543, CA 34567, CJ 67890, CN 7864, CL 8765", "CL");
            var cityCA = countAllFromTown.CountAllFromTown("CA 900, CP 678 543, CA 34567, CJ 67890, CN 7864, CJ 8765", "CA");
            Assert.Equal(3, cityCL);
            Assert.Equal(2, cityCA);
        }
    }
}
