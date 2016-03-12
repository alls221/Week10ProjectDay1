using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10ProjectDay1
{
   abstract class Resource
    {
        private string title;
        private string isbn;
        private int length;
        private string status;

        public string Title { get; set; }
        public string Isbn { get; set; }
        public int Length { get; set; }
        public string Status { get; set; }

        public virtual void ViewTitle()// method that prints out the title, isbn, length and status of object
        {
            Console.WriteLine("Title: "+Title);
            Console.WriteLine("ISBN: "+Isbn);
            Console.WriteLine("Number of pages"+Length);
            Console.WriteLine(Status);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        public virtual void AddTitle ()// method that allow the user to input values for the properties for a new instansiated object
        {
            Console.WriteLine("Enter the title");
            Title = Console.ReadLine();
            Console.WriteLine("Enter the ISBN number of the resource");
            Isbn =Console.ReadLine();
            Console.WriteLine("Enter the number of pages");
            Length = int.Parse(Console.ReadLine());
            Status = "Available";
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        
        public virtual void CheckOut () // changes status to "checked out" and generates a due date
        {
            Console.WriteLine("Enter the title to check out.");
            Title = Console.ReadLine();
            if (Status=="Available")
            {
                Status = "Checked Out";
                DateTime checkoutDate = new DateTime();
                checkoutDate = DateTime.Today;
                DateTime dueDate = checkoutDate.AddDays(3);
                Console.WriteLine(Title +" is "+ Status + " and needs to be returned on "+ dueDate+ ".");
            }
            else
            {
                Console.WriteLine("Resource is already checked out.");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        public virtual void CheckIn () // changes status to "Available"
        {
            Console.WriteLine("Enter the title to check in.");
            Title = Console.ReadLine();
            if (Status == "Checked Out") 
            {
                Status = "Available";
                Console.WriteLine(Title + "has been checked in.");
            }
            else
            {
                Console.WriteLine("Item is already checked in and can not be returned");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
