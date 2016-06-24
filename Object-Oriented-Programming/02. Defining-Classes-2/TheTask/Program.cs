using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTask
{
    using Data;
    class Program
    {
        static void Main(string[] args)
        {
            Point3D[] pts = new Point3D[5];
            for (int i = 0; i < 5; i++)
            {
                pts[i].X = i;
                pts[i].Y = i;
                pts[i].Z = i;
            }
            var path = new Path(pts);
            string filePath = @"C:\Users\just_metal1337\Dropbox\Workspace\GitHubRepos\SoftwareAcademyS7\Object-Oriented-Programming\02. Defining-Classes-2\TheTask\test.txt";
            PathStorage.Save(path, filePath);

        }
    }
}
