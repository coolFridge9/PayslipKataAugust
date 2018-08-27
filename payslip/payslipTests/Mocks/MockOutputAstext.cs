using System.Collections.Generic;
using payslip;

namespace payslipTests
{
    public class MockOutputAstext : OutInterface
    {
        public readonly List<string> WriteText = new List<string>();
        public int OutCounter = 0;
        public void Print(string text)
        {
            OutCounter++;
            WriteText.Add(text);
        }
    }
}