using System;

namespace RobotDiagnostika.Logic
{
    public class BatteryIndicator
    {
        private const double R1 = 20000.0; // 20kΩ
        private const double R2 = 10000.0; // 10kΩ
        private const double MaxBatteryVoltage = 12.6;
        private const double MinBatteryVoltage = 11.46;

        // Výpočet skutečného napětí
        public static double CalculateBatteryVoltage(double analogVoltage)
        {
            return analogVoltage * ((R1 + R2) / R2);
        }

        // Výpočet procent stavu baterie
        public static int CalculateBatteryPercentage(double batteryVoltage)
        {
            double percent = (batteryVoltage - MinBatteryVoltage) / (MaxBatteryVoltage - MinBatteryVoltage);
            percent = Math.Clamp(percent, 0, 1);
            return (int)(percent * 100);
        }

        // Textové info např. "12.3 V (86%)"
        public static string FormatBatteryInfo(double analogVoltage)
        {
            double voltage = CalculateBatteryVoltage(analogVoltage);
            int percent = CalculateBatteryPercentage(voltage);
            return $"{voltage:F2} V ({percent}%)";
        }
    }
}
