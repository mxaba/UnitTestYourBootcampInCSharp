using System;
using Xunit;

namespace Functions.test {
    public class FromWhere
    {
        [Fact]
        public void fromWhere() {
            var FromWhere = new FromWhereClass();
            Assert.Equal("Bellville", FromWhere.FromWhere("CY"));
            Assert.Equal("Paarl", FromWhere.FromWhere("CJ"));
            Assert.Equal("Cape Town", FromWhere.FromWhere("CA"));
            Assert.Equal("Some other place!", FromWhere.FromWhere("GP"));
        }
    }
}