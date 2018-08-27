using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using payslip;
using Xunit;

namespace payslipTests
{
    public class UserInputValidatorShould
    {

        [Fact]
        public void ValidateNames() 
        { 
            var output = new MockOutputAstext();
            var inputValidator = new UserInputValidator(new UserInputMocks(new List<string>()), output, new MockDisplayMessage());
            var result = inputValidator.ValidateName("maaa");
            Assert.Equal("maaa",result);
            var numberOfErrorMessages = output.OutCounter;
            Assert.Equal(0,numberOfErrorMessages);
        }
        
        [Fact]
        public void ValidateNamesUntilValid() 
        { 
            var output = new MockOutputAstext();
            var backupUserInputs = new List<string> {"tim"};
            var inputValidator = new UserInputValidator(new UserInputMocks(backupUserInputs), output, new MockDisplayMessage());
            var result = inputValidator.ValidateName("");
            Assert.Equal("tim",result);
            var numberOfErrorMessages = output.OutCounter;
            Assert.Equal(1,numberOfErrorMessages);
        }
        
        [Fact]
        public void ValidateNumbers() 
        { 
            var output = new MockOutputAstext();
            var inputValidator = new UserInputValidator(new UserInputMocks(new List<string>()), output, new MockDisplayMessage());
            var result = inputValidator.ValidateInteger("47657");
            Assert.Equal(47657,result);
            var numberOfErrorMessages = output.OutCounter;
            Assert.Equal(0,numberOfErrorMessages);
        }
        
        [Fact]
        public void AcceptNumbersUntilValid() 
        { 
            var output = new MockOutputAstext();
            var backupUserInputs = new List<string> {"3333"};
            var inputValidator = new UserInputValidator(new UserInputMocks(backupUserInputs), output, new MockDisplayMessage());
            var result = inputValidator.ValidateInteger("sdfbf");
            Assert.Equal(3333,result);
            var numberOfErrorMessages = output.OutCounter;
            Assert.Equal(1,numberOfErrorMessages);
        }
        
        [Fact]
        public void AcceptNumbersUntilValid2() 
        { 
            var output = new MockOutputAstext();
            var backupUserInputs = new List<string> {"xkfjnlfn", "dgf", "565"};
            var inputValidator = new UserInputValidator(new UserInputMocks(backupUserInputs), output, new MockDisplayMessage());
            var result = inputValidator.ValidateInteger("sdfbf");
            Assert.Equal(565,result);
            var numberOfErrorMessages = output.OutCounter;
            Assert.Equal(3,numberOfErrorMessages);
        }
        
        [Fact]
        public void ValidateDates() 
        { 
            var output = new MockOutputAstext();
            var inputValidator = new UserInputValidator(new UserInputMocks(new List<string>()), output, new MockDisplayMessage());
            var result = inputValidator.ValidateDate("31 March");
            Assert.Equal("31 March",result);
            var numberOfErrorMessages = output.OutCounter;
            Assert.Equal(0,numberOfErrorMessages);
        }
        
        [Fact]
        public void ValidateDatesUntilValid() 
        { 
            var output = new MockOutputAstext();
            var backupUserInputs = new List<string> {"dsf","10 may"};
            var inputValidator = new UserInputValidator(new UserInputMocks(backupUserInputs), output, new MockDisplayMessage());
            var result = inputValidator.ValidateDate("xdksnf");
            Assert.Equal("10 may",result);
            var numberOfErrorMessages = output.OutCounter;
            Assert.Equal(2,numberOfErrorMessages);
        }
    }
}