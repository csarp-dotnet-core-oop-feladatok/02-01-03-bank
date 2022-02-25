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
    public class FamilyMemberTestsSet
    {
        [TestMethod()]
        public void TestBankBallance()
        {
            // Konstruktor
            BankBalance familyAccount = new BankBalance("Családi számla", 20000, 5000);
            BankBalance maryAccount = new BankBalance("Mária magán számlája", 30000, 5000);            
            // Név
            FamilyMember mary = new FamilyMember("Pénzes Mária", maryAccount, familyAccount);
            string expectedName = "Pénzes Mária";
            string actualName = mary.Name;
            Assert.AreEqual(expectedName, actualName, "A FamilyMember kosntruktor nem tárolja el a nevet!");

            mary.Name = "Pénzes Mária Erzsébet";
            expectedName = "Pénzes Mária Erzsébet";
            actualName = mary.Name;
            Assert.AreEqual(expectedName, actualName, "A FamilyMember nem módosítja a nevet!");

            //Transfer
            mary.TransferMoney("Családi számla", "Mária magán számlája", 1000);
            double expectedFamilyAmount = 19000;
            double actualFamilyAmount = familyAccount.Amount;
            Assert.AreEqual(expectedFamilyAmount, actualFamilyAmount, "Közös->Magán:A pénzmozgás első része sikertelen.");
            double expectedOwnAmount = 31000;
            double actualOwnAmount = maryAccount.Amount;
            Assert.AreEqual(expectedOwnAmount, actualOwnAmount, "Közös->Magán:A pénzmozgás második része sikertelen.");


            mary.TransferMoney("Mária magán számlája", "Családi számla", 5000);
            expectedFamilyAmount = 24000;
            actualFamilyAmount = familyAccount.Amount;
            Assert.AreEqual(expectedFamilyAmount, actualFamilyAmount, "Magán->Közös:A pénzmozgás első része sikertelen.");
            expectedOwnAmount = 26000;
            actualOwnAmount = maryAccount.Amount;
            Assert.AreEqual(expectedOwnAmount, actualOwnAmount, "Magán->Közös:A pénzmozgás második része sikertelen.");

            familyAccount = new BankBalance("Családi számla", 20000, 5000);
            BankBalance peterAccount = new BankBalance("Péter magán számlája", 10000, 5000);
            FamilyMember peter = new FamilyMember("Pénzes Péter", peterAccount, familyAccount);
            
            BankBalance newPeterAccount = new BankBalance("Péter új magánszámlája", 300000, 10000);
            peter.OwnAccount = newPeterAccount;

            double expectedNewPeterAmount = 300000;
            double actualNewPeterAmount = peter.OwnAccount.Amount;
            Assert.AreEqual(expectedNewPeterAmount, actualNewPeterAmount, "A FamilyMember saját számla set metódusa nem működik");

            string expectedNewPeterName = "Péter új magánszámlája";
            string actualNewPeterName = peter.OwnAccount.Type;
            Assert.AreEqual(expectedNewPeterAmount, actualNewPeterAmount, "A FamilyMember saját számla set metódusa nem működik");

            peter.JointAccount = newPeterAccount;
            expectedNewPeterAmount = 300000;
            actualNewPeterAmount = peter.JointAccount.Amount;
            Assert.AreEqual(expectedNewPeterAmount, actualNewPeterAmount, "A FamilyMember közös számla set metódusa nem működik");

            expectedNewPeterName = "Péter új magánszámlája";
            actualNewPeterName = peter.JointAccount.Type;
            Assert.AreEqual(expectedNewPeterAmount, actualNewPeterAmount, "A FamilyMember közös számla set metódusa nem működik");

        }
    }
}