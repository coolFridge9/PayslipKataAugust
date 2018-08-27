namespace payslip
{
    public interface PayslipRendererInterface
    {
        void Render(PaySlipInterface payslip, OutInterface output);
    }
}