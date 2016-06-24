using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTask.Data
{
    public struct Point3D
    {
        private static readonly Point3D O = new Point3D(0, 0, 0);
         

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public static Point3D getO()
        {
            return O;
        }
        public override string ToString()
        {
            string res = string.Format("{0} {1} {2}", this.X, this.Y, this.Z);
            return res;
        }

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
