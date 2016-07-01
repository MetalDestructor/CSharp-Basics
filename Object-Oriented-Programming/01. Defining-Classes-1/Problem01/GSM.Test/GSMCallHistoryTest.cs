using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM.Test
{
    using GSM.Data;

    public static class GSMCallHistoryTest
    {
        public static void CallHistory()
        {
            GSM nev = new GSM("Asdio", "Asdan", 123.123M, "Pesho", new Battery("Hahao", 48, 24, BatteryType.LiIon), new Display(3.5, 123123123));

            nev.Add(new Call("04. 03. 2015", "11:30", "0888888888", 360));
            nev.Add(new Call("06. 06. 2016", "12:35", "0877777777", 956));
            nev.Add(new Call("06. 07. 2016", "20:10", "0877777777", 1082));
            nev.PrintCallHistory();
            Console.WriteLine(nev.CalcTotal(0.37M));
            nev.Delete(nev.GetLongestCall());
            Console.WriteLine(nev.CalcTotal(0.37M));
            nev.Clear();
            Console.WriteLine(nev.CalcTotal(0.37M));
        }
    }
}
