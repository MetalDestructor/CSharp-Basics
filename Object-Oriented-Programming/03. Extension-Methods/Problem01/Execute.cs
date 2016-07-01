using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    using Problem01.Tests;
    public class Execute
    {
        public static void Main()
        {
            ExtensionsTest.Test();

            LINQTests.Test();

            LINQTests.Test2();

            LINQTests.Test3();

            LINQTests.Test4();

            TimerTest.Test();

            LINQTests.Test5();

            //CovergentSeriesTests.Test();
        }
    }
}
