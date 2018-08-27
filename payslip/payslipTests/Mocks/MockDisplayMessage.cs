using payslip;

namespace payslipTests
{
    public class MockDisplayMessage : DisplayMessageInterface
    {
        public string Welcome()
        {
            return "1";
        }

        public string GetName()
        {
            return "2";
        }

        public string GetSurname()
        {
            return "3";
        }

        public string GetSalary()
        {
            return "4";
        }

        public string GetSuperRate()
        {
            return "5";
        }

        public string GetPaymentStartDate()
        {
            return "6";
        }

        public string GetPaymentEndDate()
        {
            return "7";
        }

        public string NewLine()
        {
            return "N";
        }

        public string ThankUser()
        {
            return "8";
        }

        public string Error()
        {
            return "testErrorMessage";
        }
    }
}