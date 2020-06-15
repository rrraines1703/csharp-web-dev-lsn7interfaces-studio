using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.

        public const double StorageCapacity = 200;
        public double Time { get; set; }

        public DVD(double spinSpeed, string title, string contents, List<string> diskData) : base(spinSpeed, title, contents, diskData)
        {
        }

        public void StoreData()
        {
            Console.WriteLine("Storing DVD");
        }

        public void LoadData()
        {
            Console.WriteLine("Loading DVD");
        }

        public void WriteData()
        {
            Console.WriteLine("Writing DVD");
        }

        public void ReadData()
        {
            Console.WriteLine("Reading DVD");
        }

        public void SpinDisc()
        {
            Console.WriteLine("Spining DVD");
        }
    }
}
