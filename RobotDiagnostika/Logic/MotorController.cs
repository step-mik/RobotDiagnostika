﻿using RobotDiagnostika.Serial;

namespace RobotDiagnostika.Logic
{
    public class MotorController
    {
        private readonly SerialManager _serial;
        private bool _leftMotorRunning = false;

        public MotorController(SerialManager serial)
        {
            _serial = serial;
        }

        public bool ToggleLeftMotor()
        {
            if (!_serial.IsOpen) return false;

            if (!_leftMotorRunning)
            {
                _serial.Send("LEFT_MOTOR_ON");
            }
            else
            {
                _serial.Send("LEFT_MOTOR_OFF");
            }

            _leftMotorRunning = !_leftMotorRunning;
            return _leftMotorRunning;
        }
    }
}

