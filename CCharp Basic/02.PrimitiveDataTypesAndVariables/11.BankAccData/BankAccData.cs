using System;
//Problem 11.	Bank Account Data
//A bank account has a holder name (first name, middle name and last name), 
//available amount of money (balance), bank name, IBAN, 3 credit card 
//numbers associated with the account. Declare the variables needed to 
//keep the information for a single bank account using 
//the appropriate data types and descriptive names.

class BankAccData
{
    public string   bankName;
    public string   IBAN;
    public long     fCreditCard;
    public long     sCreditCard;
    public long     tCreditCard;
    public string   firstName;
    public string   secondName;
    public string   lastName;

    static void Main()
    {
        BankAccData myAccount = new BankAccData();
        myAccount.bankName = "UnrealBank";
        myAccount.IBAN = "BS91 UBNK 9770 10F3 9209 00";
        myAccount.firstName = "Sokol";
        myAccount.secondName = "Slaveev";
        myAccount.lastName = "Yastrebov";
        myAccount.fCreditCard = 998712456781234890;
        myAccount.sCreditCard = 876512345678432156;
        myAccount.tCreditCard = 345612345432143256;

        Console.WriteLine("Name: {0}, {1}, {2}", myAccount.firstName,
            myAccount.secondName, myAccount.lastName);
        Console.WriteLine("Bank name: {0}\nBank IBAN: {1}",
            myAccount.bankName, myAccount.IBAN);
        Console.WriteLine("Credit cards:\n{0}\n{1}\n{2}",
            myAccount.fCreditCard, myAccount.sCreditCard, myAccount.tCreditCard);
    }
}