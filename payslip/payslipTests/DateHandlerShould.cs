using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using payslip;
using Xunit;

namespace payslipTests
{
    public class DateHandlerShould
    {
        [Fact]
        public void ReturnDateTimeFormat()
        {
            var start = "1 March";
            var end = "31 March";
            var dateHandler = new DateHandler(start,end);
            var result = dateHandler.ToString();
            var expected = "01 March - 31 March";
            Assert.Equal(expected,result);

        }
       [Fact]
        public void ReturnDateTimeFormat2()
        {
            var start = "1 April";
            var end = "30 April";
            var dateHandler = new DateHandler(start,end);
            var result = dateHandler.ToString();
            var expected = "01 April - 30 April";
            Assert.Equal(expected,result);

        }
      
    }
}