using payslip;

namespace payslipTests
{
    public class MockPaySlip : PaySlipInterface
    {
        public string Name()
        {
            return "John Doe";
        }

        public string PayPeriod()
        {
            return "01 March – 31 March";
        }

        public int GrossIncome()
        {
            return 5004;
        }

        public int Tax()
        {
            return 922;
        }

        public int NetIncome()
        {
            return 4082;
        }

        public int Super()
        {
            return 450;
        }
    }
}