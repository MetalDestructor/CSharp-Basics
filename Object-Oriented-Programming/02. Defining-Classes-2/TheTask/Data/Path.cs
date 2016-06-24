using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTask.Data
{
    public class Path
    {
        public Point3D[] Points { get; set; }

        public Path()
        {
            this.Points = new Point3D[2];
            this.Points[0].X = 0;
            this.Points[0].Y = 0;
            this.Points[0].Z = 0;
            this.Points[1].X = 0;
            this.Points[1].Y = 0;
            this.Points[1].Z = 0;
        }
        public Path(Point3D[] path)
        {
            this.Points = path;
        }
        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < Points.Length; i++)
            {
                if (i == Points.Length - 1)
                {
                    res += Points[i].ToString();
                }
                else
                {
                    res += Points[i].ToString() + ',';
                }

            }
            return res;
        }
    }
    public static class PathStorage
    {
        static PathStorage()
        {

        }

        public static void Save(Path path, string filePath)
        {
            var writer = new StreamWriter(filePath);
            using (writer)
            {
                writer.WriteLine(path.ToString());
            }
        }

        public static Path Load(string filePath)
        {
            var reader = new StreamReader(filePath);
            Path path = new Path();
            using (reader)
            {
                string file = reader.ReadToEnd();
                string[] points = file.Split(',').ToArray();
                double[] dots;
                Point3D[] pts = new Point3D[points.Length];
                for (int i = 0; i < points.Length; i++)
                {
                    dots = points[i].Split(' ').Select(double.Parse).ToArray();
                    pts[i] = new Point3D(dots[0], dots[1], dots[2]);
                }
            }
            return path;
        }
    }
}
