using System;
using System.Collections.Generic;
using System.Reflection;

namespace SpinningDiscs
{
    public class CD : BaseDisc , IOpticalDisc
    {
        // TODO: Implement your custom interface.

        public const double StorageCapacity = 500;

        public CD(double spinSpeed, string title, string contents, List<string> diskData) : base(spinSpeed, title, contents, diskData)
        {
        }

        public void StoreData()
        {
            Console.WriteLine("Storing CD");
        }

        public void LoadData()
        {
            Console.WriteLine("Loading CD");
        }

        public void WriteData()
        {
            Console.WriteLine("Writing CD");
        }

        public void ReadData()
        {
            Console.WriteLine("Reading CD");
        }

        public void SpinDisc()
        {
            Console.WriteLine("Spining CD");
        }



        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
    }
}
