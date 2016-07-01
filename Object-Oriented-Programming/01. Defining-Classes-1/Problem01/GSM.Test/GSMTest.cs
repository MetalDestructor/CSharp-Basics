using System;

namespace GSM.Test
{
    using GSM.Data;
    class GSMTest
    {
        public static void DeviceTest()
        {
            GSM[] phoneArray =
            {
                new GSM("Iphone 6S", "Apple", 800, "Pesho", new Battery("Hayo", 72, 48, BatteryType.NiCd), new Display(5.5, 16000000)),
                new GSM("Galaxy S7", "Samsung", 700, "Stoycho", new Battery("Bayo" , 48, 24, BatteryType.LiIon), new Display(5.7, 16000000)),
                new GSM("Galaxy Note 5", "Samsung", 650, "Kiro", new Battery("Mayo", 60, 36, BatteryType.NiMH), new Display(5.9, 15000000))
            };

            foreach (var item in phoneArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(GSM.IPhone4S);
        }
    }
}
