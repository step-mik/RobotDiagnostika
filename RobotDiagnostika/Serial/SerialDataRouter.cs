using System;
using System.IO.Ports;

namespace RobotDiagnostika.Serial
{
    public class SerialDataRouter
    {
        private readonly SerialPort port;

        public event Action<string>? OnMotorStatus;
        public event Action<string>? OnBatteryStatus;
        public event Action<string>? OnSensorData;

        public SerialDataRouter(SerialPort port)
        {
            this.port = port;
            this.port.DataReceived += SerialDataReceived;
        }

        private void SerialDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string? line = port.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(line))
                    return;

                if (line.StartsWith("STATUS "))
                {
                    OnMotorStatus?.Invoke(line);
                }
                else if (line.StartsWith("BATTERY "))
                {
                    OnBatteryStatus?.Invoke(line);
                }
                else if (line.Contains("DISTANCE:"))
                {
                    OnSensorData?.Invoke(line);
                }
            }
            catch (IOException) { }
            catch (ObjectDisposedException) { }
            catch (Exception ex)
            {
                Console.WriteLine("[SerialDataRouter] Error: " + ex.Message);
            }
        }

        public void Detach()
        {
            port.DataReceived -= SerialDataReceived;
        }
    }
}
