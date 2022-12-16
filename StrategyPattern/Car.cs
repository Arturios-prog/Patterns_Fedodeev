using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Car
    {
        private IDriveable _driveable;
        public void SetDrive(IDriveable driveable)
        {
            _driveable = driveable;
        }

        public void startDriving()
        {
            _driveable.Drive();
        }
    }
}
