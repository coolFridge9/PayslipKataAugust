namespace payslip
{
    public interface PaySlipInterface
    {
        string Name();
        string PayPeriod();
        int GrossIncome();
        int Tax();
        int NetIncome();
        int Super();

    }
}