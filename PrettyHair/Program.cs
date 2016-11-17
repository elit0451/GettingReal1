using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair1;


namespace PrettyHair
{
    public class Program
    {
        Customer customer = new Customer();
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }
        public void Run()
        {
            string firstName = "";
            string lastName = "";
            decimal phone = 0; // find a way to do it as a int9
            Console.WriteLine("Enter a name of the customer:");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter a surname of the customer:");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter a telephone number of the customer:");
            phone = decimal.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Name -" + " " + customer.ChangeName(firstName));
            Console.WriteLine("Surname -" + " " + customer.ChangeName(lastName)); 
            Console.WriteLine("Telephone number -" + " " + customer.SplitPhoneNumber(phone));
            Console.ReadKey();
        }
    }
}
