using System;

namespace BankProject
{
    class Program
    {
        static void Main(string[] args)
        {

            BankBalance familyAccount = new BankBalance("Családi számla", 20000, 5000);
            familyAccount.Type = "Családi közös számla";
            BankBalance maryAccount = new BankBalance("Mária magán számlája", 30000, 5000);
            BankBalance peterAccount = new BankBalance("Péter magán számlája", 10000, 5000);

            FamilyMember mary = new FamilyMember("Pénzes Mária", maryAccount, familyAccount);
            FamilyMember peter = new FamilyMember("Pénzes Péter", peterAccount, familyAccount);

            Console.WriteLine(mary);
            Console.WriteLine(peter);

            mary.TransferMoney("Családi számla", "Mária magán számlája", 3000);
            Console.WriteLine(mary);

            BankBalance newPeterAccount = new BankBalance("Péter új magánszámlája", 300000, 10000);
            peter.OwnAccount = newPeterAccount;
            Console.WriteLine(peter);

            peter.Name = "Pénzes Péter György";
            Console.WriteLine(peter);


        }
    }
}
