namespace TestDotNetProject.Events
{
    public class AlarmEventArgs
    {
        private readonly int nRings = 0;
        private readonly bool pressed = false;
        private string text = "The alarm is ringing!";

        // Constructor.
        public AlarmEventArgs(bool snoozePressed, int nRings) 
        {
            this.pressed = snoozePressed;
            this.nRings = nRings;
        }

        // Properties.
        public string AlarmText {  
            get { return text; }
            set { this.text = value; }
        }

        public int NumRings {
            get { return nRings; }
        }

        public bool SnoozePressed {
            get { return pressed; }
        }
    }
}