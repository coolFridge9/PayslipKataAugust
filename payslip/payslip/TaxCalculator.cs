using System;
using System.Collections.Generic;

namespace payslip
{
    public class TaxCalculator
    {
        public int GetTax(int salary)
        {
            var taxBrackets = new List<int> (new int[]{180000,87000,37000,18200,0});
            
            var taxBracketValues = new Dictionary<int,List<double>>
            {
                {taxBrackets[4],new List<double>{0,0}},
                {taxBrackets[3],new List<double>{19,0}},
                {taxBrackets[2],new List<double>{32.5,3572}},
                {taxBrackets[1],new List<double>{37,19822}},
                {taxBrackets[0],new List<double>{45,54232}}
            };

            foreach (var taxBracket in taxBrackets)
            {
                var cents = taxBracketValues[taxBracket][0];
                var baseTax = taxBracketValues[taxBracket][1];
                
                if (salary > taxBracket)
                {
                    var tax = (baseTax + (salary - taxBracket) * (cents / 100) )/ 12;
                    return Rounder.Round(tax);
                }
            }

            return 0;
        }
    }
}