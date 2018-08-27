namespace payslip
{
    public class DateHandler
    {
        private readonly string _start;
        private readonly string _end;
        public DateHandler(string start, string end)
        {
            _start = start;
            _end = end;
        }

        public override string ToString()
        {
            return Format(_start) + " - " + Format(_end);
        }

        private string Format(string date)
        {
            var len = date.Split(" ")[0].Length;
            var pad = "";
            if (len == 1)
                pad = "0";
            return pad + date;
        }
    }
}