using System;
using System.Collections.Generic;
using System.Linq;
using PrettyHair1;


namespace PrettyHair
{
    public class Program
    {
        string firstName = "";
        string lastName = "";
        string phone = "";
        Customer customer = new Customer();
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }
        public void Run()
        {
            firstName = ReadLine("first name");
            Console.Clear();
            lastName = ReadLine("last name");
            Console.Clear();
            phone = ReadLine("telephone number");

            Console.Clear();
            Console.WriteLine("Name -" + " " + customer.ChangeName(firstName));
            Console.WriteLine("Last name -" + " " + customer.ChangeName(lastName));
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
        public bool CheckPhoneNumberForSomethingDifferentThanDigits(string phone)
        {
            List<char> numbers = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            bool IsOnlyInts = false;
            foreach (char digit in phone)
            {
                if (phone.Contains(digit))
                {
                    IsOnlyInts = true;
                }
                else
                {
                    IsOnlyInts = false;
                }
            }
            return IsOnlyInts;
        }
        // --------------------------------------------------------------------------
        public string ReadLine(string parameter)
        {
            string openingSentence = "Enter the " + parameter + " of the customer:";
            string message = "Wrong format! Please try again:";
            Console.WriteLine(openingSentence);
            string input = Console.ReadLine();
            switch (parameter)
            {
                case "first name":
                    if (CheckName(input) == false)
                    {
                        Console.WriteLine(message);
                        Console.ReadKey();
                        Console.Clear();
                        firstName = ReadLine(parameter);
                    }
                    break;
                case "last name":
                    if (CheckName(input) == false)
                    {
                        Console.WriteLine(message);
                        Console.ReadKey();
                        Console.Clear();
                        lastName = ReadLine(parameter);
                    }
                    break;
                case "telephone number":
                    if (customer.CheckPhoneNumberFormat(input) == false || CheckPhoneNumberForSomethingDifferentThanDigits(input) == false)
                    {
                        Console.WriteLine(message);
                        Console.ReadKey();
                        Console.Clear();
                        phone = ReadLine(parameter);
                    }
                    break;
            }
            return input;
        }


        //-----------------------------------------------------------------------------
        /* public string TakeCustomerDetails(string data)
        {
            string openingSentence = "Enter the " + data + " of the customer:";
            string message = "Wrong format! Please try again:";
            do
            {
                Console.WriteLine(openingSentence);
                string input = Console.ReadLine();
                if (data == "first name")
                {
                    firstName = input;
                    if (CheckName(firstName) == false)
                    {
                        Console.WriteLine(message);
                        Console.ReadKey();
                        Console.Clear();
                        firstName = TakeCustomerDetails(data);
                    }
                    
                }
                if (data == "last name")
                {
                    lastName = input;
                    if (CheckName(lastName) == false)
                    {
                        Console.WriteLine(message);
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine(openingSentence);
                        lastName = Console.ReadLine();

                    }
                }
                if (data == "telephone number")
                {
                    phone = input;
                    if (customer.CheckPhoneNumberFormat(phone) == false || CheckPhoneNumberForSomethingDifferentThanDigits(phone) == false)
                    {
                        Console.WriteLine(message);
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine(openingSentence);
                        phone = Console.ReadLine();
                    }
                }
            } while (CheckName(firstName) == false || CheckName(lastName) == false || customer.CheckPhoneNumberFormat(phone) == false || CheckPhoneNumberForSomethingDifferentThanDigits(phone) == false);
            Console.Clear();
            Console.WriteLine("Name -" + " " + customer.ChangeName(firstName));
            Console.WriteLine("Last name -" + " " + customer.ChangeName(lastName));
            Console.WriteLine("Telephone number -" + " " + customer.SplitPhoneNumber(phone));
            Console.ReadKey();
            return data;
        }*/
        // --------------------------------------------------------------------------------
    }
}

