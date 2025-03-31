using RobotDiagnostika.Serial;

namespace RobotDiagnostika.Logic

{
    public class RightMotor
    {
        private readonly SerialManager _serial;
        private bool _rightMotorRunning = false;
        public RightMotor(SerialManager serial)
        {
            _serial = serial;
        }
        public bool ToggleRightMotor()
        {
            if (!_serial.IsOpen) return false;
            if (!_rightMotorRunning)
            {
                _serial.Send("RIGHT_MOTOR_ON");
            }
            else
            {
                _serial.Send("RIGHT_MOTOR_OFF");
            }
            _rightMotorRunning = !_rightMotorRunning;
            return _rightMotorRunning;
        }
    }
}
