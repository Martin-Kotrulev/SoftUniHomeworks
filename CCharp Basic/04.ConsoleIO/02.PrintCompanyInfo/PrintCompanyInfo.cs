using System;
//Problem 2.	Print Company Information
//A company has name, address, phone number, fax number, 
//web site and manager. The manager has first name, last name, 
//age and a phone number. Write a program that reads the 
//information about a company and its manager and prints it back on the console.

class PrintCompanyInfo
{
    public class Company
    {
        public string[] info = {
                                   "Company Name: ", 
                                   "Company Adress: ", 
                                   "Phone number: ", 
                                   "Fax Number: ",
                                   "Web Site: "
                               };
    }

    public class Manager
    {
        public string[] info = {
                                   "Manager first name: ",
                                   "Manager last name: ", 
                                   "Manager Age:" , 
                                   "Manager Phone: "
                               };
    }

    static void SetInfo(string[] info)
    {
        for (int i = 0; i < info.Length; i++)
        {
            Console.Write(info[i]);
            info[i] = Console.ReadLine();
        }
    }

    static void PrintInfo(string[] info)
    {
        foreach (var item in info)
        {
            Console.WriteLine(item);
        }
    }

    static void Main()
    {
        Company myCompany = new Company();
        Manager myManager = new Manager();

        SetInfo(myCompany.info);
        SetInfo(myManager.info);

        Console.WriteLine();

        PrintInfo(myCompany.info);
        PrintInfo(myManager.info);
    }
}