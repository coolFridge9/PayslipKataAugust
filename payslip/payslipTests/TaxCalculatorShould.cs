using payslip;
using Xunit;

namespace payslipTests
{
    public class TaxCalculatorShould
    {
        private readonly TaxCalculator _taxCalculator;
        public TaxCalculatorShould()
        {
            _taxCalculator = new TaxCalculator();
        }
        
        [Theory]
        [InlineData(100,0)]
        [InlineData(60050,922)]
        public void ReturnCorrectTax(int salary, int expectedTax)
        {
            var result = _taxCalculator.GetTax(salary);
            var expected = expectedTax;
            Assert.Equal(expected,result);
        }
    }
}