using payslip;

namespace payslipTests
{
    public class MockUserInputValidator : InputValidatorInterface
    {
        public string ValidateName(string name)
        {
            return "Jordan";
        }

        public int ValidateInteger(string num)
        {
            return 5;
        }

        public string ValidateDate(string date)
        {
            return "10 May";
        }
    }
}