using payslip;

namespace payslipTests
{
    public class MockPayslipRenderer : PayslipRendererInterface
    {
        public void Render(PaySlipInterface payslip, OutInterface output)
        {
            output.Print("test");
        }
    }
}