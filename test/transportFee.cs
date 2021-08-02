using System;
using Xunit;

namespace BootcampFunctions.test {
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

        [Fact]
        public void transportFeeShouldReturn20() {
            var TransportFee = new TransportFeeClass();
            Assert.Equal("R20", TransportFee.TransportFee("Morning"));
        }

        [Fact]
        public void transportFeeShouldReturnR10() {
            var TransportFee = new TransportFeeClass();
            Assert.Equal("R10", TransportFee.TransportFee("afternoon"));
        }

        [Fact]
        public void transportFeeShouldReturnFree() {
            var TransportFee = new TransportFeeClass();
            Assert.Equal("free", TransportFee.TransportFee("nightshift"));
        }

        [Fact]
        public void transportFeeShouldReturnEmptyString() {
            var TransportFee = new TransportFeeClass();
            Assert.Equal("", TransportFee.TransportFee("call, sms"));
        }
    }
}