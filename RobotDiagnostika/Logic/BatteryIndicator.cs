using System.Text.RegularExpressions;

namespace RobotDiagnostika.Logic
{
    public static class BatteryIndicator
    {
        public static double CalculateVoltageFromLine(string line)
        {
            try
            {
                var match = Regex.Match(line, @"BATTERY VOLTAGE:(\d+[.,]\d+)V");
                if (match.Success)
                {
                    string voltageRaw = match.Groups[1].Value.Replace(',', '.');
                    if (double.TryParse(voltageRaw, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out var voltage))
                        return voltage;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Voltage error: " + ex.Message);
            }
            return 0;
        }


        public static int CalculatePercentFromLine(string line)
        {
            try
            {
                var match = Regex.Match(line, @"PERCENT:(\d+)%");
                if (match.Success && int.TryParse(match.Groups[1].Value, out var percent))
                    return percent;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Percent error: " + ex.Message);
            }
            return 0;
        }
    }
}
