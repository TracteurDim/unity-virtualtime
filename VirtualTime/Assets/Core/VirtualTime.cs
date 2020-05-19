using UnityEngine;

namespace VirtualTimeCore
{

    public struct VirtualTime
    {

        private const int SECONDS_IN_MINUTE = 60;
        private const int MINUTES_IN_HOUR = 60;
        private const int SECONDS_IN_HOUR = SECONDS_IN_MINUTE * MINUTES_IN_HOUR;

        public int Hours
        {
            get { return Mathf.FloorToInt(_time / SECONDS_IN_HOUR); }
            set { SetHours(value);  }
        }
        public int Minutes
        {
            get { return Mathf.FloorToInt((_time - Hours * SECONDS_IN_HOUR) / SECONDS_IN_MINUTE); }
            set { SetMinutes(value); }
        }
        public float Seconds
        {
            get { return _time - Hours * SECONDS_IN_HOUR - Minutes * SECONDS_IN_MINUTE; }
            set { SetSeconds(value); }
        }


        // The total time in seconds
        public float TotalSeconds => _time;
        private float _time;

        public VirtualTime(int hours = 0, int minutes = 0, float seconds = 0)
        {
            _time = 0;
            Set(hours, minutes, seconds);
        }

        public void Set(int hours, int minutes = 0, float seconds = 0)
        {
            _time = hours * SECONDS_IN_HOUR + minutes * SECONDS_IN_MINUTE + seconds;
        }

        private void SetHours(int hours)
        {
            Set(hours, Minutes, Seconds);
        }

        private void SetMinutes(int minutes)
        {
            Set(Hours, minutes, Seconds);
        }

        private void SetSeconds(float seconds)
        {
            Set(Hours, Minutes, seconds);
        }

    }

}