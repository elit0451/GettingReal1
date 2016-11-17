using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair1
{
    public class Customer
    {
        public decimal Phone { get; set; }

        public string Name { get; set; }
        public Customer()
        {

        }
        public Customer(string name, decimal phone)
        {
            Name = name;
            Phone = phone;
        }
        public string ChangeName(string name)
        {
            string holdingWord = "";
            string[] words = name.Split(' ');
            foreach (string word in words)
            {
                string firstLetter = word.Substring(0, 1);
                firstLetter = firstLetter.ToUpper();
                holdingWord = holdingWord + " " + firstLetter + word.Substring(1).ToLower();
            }
            return holdingWord.Trim();
        }
        public string SplitPhoneNumber(decimal phone)
        {
            decimal number = phone;
            string value = number.ToString("## ## ## ##");
            return value; 
        }
    }
}
