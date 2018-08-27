namespace payslip
{
    public interface InputValidatorInterface
    {
        string ValidateName(string name);
        int ValidateInteger(string num);
        string ValidateDate(string date);

    }
}