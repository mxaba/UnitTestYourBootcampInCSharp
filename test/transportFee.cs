using System;
using Xunit;

namespace Functions.test {
    public class TransportFee
    {
        [Fact]
        public void transportFee() {
            var TransportFee = new TransportFeeClass();
            Assert.Equal("R20", TransportFee.TransportFee("Morning"));
            Assert.Equal("R10", TransportFee.TransportFee("afternoon"));
            Assert.Equal("free", TransportFee.TransportFee("nightshift"));
            Assert.Equal("", TransportFee.TransportFee("call, sms"));
        }
    }
}