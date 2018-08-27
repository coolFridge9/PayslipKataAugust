using System.Collections.Generic;

namespace payslip
{
    public class DisplayMessages : DisplayMessageInterface
    {
        public string Welcome()
        {
            return "Welcome to the payslip generator!";
        }

        public string GetName()
        {
            return "Please input your name: ";
        }

        public string GetSurname()
        {
            return "Please input your surname: ";
        }

        public string GetSalary()
        {
            return "Please input your annual salary: ";
        }

        public string GetSuperRate()
        {
            return "Please input your super rate: ";
        }

        public string GetPaymentStartDate()
        {
            return "Please input your payment start date: ";
        }

        public string GetPaymentEndDate()
        {
            return "Please input your payment end date: ";
        }

        public string ThankUser()
        {
            return "Thank you for using MYOB!";
        }

        public string Error()
        {
            return "Error, Try Again: ";
        }

        public string NewLine()
        {
            return "\n";
        }
    }
}