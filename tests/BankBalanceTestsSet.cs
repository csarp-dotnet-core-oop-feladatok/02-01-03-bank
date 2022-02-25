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
    public class BankBalanceTestsSet
    {
        [TestMethod()]
        public void TestBankBallance()
        {
            // Konstruktor
            BankBalance familyAccount = new BankBalance("Családi számla", 20000, 5000);
            double expectedlAmount = 20000;
            double actualAmount = familyAccount.Amount;
            Assert.AreEqual(expectedlAmount, actualAmount, "A BankBalanc osztály konstruktora nem tárolja el a pénzösszeget");


            familyAccount = new BankBalance("Családi számla", 1000, 5000);
            expectedlAmount = 0;
            actualAmount = familyAccount.Amount;
            Assert.AreEqual(expectedlAmount, actualAmount, "A BankBalanc osztály konstruktora az összeghatárnál kevesebb összegel is létrejön.");


            // Típus 
            familyAccount = new BankBalance("Családi számla", 20000, 5000);
            string expectedType = "Családi számla";
            string actualType = familyAccount.Type;
            Assert.AreEqual(expectedType, actualType, "A BankBalanc osztály a számla típusát nem menti el");

            familyAccount = new BankBalance("Családi számla", 20000, 5000);
            familyAccount.Type = "Más számla";
            expectedType = "Más számla";
            actualType = familyAccount.Type;
            Assert.AreEqual(expectedType, actualType, "A BankBalanc osztály a számla típusát nem menti el");

            // Pénzmozgás
            familyAccount = new BankBalance("Családi számla", 20000, 5000);
            familyAccount.Deposit(3000);
            expectedlAmount = 23000;
            actualAmount = familyAccount.Amount;
            Assert.AreEqual(expectedType, actualType, "A BankBalance nem növeli a számlát a megadott összegel.");

            familyAccount = new BankBalance("Családi számla", 20000, 5000);
            familyAccount.Withdraw(3000);
            expectedlAmount = 23000;
            actualAmount = familyAccount.Amount;
            Assert.AreEqual(expectedType, actualType, "A BankBalance nem növeli a számlát a megadott összegel.");

            //ToString
            familyAccount = new BankBalance("Családi számla", 20000, 5000);
            bool actualHaveAmount = familyAccount.ToString().Contains(familyAccount.Amount.ToString());
            Assert.IsTrue(actualHaveAmount, "A Bank osztály ToString metódusa nem jeleníti meg az összeget.");


        }
    }
}