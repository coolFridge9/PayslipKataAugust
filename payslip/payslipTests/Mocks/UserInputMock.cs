using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using payslip;

namespace payslipTests
{
    public class UserInputMocks : InputReaderInterface
    {
        private readonly List<string> _custom;
        private int index = -1;
        public UserInputMocks(List<string> custom)
        {
            _custom = custom;
        }

        public string Read()
        {
            index++;
            return _custom[index];  
        }
    }
}