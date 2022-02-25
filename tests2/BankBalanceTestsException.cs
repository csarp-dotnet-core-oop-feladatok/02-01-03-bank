using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using BankProject.Models;

namespace BankProject.Tests
{
    [TestClass()]
    public class BankBalanceTestsException
    {
        [TestMethod()]
        public void BankBalanceTests()
        {
            BankBalance familyAccount = new BankBalance("Családi számla", 20000, 5000);

            Assert.ThrowsException<ExceptionAmountCanNotNegativeOrZero>(() => familyAccount.Deposit(0),"A Deposit metódus nem dob megfelelő kivételt.");
            Assert.ThrowsException<ExceptionAmountCanNotNegativeOrZero>(() => familyAccount.Deposit(-10000), "A Deposit metódus nem dob megfelelő kivételt.");

            Assert.ThrowsException<ExceptionAmountCanNotNegativeOrZero>(() => familyAccount.Withdraw(0), "A Withdraw metódus nem dob megfelelő kivételt.");
            Assert.ThrowsException<ExceptionAmountCanNotNegativeOrZero>(() => familyAccount.Withdraw(-10000), "A Withdraw metódus nem dob megfelelő kivételt.");

            Assert.ThrowsException<ExceptionCanNotTakeMore>(() => familyAccount.Withdraw(100000), "A Withdraw metódus nem dob megfelelő kivételt.");
        }
    }
}