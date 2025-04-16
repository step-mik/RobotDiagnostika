using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDiagnostika.Logic
{
    public static class BatteryIndicator
    {
        public static double CalculateVoltageFromLine(string line)
        {
            var voltageStr = GetValueAfter(line, "VOLTAGE:").Replace("V", "");
            return double.TryParse(voltageStr, out var voltage) ? voltage : 0;
        }

        public static int CalculatePercentFromLine(string line)
        {
            var percentStr = GetValueAfter(line, "PERCENT:").Replace("%", "");
            return int.TryParse(percentStr, out var percent) ? percent : 0;
        }

        private static string GetValueAfter(string input, string keyword)
        {
            int start = input.IndexOf(keyword);
            if (start == -1) return "";
            start += keyword.Length;
            int end = input.IndexOf(' ', start);
            if (end == -1) end = input.Length;
            return input.Substring(start, end - start);
        }
    }
}

