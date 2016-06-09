using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM.Data
{
    public class Call
    {
        public string Date { get; set; }
        public string Time { get; set; }
        public string DialedPhone { get; set; }
        public long Duration { get; set; }

        public Call()
        {
            this.Date = null;
            this.Time = null;
            this.DialedPhone = null;
            this.Duration = 0;
        }

        public Call(string date, string time, string dialedPhone, long duration)
        {
            this.Date = date;
            this.Time = time;
            this.DialedPhone = dialedPhone;
            this.Duration = duration;
        }

        public override string ToString()
        {
            string res;
            res = string.Format("==========\nDate: {0}\nTime: {1}\nDialed Phone: {2}\nDuration: {3}\n==========", this.Date, this.Time, this.DialedPhone, this.Duration);
            return res;
        }
    }
}
