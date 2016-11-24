﻿using System;
using System.Collections.Generic;
using System.Linq;
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
            string phone = "";
            Console.WriteLine("Enter the first name of the customer:");
            firstName = Console.ReadLine();
            do
            {
                if (CheckName(firstName) == false)
                {
                    Console.WriteLine("Wrong format! Please try again:");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Enter the first name of the customer:");
                    firstName = Console.ReadLine();
                }
            } while (CheckName(firstName) == false);

            Console.WriteLine("Enter the last name of the customer:");
            lastName = Console.ReadLine();
            do
            {
                if (CheckName(lastName) == false)
                {
                    Console.WriteLine("Wrong format! Please try again:");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Enter the first name of the customer:");
                    Console.WriteLine(firstName);
                    Console.WriteLine("Enter the last name of the customer:");
                    lastName = Console.ReadLine();
                }
            } while (CheckName(lastName) == false);

            Console.WriteLine("Enter the telephone number of the customer:");
            phone = Console.ReadLine();
            do
            {
                if (customer.CheckPhoneNumberFormat(phone) == false || CheckPhoneNumberForSomethingDifferentThanDigits(phone) == false)
                {
                    Console.WriteLine("Wrong format! Please try again:");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Enter the first name of the customer:");
                    Console.WriteLine(firstName);
                    Console.WriteLine("Enter the last name of the customer:");
                    Console.WriteLine(lastName);
                    Console.WriteLine("Enter the telephone number of the customer:");
                    phone = Console.ReadLine();
                }
            } while (customer.CheckPhoneNumberFormat(phone) == false || CheckPhoneNumberForSomethingDifferentThanDigits(phone) == false);

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
    }
}

