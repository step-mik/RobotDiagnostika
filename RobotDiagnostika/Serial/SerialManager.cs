using System;
using System.IO.Ports;

namespace RobotDiagnostika.Serial
{
    public class SerialManager
    {
        private SerialPort serialPort;
        public bool IsOpen => serialPort.IsOpen;

        public SerialManager(string portName, int baudRate = 9600)
        {
            serialPort = new SerialPort(portName, baudRate);
        }

        public void Open()
        {
            if (!serialPort.IsOpen)
                serialPort.Open();
        }

        public void Send(string message)
        {
            if (serialPort.IsOpen)
                serialPort.WriteLine(message);
        }

        public void Close()
        {
            if (serialPort.IsOpen)
                serialPort.Close();
        }
    }
}