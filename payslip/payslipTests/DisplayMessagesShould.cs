using System.Collections.Generic;
using payslip;
using Xunit;

namespace payslipTests
{
    public class DisplayMessagesShould
    {
        private readonly DisplayMessages _displayMessages;

        public DisplayMessagesShould()
        {
            _displayMessages = new DisplayMessages();
        }
        
        [Fact]
        public void DisplayWelcomeMessage()
        {
            var result =_displayMessages.Welcome();
            var expected = "Welcome to the payslip generator!";
            Assert.Equal(expected,result);
        }
        
        [Fact]
        public void DisplayGetNameMessage()
        {
            var result =_displayMessages.GetName();
            var expected = "Please input your name: ";
            Assert.Equal(expected,result);
        } 
        
        [Fact]
        public void DisplayGetSurnameMessage()
        {
            var result =_displayMessages.GetSurname();
            var expected = "Please input your surname: ";
            Assert.Equal(expected,result);
        }
        
        [Fact]
        public void DisplayGetSalaryMessage()
        {
            var result =_displayMessages.GetSalary();
            var expected = "Please input your annual salary: ";
            Assert.Equal(expected,result);
        }
        
        [Fact]
        public void DisplayGetSuperRate()
        {
            var result =_displayMessages.GetSuperRate();
            var expected = "Please input your super rate: ";
            Assert.Equal(expected,result);
        }
        
        [Fact]
        public void DisplayPaymentStartDate()
        {
            var result =_displayMessages.GetPaymentStartDate();
            var expected = "Please input your payment start date: ";
            Assert.Equal(expected,result);
        }
        
        [Fact]
        public void DisplayPaymentEndDate()
        {
            var result =_displayMessages.GetPaymentEndDate();
            var expected = "Please input your payment end date: ";
            Assert.Equal(expected,result);
        }
        
        [Fact]
        public void DisplayThankYouMessage()
        {
            var result =_displayMessages.ThankUser();
            var expected = "Thank you for using MYOB!";
            Assert.Equal(expected,result);
        }
        
        [Fact]
        public void DisplayErrorMessage()
        {
            var result =_displayMessages.Error();
            var expected = "Error, Try Again: ";
            Assert.Equal(expected,result);
        }
        [Fact]
        public void DisplayNewLine()
        {
            var result =_displayMessages.NewLine();
            var expected = "\n";
            Assert.Equal(expected,result);
        }
    }
}