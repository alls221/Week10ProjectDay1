using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10ProjectDay1
{
    class Book: Resource
    {
        public override void CheckOut()
        {
            Console.WriteLine("Enter the title to check out.");
            Title = Console.ReadLine();
            if (Status == "Available")
            {
                Status = "Checked Out";
                DateTime checkoutDate = new DateTime();
                checkoutDate = DateTime.Today;
                DateTime dueDate = checkoutDate.AddDays(5);
                Console.WriteLine(Title + " is " + Status + " and needs to be returned on " + dueDate + ".");
            }
            else
            {
                Console.WriteLine("Resource is already checked out.");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
