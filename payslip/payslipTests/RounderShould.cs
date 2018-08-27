using Microsoft.VisualStudio.TestPlatform.Common.DataCollection;
using payslip;
using Xunit;

namespace payslipTests
{
    public class RounderShould
    {
        [Theory]
        [InlineData(0.5,1)]
        [InlineData(0.54268,1)]
        [InlineData(1.5,2)]
        [InlineData(1.51111,2)]
        [InlineData(1.49,1)]
        [InlineData(0.2,0)]
        public void Round(double num, int expected)
        {
            var rounder = new Rounder();
            var result = Rounder.Round(num);
            Assert.Equal(expected,result);
        }
        
    }
}