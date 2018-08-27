using System;

namespace payslip
{
    public class ConsoleReader : InputReaderInterface
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}