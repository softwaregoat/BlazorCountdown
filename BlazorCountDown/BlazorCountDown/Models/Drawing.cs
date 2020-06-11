using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCountDown.Models
{
    public class Drawing
    {
        public int ID;
        public int days;
        public int hours;
        public int minutes;
        public int seconds;
        public DateTime time = new DateTime();

        public Drawing(int ID, DateTime time)
        {
            this.ID = ID;
            this.time = time;
            GetValues();
        }
        public void GetValues()
        {
            var countDownDate = this.time;
            var now = DateTime.Now;
            var distance = countDownDate.Subtract(now);

            var days = distance.Days;
            var hours = distance.Hours;
            var minutes = distance.Minutes;
            var seconds = distance.Seconds;

            this.days = days;
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }
    }
}
