using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using payslip;
using Xunit;

namespace payslipTests
{
    public class PaySlipShould
    {
        private readonly PaySlip _paySlip;

        public PaySlipShould()
        {
            _paySlip = new PaySlip("John", "Doe", 60050, 9, "1 March", "31 March"); //integer assumptions (to make it easier for myself)
        }
        
        [Fact]
        public void GenerateName()
        {
           var result = _paySlip.Name();
           var expected = "John Doe";
           Assert.Equal(expected,result);

        }
        
        [Fact]
        public void GeneratePayPeriod()
        {
           var result = _paySlip.PayPeriod();
           var expected = "01 March - 31 March";
           Assert.Equal(expected,result);

        } 
        
        [Fact]
        public void GenerateGrossIncome()
        {
           var result = _paySlip.GrossIncome();
           var expected = 5004;
           Assert.Equal(expected,result);

        }
        
        [Fact]
        public void GenerateTax()
        {
           var result = _paySlip.Tax();
           var expected = 922;
           Assert.Equal(expected,result);

        }
            
        [Fact]
        public void GenerateNetIncome()
        {
           var result = _paySlip.NetIncome();
           var expected = 4082;
           Assert.Equal(expected,result);

        }
        
        [Fact]
        public void GeneratSuper()
        {
           var result = _paySlip.Super();
           var expected = 450;
           Assert.Equal(expected,result);

        }
    }
}