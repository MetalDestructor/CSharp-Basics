using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM.Data
{
    public class GSM
    {
        public static readonly GSM IPhone4S = new GSM("iPhone 4S", "Apple", 500, "Pesho", new Battery("Buki", 48, 24, BatteryType.LiIon), new Display(4.5, 16000000));

        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public string Owner { get; set; }
        public Battery Battery { get; set; }
        public Display Display { get; set; }
        public List<Call> History { get; set; }

        public GSM()
        {
            this.Model = null;
            this.Manufacturer = null;
            this.Price = 0;
            this.Owner = null;
            this.Battery = new Battery(null, 0, 0, 0);
            this.Display = new Display(0, 0);
        }
        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = 0;
            this.Owner = null;
            this.Battery = new Battery(null, 0, 0, 0);
            this.Display = new Display(0, 0);
        }
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = new Battery(battery.Model, battery.HoursIdle, battery.HoursTalk, battery.BatteryType);
            this.Display = new Display(display.Size, display.Colors);
            this.History = new List<Call>();
        }

        public void Add(Call call)
        {
            History.Add(call);
        }

        public void Delete(Call call)
        {
            History.Remove(call);
        }

        public void Clear()
        {
            History.Clear();
        }

        public decimal CalcTotal(decimal pricePerCall)
        {
            long minutes = 0;
            foreach (var item in History)
            {
                minutes += item.Duration / 60;
            }

            return pricePerCall * minutes;
        }

        public void PrintCallHistory()
        {
            foreach (var item in History)
            {
                Console.WriteLine(item);
            }
        }

        public Call GetLongestCall()
        {
            long current = History.First().Duration;
            Call call = History.First();
            foreach (var item in History)
            {
                if (item.Duration > current)
                {
                    current = item.Duration;
                    call = item;
                }
            }
            return call;
        }

        public Call GetSmallestCall()
        {
            long current = History.First().Duration;
            Call call = History.First();
            foreach (var item in History)
            {
                if (item.Duration < current)
                {
                    current = item.Duration;
                    call = item;
                }
            }
            return call;
        }

        public override string ToString()
        {
            string info;
            info = string.Format("===============================================\nModel: {0}\nManufacturer: {1}\nPrice: {2}\nOwner: {3}\nBattery: \n\tModel: {4}\n\tHours Idle: {5}\n\tHours Talk: {6}\n\tType: {7}\nDisplay: \n\tSize: {8}\n\tColors: {9}\n=============================================== ", this.Model, this.Manufacturer, this.Price, this.Owner, this.Battery.Model, this.Battery.HoursIdle, this.Battery.HoursTalk, this.Battery.BatteryType, this.Display.Size, this.Display.Colors);
            return info;
        }
    }
}
