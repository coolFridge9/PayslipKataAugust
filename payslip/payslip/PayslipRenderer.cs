namespace payslip
{
    public class PayslipRenderer : PayslipRendererInterface
    {
        public void Render(PaySlipInterface payslip, OutInterface output) 
        {
            output.Print("Name: "+payslip.Name()+"\n");
            output.Print("Pay Period: "+payslip.PayPeriod()+"\n");
            output.Print("Gross Income: "+payslip.GrossIncome()+"\n");
            output.Print("Income Tax: "+ payslip.Tax()+"\n");
            output.Print("Net Income: "+payslip.NetIncome()+"\n");
            output.Print("Super: "+payslip.Super()+"\n");
        }
    }
}