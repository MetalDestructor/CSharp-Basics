using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM.Data
{
    public enum BatteryType
    {
        none, LiIon, NiMH, NiCd
    }
    public class Battery
    {
        public string Model { get; set; }
        public int HoursIdle { get; set; }
        public int HoursTalk { get; set; }
        public BatteryType BatteryType { get; set; }

        public Battery()
        {
            this.Model = "";
            this.HoursIdle = 0;
            this.HoursTalk = 0;
            this.BatteryType = 0;
        }
        public Battery(string model, int idle, int talk, BatteryType bt)
        {
            this.Model = model;
            this.HoursIdle = idle;
            this.HoursTalk = talk;
            this.BatteryType = bt;
        }
    }
}
