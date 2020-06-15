using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public double SpinSpeed { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }

        public List<string> DiskData;

        public BaseDisc(double spinSpeed, string title, string contents, List<string> diskData)
        {
            SpinSpeed = spinSpeed;
            Title = title;
            Contents = contents;
            DiskData = diskData;
        }

        public virtual void DisplayData(List<string> diskData)
        {
            int counter = 1;
            foreach (string item in diskData)
            {

                Console.WriteLine(counter.ToString() + ". " + item);
                counter++;
            }
            Console.WriteLine("\n_________________\n");
        }
        public virtual void DisplayMenu()
        {
            Console.WriteLine($"\nTitle: {Title}\nGenre: {Contents}\n");

        }

    }
}
