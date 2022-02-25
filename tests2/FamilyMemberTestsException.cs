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
    public class FamilyMemberTestsException
    {
        [TestMethod()]
        public void FamilyMemberTestsExceptionTest()
        {
            BankBalance familyAccount = new BankBalance("Családi számla", 20000, 5000);
            BankBalance maryAccount = new BankBalance("Mária magán számlája", 30000, 5000);


            FamilyMember mary = new FamilyMember("Pénzes Mária", maryAccount, familyAccount);


            Assert.ThrowsException<ExceptionAmountCanNotNegativeOrZero>(() => mary.TransferMoney("","",0), "Nulla összeget nem lehet mozgatni a számlák között");
            Assert.ThrowsException<ExceptionAmountCanNotNegativeOrZero>(() => mary.TransferMoney("", "", -1000), "Negatív összeget nem lehet mozgatni a számlák között");
                        
            Assert.ThrowsException<ExceptionAccountNameIsWrong>(() => mary.TransferMoney("Családi számla", "más", 1000), "Helytelen számlanév esetén kivételt kell dobni");
            Assert.ThrowsException<ExceptionAccountNameIsWrong>(() => mary.TransferMoney("Mária magán számlája","más", 1000), "Helytelen számlanév esetén kivételt kell dobni");

            Assert.ThrowsException<ExceptionAccountNameIsWrong>(() => mary.TransferMoney("más", "Családi számla", 1000), "Helytelen számlanév esetén kivételt kell dobni");
            Assert.ThrowsException<ExceptionAccountNameIsWrong>(() => mary.TransferMoney("más", "Mária magán számlája", 1000), "Helytelen számlanév esetén kivételt kell dobni");

            BankBalance peterFamilyAccount = new BankBalance("Családi számla", 20000, 5000);
            BankBalance peterOwnAccount = new BankBalance("Péter magán számlája", 10000, 5000);
            FamilyMember peter = new FamilyMember("Pénzes Péter", peterOwnAccount, peterFamilyAccount);

            Assert.ThrowsException<ExceptionTransferIsNotPossible>(() => peter.TransferMoney("Péter magán számlája", "Családi számla", 20000), "Amikor nagyobb összeget akar átrakni a számláról, mint ami ott van kivételt kell dobni");
            double expectedPeterFamilyAmount = 20000;
            double actualPeterFamilyAmount = peterFamilyAccount.Amount;
            Assert.AreEqual(expectedPeterFamilyAmount, actualPeterFamilyAmount, "Lehetetlen transzfer esetén a számlán lévő összeg nem váltohat!");
            expectedPeterFamilyAmount = 20000;
            actualPeterFamilyAmount = peterFamilyAccount.Amount;
           Assert.ThrowsException<ExceptionTransferIsNotPossible>(() => peter.TransferMoney("Családi számla", "Péter magán számlája", 30000), "Amikor nagyobb összeget akar átrakni a számláról, mint ami ott van kivételt kell dobni");

        }
    }
}