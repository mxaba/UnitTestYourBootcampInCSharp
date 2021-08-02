using System;
using Xunit;

namespace BootcampFunctions.test {
    public class FromWhere
    {
        [Fact]
        public void ShouldReturnBellvilleWhenCYPassed() {
            var FromWhere = new BootcampFunctions.FromWhere();
            Assert.Equal("Bellville", FromWhere.fromWhere("CY"));
        }

        [Fact]
        public void ShouldReturnPaarlWhenCJPassed() {
            var FromWhere = new BootcampFunctions.FromWhere();
            Assert.Equal("Paarl", FromWhere.fromWhere("CJ"));
        }

        [Fact]
        public void ShouldReturnCapeTownWhenCAPassed() {
            var FromWhere = new BootcampFunctions.FromWhere();
            Assert.Equal("Cape Town", FromWhere.fromWhere("CA"));
        }

        [Fact]
        public void ShouldReturnSomeOtherPlaceWhenGPPassed() {
            var FromWhere = new BootcampFunctions.FromWhere();
            Assert.Equal("Some other place!", FromWhere.fromWhere("GP"));
        }
    }
}