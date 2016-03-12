using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10ProjectDay1
{
    class Dvd: Resource
    {
        public override void ViewTitle()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("ISBN: " + Isbn);
            Console.WriteLine( Length+ " minutes long");
            Console.WriteLine(Status);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        public override void AddTitle()
        {
            Console.WriteLine("Enter the DVD title");
            Title = Console.ReadLine();
            Console.WriteLine("Enter the ISBN number of the resource");
            Isbn = Console.ReadLine();
            Console.WriteLine("Enter the length in minutes");
            Length = int.Parse(Console.ReadLine());
            Status = "Available";
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
