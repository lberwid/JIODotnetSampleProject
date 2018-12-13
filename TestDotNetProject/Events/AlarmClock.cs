using System;

namespace TestDotNetProject.Events
{
    public class AlarmClock 
    {
        public void Start()
        {
            AlarmEventArgs e = new AlarmEventArgs(false, 0);
            OnAlarm(e);
        }

        public event AlarmEventHandler Alarm;

        protected virtual void OnAlarm(AlarmEventArgs e)
        {
            if (Alarm != null) 
                Alarm(this, e); 
        }
    }
}