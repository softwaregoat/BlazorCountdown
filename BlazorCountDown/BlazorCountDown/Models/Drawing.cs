using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCountDown.Models
{
    public class Drawing
    {
        public int ID;
        public DateTime time = new DateTime();
        public Drawing(int ID, DateTime time)
        {
            this.ID = ID;
            this.time = time;
        }
    }
}
