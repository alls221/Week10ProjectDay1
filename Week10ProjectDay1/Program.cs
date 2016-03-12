using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10ProjectDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dvd aDvd = new Dvd();
            Book aBook = new Book();
            Magazine aMagazine = new Magazine();

            aDvd.ViewTitle();
            aDvd.AddTitle();
            aDvd.ViewTitle();
            aDvd.CheckOut();
            aDvd.ViewTitle();
            aDvd.CheckIn();
            aDvd.ViewTitle();

            aBook.ViewTitle();
            aBook.AddTitle();
            aBook.ViewTitle();
            aBook.CheckOut();
            aBook.ViewTitle();
            aBook.CheckIn();
            aBook.ViewTitle();

            aMagazine.ViewTitle();
            aMagazine.AddTitle();
            aMagazine.ViewTitle();
            aMagazine.CheckOut();
            aMagazine.ViewTitle();
            aMagazine.CheckIn();
            aMagazine.ViewTitle();
            

        }
       
    }
}
