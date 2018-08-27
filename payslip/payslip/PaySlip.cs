using System;

namespace payslip
{
    public class PaySlip : PaySlipInterface
    {
        private readonly string _firstName;
        private readonly string _surname;
        private readonly int _salary;
        private readonly int _superRate;
        private readonly string _startDate;
        private readonly string _endDate;
        
        public PaySlip(string firstName, string surname, int salary, int superRate, string startDate, string endDate)
        {
            _firstName = firstName;
            _surname = surname;
            _salary = salary;
            _superRate = superRate;
            _startDate = startDate;
            _endDate = endDate;
        }

        public string Name()
        {
            return _firstName + " " + _surname;
        }

        public string PayPeriod()
        {
            var dateHandler = new DateHandler(_startDate, _endDate);
            return dateHandler.ToString();
        }

        public int GrossIncome()
        {
            var income = _salary / 12.0;
            return Rounder.Round(income);
        }

        public int Tax()
        {
            var taxCalc = new TaxCalculator();
            return taxCalc.GetTax(_salary);
        }

        public int NetIncome()
        {
            return GrossIncome() - Tax();
        }

        public int Super()
        {
            var super = GrossIncome() * _superRate / 100.0;
            return Rounder.Round(super);
        }
    }
}