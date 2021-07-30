using System;
using Xunit;

namespace Functions.test {
    public class TotalPhoneBill
    {
        [Fact]
        public void totalPhoneBill() {
            var TotalPhoneBill = new TotalPhoneBillClass();
            Assert.Equal("R7.45", TotalPhoneBill.TotalPhoneBill("call, sms, call, sms, sms"));
            Assert.Equal("R2.75", TotalPhoneBill.TotalPhoneBill("Call"));
            Assert.Equal("R0.65", TotalPhoneBill.TotalPhoneBill("sms"));
            Assert.Equal("R3.40", TotalPhoneBill.TotalPhoneBill("call, sms"));
        }
    }
}