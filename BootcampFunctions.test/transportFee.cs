using System;
using Xunit;

namespace BootcampFunctions.test {
    public class TransportFee
    {
        [Fact]
        public void transportFee() {
            var TransportFee = new BootcampFunctions.TransportFee();
            Assert.Equal("R20", TransportFee.transportFee("Morning"));
            Assert.Equal("R10", TransportFee.transportFee("afternoon"));
            Assert.Equal("free", TransportFee.transportFee("nightshift"));
            Assert.Equal("", TransportFee.transportFee("call, sms"));
        }

        [Fact]
        public void ShouldReturn20TransportFeeInTheMorning() {
            var TransportFee = new BootcampFunctions.TransportFee();
            Assert.Equal("R20", TransportFee.transportFee("Morning"));
        }

        [Fact]
        public void ShouldReturnR10TransportFeeAfternoon() {
            var TransportFee = new BootcampFunctions.TransportFee();
            Assert.Equal("R10", TransportFee.transportFee("afternoon"));
        }

        [Fact]
        public void ShouldReturnFreeTransportFeeForNightShift() {
            var TransportFee = new BootcampFunctions.TransportFee();
            Assert.Equal("free", TransportFee.transportFee("nightshift"));
        }

        [Fact]
        public void ShouldReturnEmptyStringForAnythingNotOnTheList() {
            var TransportFee = new BootcampFunctions.TransportFee();
            Assert.Equal("", TransportFee.transportFee("call, sms"));
        }
    }
}