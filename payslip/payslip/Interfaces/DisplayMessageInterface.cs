namespace payslip
{
    public interface DisplayMessageInterface
    {
        string Welcome();
        string GetName();
        string GetSurname();
        string GetSalary();
        string GetSuperRate();
        string GetPaymentStartDate();
        string GetPaymentEndDate();
        string NewLine();
        string ThankUser();
        string Error();
    }
}