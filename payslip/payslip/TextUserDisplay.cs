namespace payslip
{
    public class TextUserDisplay
    {
        public void Run(InputReaderInterface inputReader, InputValidatorInterface validator, 
            DisplayMessageInterface messages, OutInterface outputWriter, PayslipRendererInterface payslipRenderer)
        {
            outputWriter.Print(messages.Welcome());
            outputWriter.Print(messages.NewLine());
            
            outputWriter.Print(messages.GetName());
            var firstName = validator.ValidateName(inputReader.Read());
            outputWriter.Print(messages.NewLine());
            
            outputWriter.Print(messages.GetSurname());
            var surname = validator.ValidateName(inputReader.Read());
            outputWriter.Print(messages.NewLine());
            
            outputWriter.Print(messages.GetSalary());
            var salary = validator.ValidateInteger(inputReader.Read());
            outputWriter.Print(messages.NewLine());
            
            outputWriter.Print(messages.GetSuperRate());
            var super = validator.ValidateInteger(inputReader.Read());
            outputWriter.Print(messages.NewLine());
            
            outputWriter.Print(messages.GetPaymentStartDate());
            var startDate = validator.ValidateDate(inputReader.Read());
            outputWriter.Print(messages.NewLine());
            
            outputWriter.Print(messages.GetPaymentEndDate());
            var endDate = validator.ValidateDate(inputReader.Read());
            outputWriter.Print(messages.NewLine());
            
            var payslip = new PaySlip(firstName,surname,salary,super,startDate,endDate);
            payslipRenderer.Render(payslip,outputWriter);
            outputWriter.Print(messages.NewLine());
            
            outputWriter.Print(messages.ThankUser());
        }
    }
}