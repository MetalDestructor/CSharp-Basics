using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM.Data
{
    public class Display
    {
        public double Size { get; set; }
        public long Colors { get; set; }

        public Display()
        {
            this.Size = 0;
            this.Colors = 0;
        }
        public Display(double size, long colors)
        {
            this.Size = size;
            this.Colors = colors;
        }
    }
}
