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
            decimal phone = 0;
            Console.WriteLine("Enter a name of the customer:");
            firstName = Console.ReadLine();
            do
            {
                if (CheckName(firstName) == false)
                {
                    Console.WriteLine("Wrong format! Please try again:");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Enter a name of the customer:");
                    firstName = Console.ReadLine();
                }
            } while (CheckName(firstName) == false);

            Console.WriteLine("Enter a surname of the customer:");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter a telephone number of the customer:");
            phone = decimal.Parse(Console.ReadLine());
            do
            {
                if (customer.CheckPhoneNumberFormat(phone) == false)
                {
                    Console.WriteLine("Write format! Please try again:");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Enter a name of the customer:");
                    Console.WriteLine(firstName);
                    Console.WriteLine("Enter a surname of the customer:");
                    Console.WriteLine(lastName);
                    Console.WriteLine("Enter a telephone number of the customer:");
                    phone = decimal.Parse(Console.ReadLine());
                }
            } while (customer.CheckPhoneNumberFormat(phone) == false); 

            Console.Clear();
            Console.WriteLine("Name -" + " " + customer.ChangeName(firstName));
            Console.WriteLine("Surname -" + " " + customer.ChangeName(lastName));
            Console.WriteLine("Telephone number -" + " " + customer.SplitPhoneNumber(phone));
            Console.ReadKey();
        }
        public bool CheckName(string firstname)
        {
            List<char> letters = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'æ', 'ø', 'å' };
            bool IsOnlyLetters = false;
            foreach (char character in firstname)
            {
                if (letters.Contains(character))
                {
                    IsOnlyLetters = true;
                }
                else
                {
                    IsOnlyLetters = false;
                }
            }
            return IsOnlyLetters;
        }
    }
}

