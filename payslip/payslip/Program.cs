using System;

namespace payslip
{
    class Program
    {
        static void Main(string[] args)
        {
            var display = new TextUserDisplay();
            display.Run(new ConsoleReader(), new UserInputValidator(new ConsoleReader(), new ConsoleWriter(), new DisplayMessages()),
                new DisplayMessages(), new ConsoleWriter(), new PayslipRenderer() );
        }
    }
}