using System;
using Xunit;

namespace BootcampFunctions.test {
    public class TotalPhoneBill
    {
        [Fact]
        public void totalPhoneBill() {
            var TotalPhoneBill = new TotalPhoneBillClass();
            Assert.Equal("R7.45", TotalPhoneBill.TotalPhoneBill("call, sms, call, sms, sms"));
        }

        [Fact]
        public void totalPhoneBillForOnlyOnceSMSAndCall() {
            var TotalPhoneBill = new TotalPhoneBillClass();
            Assert.Equal("R3.40", TotalPhoneBill.TotalPhoneBill("call, sms"));
        }


        [Fact]
        public void totalPhoneBillForOnlySms() {
            var TotalPhoneBill = new TotalPhoneBillClass();
            Assert.Equal("R0.65", TotalPhoneBill.TotalPhoneBill("sms"));
        }

        [Fact]
        public void totalPhoneBillForOnlyCall() {
            var TotalPhoneBill = new TotalPhoneBillClass();
            Assert.Equal("R2.75", TotalPhoneBill.TotalPhoneBill("Call"));
        }
    }
}