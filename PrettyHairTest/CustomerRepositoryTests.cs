using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PrettyHair1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrettyHairTest
{
    [TestClass]
    public class CustomerRepositoryTests
    {
        private CustomerRepository CreateRepositoty()
        {
            return new CustomerRepository();
        }

        [TestMethod]
        public void Create()
        {
            CustomerRepository customerRepositotry = CreateRepositoty();
           // Customer erik = customerRepositotry.CreateCustomer("Erik", "Broks");
           // Assert.AreEqual("Erik", erik.Name);
        }
    }
}
