using System;
using Xunit;

namespace BootcampFunctions.test {
    public class FromWhere
    {
        [Fact]
        public void fromWhereBellville() {
            var FromWhere = new FromWhereClass();
            Assert.Equal("Bellville", FromWhere.FromWhere("CY"));
        }

        [Fact]
        public void fromWherePaarl() {
            var FromWhere = new FromWhereClass();
            Assert.Equal("Paarl", FromWhere.FromWhere("CJ"));
        }

        [Fact]
        public void fromWhereCapeTown() {
            var FromWhere = new FromWhereClass();
            Assert.Equal("Cape Town", FromWhere.FromWhere("CA"));
        }

        [Fact]
        public void fromWhereOther() {
            var FromWhere = new FromWhereClass();
            Assert.Equal("Some other place!", FromWhere.FromWhere("GP"));
        }
    }
}