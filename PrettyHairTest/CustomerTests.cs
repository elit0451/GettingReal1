using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair1;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace PrettyHairTest
{
    [TestClass]
    public class CustomerTests
    {
        private Customer customer;

        [TestInitialize]
        public void SetuoForTest()
        {
            customer = new Customer();
        }

        [TestMethod]
        public void ShouldCapitalizeFirstLetterInTheName()
        {
            customer.Name = "nina";
            Assert.AreEqual("Nina", customer.ChangeName(customer.Name));
        }

        [TestMethod]
        public void ShouldCapitalizeEveryWord()
        {
            customer.Name = "anna maria";
            Assert.AreEqual("Anna Maria", customer.ChangeName(customer.Name));
        }

        [TestMethod]
        public void ShouldCapitalizeFirstLetterButKeepTheRestLower()
        {
            customer.Name = "isAbella";
            Assert.AreEqual("Isabella", customer.ChangeName(customer.Name));
        }

        [TestMethod]
        public void ShouldCapitalizeFirstLetterButKeepTheRestLowerOnEveryWord()
        {
            customer.Name = "isAbella gREen";
            Assert.AreEqual("Isabella Green", customer.ChangeName(customer.Name));
        }


        [TestMethod]
        public void ShouldSeparateEachPairOfNumbers()
        {
            customer.Phone = 22340942;
            Assert.AreEqual("22 34 09 42", customer.SplitPhoneNumber(customer.Phone));
        } 
         
    }

}


