using System.Collections.Generic;
using payslip;
using Xunit;

namespace payslipTests
{
    public class TextUserDisplayShould
    {
        [Fact]
        public void RunInterface()
        {
            var TUI = new TextUserDisplay();
            var mockInput = new UserInputMocks(new List<string>{"name","name","10000","7","10 May","20 May"});
            var mockOutput = new MockOutputAstext();
            TUI.Run(mockInput, new MockUserInputValidator(), new MockDisplayMessage(), mockOutput, new MockPayslipRenderer());
            const string expected = "1,N,2,N,3,N,4,N,5,N,6,N,7,N,test,N,8"; //mock display messages
            for (var i = 0; i < mockOutput.WriteText.Count; i++)
            {
                Assert.Equal(expected.Split(",")[i],mockOutput.WriteText[i]);
            }

            var numberOfOutputMessages = mockOutput.OutCounter;
            Assert.Equal(17,numberOfOutputMessages);
        }
    }
}