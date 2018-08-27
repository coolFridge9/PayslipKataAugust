using System;
using System.Collections.Generic;
using System.Xml;

namespace payslip
{
    public class UserInputValidator : InputValidatorInterface

    {
        private readonly InputReaderInterface _reader;
        private readonly OutInterface _writer;
        private readonly DisplayMessageInterface _messages;
        public UserInputValidator(InputReaderInterface reader, OutInterface writer, DisplayMessageInterface messages)
        {
            _reader = reader;
            _writer = writer;
            _messages = messages;
        }
        public string ValidateName(string name)
        {
            if (name.Length > 0 && name.Length < 15)
                return name;
            _writer.Print(_messages.Error());
            return ValidateName(_reader.Read());
        }
    
        public int ValidateInteger(string num)
        {
            if (int.TryParse(num, out var intNum))
                return intNum;
            _writer.Print(_messages.Error());
            return ValidateInteger(_reader.Read());
        }

        public string ValidateDate(string date)
        {
            var splitDate = date.Split(" ");
            if (splitDate.Length != 2)
            {
                _writer.Print(_messages.Error());
                return ValidateDate(_reader.Read());
            }

            if (int.TryParse(splitDate[0], out var intNum))
                return date;
            
            _writer.Print(_messages.Error());
            return ValidateDate(_reader.Read());
        }
    }
}