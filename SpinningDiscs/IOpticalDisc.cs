using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    interface IOpticalDisc
    {
        public void StoreData();
        public void LoadData();
        public void WriteData();
        public void ReadData();
        public void SpinDisc();
    }
}
