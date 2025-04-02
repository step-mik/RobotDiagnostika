using RobotDiagnostika.Serial;

namespace RobotDiagnostika
{
    public partial class ServoControlForm : Form
    {
        private SerialManager _serial;

        public ServoControlForm(SerialManager serial)
        {
            InitializeComponent();
            _serial = serial;
        }

        // sem přijdou tlačítka pro ovládání serva
    }
}
