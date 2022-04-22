namespace PressureAlarm
{
    public class PressAlarm
    {

        private const double lowPressureThreshold = 15;
        private const double highPressureThreshold = 32;
        ISensor Isensor = null;
        bool alarm = false;

        public PressAlarm(ISensor sensor)
        {
            Isensor = sensor;
        }

        public void Check()
        {
            double pressure = Isensor.QueryHardwareForPsiValue();
            if (pressure < lowPressureThreshold || highPressureThreshold < pressure)
            {
                alarm = true;
            }
        }

        public bool Alarm
        {
            get { return alarm; }
        }
    }
}