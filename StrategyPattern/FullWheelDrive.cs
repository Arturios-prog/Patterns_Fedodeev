using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class FullWheelDrive : IDriveable
    {
        public void Drive()
        {
            Console.WriteLine("Full wheel car Drives");
        }
    }
}
