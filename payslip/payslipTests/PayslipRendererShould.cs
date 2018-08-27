using System.Collections.Generic;
using payslip;
using Xunit;

namespace payslipTests
{
    public class PayslipRendererShould
    {
        [Fact]
        public void renderPayslip()
        {
            var payslipRenderer = new PayslipRenderer();
            var payslip = new MockPaySlip();
            var resultOutput = new MockOutputAstext();
            payslipRenderer.Render(payslip, resultOutput); //failing to compare lists- use string instead

            var expected = new List<string>
            {
                "Name: John Doe\n",
                "Pay Period: 01 March – 31 March\n",
                "Gross Income: 5004\n",
                "Income Tax: 922\n",
                "Net Income:4082\n",
                "Super: 450\n"
            };

            Assert.Equal(expected.ToString(),resultOutput.WriteText.ToString());
        }

    }
}