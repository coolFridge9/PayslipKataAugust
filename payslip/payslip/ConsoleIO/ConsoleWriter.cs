using System;

namespace payslip
{
    public class ConsoleWriter : OutInterface
    {
        public void Print(string text)
        {
            Console.Write(text);
        }
    }
}