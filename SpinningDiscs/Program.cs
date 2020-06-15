using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            List<string> tracks = new List<string>();

            tracks.Add("Track 1");
            tracks.Add("Track 2");
            tracks.Add("Track 3");
            tracks.Add("Track 4");
            tracks.Add("Track 5");

            CD myCd = new CD(500, "Luke Combs", "country", tracks);

            myCd.SpinDisc();
            myCd.LoadData();
            myCd.ReadData();
            myCd.StoreData();
            myCd.WriteData();
            myCd.DisplayMenu();
            myCd.DisplayData(tracks);



            List<string> chapters = new List<string>();

            chapters.Add("Chp 1");
            chapters.Add("Chp 2");
            chapters.Add("Chp 3");
            chapters.Add("Chp 4");

            DVD myDvd = new DVD(200, "Extraction", "Action", chapters);

            myDvd.SpinDisc();
            myDvd.LoadData();
            myDvd.ReadData();
            myDvd.StoreData();
            myDvd.WriteData();
            myDvd.DisplayMenu();
            myDvd.DisplayData(chapters);

            // TODO: Call each CD and DVD method to verify that they work as expected.
        }
    }
}
