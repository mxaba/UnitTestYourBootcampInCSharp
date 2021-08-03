using System;
using Xunit;

namespace BootcampFunctions.test {
    public class TotalPhoneBill
    {
        [Fact]
        public void ShouldReturnTheTotalCostForAllTheCallsAndSms() {
            var TotalPhoneBill = new BootcampFunctions.TotalPhoneBill();
            Assert.Equal("R7.45", TotalPhoneBill.totalPhoneBill("call, sms, call, sms, sms"));
        }

        [Fact]
        public void ShouldReturnTheTotalCostForOnlyOnceSMSAndCall() {
            var TotalPhoneBill = new BootcampFunctions.TotalPhoneBill();
            Assert.Equal("R3.40", TotalPhoneBill.totalPhoneBill("call, sms"));
        }


        [Fact]
        public void ShouldReturnTheTotalCostForForOnlySms() {
            var TotalPhoneBill = new BootcampFunctions.TotalPhoneBill();
            Assert.Equal("R0.65", TotalPhoneBill.totalPhoneBill("sms"));
        }

        [Fact]
        public void ShouldReturnTheTotalCostForForOnlyCall() {
            var TotalPhoneBill = new BootcampFunctions.TotalPhoneBill();
            Assert.Equal("R2.75", TotalPhoneBill.totalPhoneBill("Call"));
        }
    }
} 