/*A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
 * Write a program that reads the information about a company and its manager and prints it back on the console.
*/
using System;

class PrintCompanyInformation
{

    struct Company
    {
        public string name;
        public string address;
        public string phoneNumber;
        public int faxNumber;
        public string website;
    };

    struct Manager
    {
        public string firstName; 
        public string lastName;
        public byte age;
        public string phoneNumber;
    };

    static void Main()
    {

        Company myCompany;
        Console.Write("Enter company name:");
        myCompany.name = Console.ReadLine();

        Console.Write("Enter company address:");
        myCompany.address = Console.ReadLine();

        Console.Write("Enter company phone number:");
        myCompany.phoneNumber = Console.ReadLine();

        Console.Write("Enter company fax number:");
        myCompany.faxNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter company website:");
        myCompany.website = Console.ReadLine();

        Manager myCompanyManager;
        Console.Write("Enter manager`s first name:");
        myCompanyManager.firstName = Console.ReadLine();

        Console.Write("Enter manager`s last name:");
        myCompanyManager.lastName = Console.ReadLine();

        Console.Write("Enter manager`s age:");
        myCompanyManager.age = byte.Parse(Console.ReadLine());

        Console.Write("Enter manager`s phone number:");
        myCompanyManager.phoneNumber = Console.ReadLine();

        Console.WriteLine(myCompany.name);
        Console.WriteLine("Address:"+myCompany.address);
        Console.WriteLine("Tel.:"+myCompany.phoneNumber);
        Console.WriteLine("Fax:"+myCompany.faxNumber);
        Console.WriteLine("Web-site:"+myCompany.website);
        Console.WriteLine("Mnager: {0} {1} (age:{2}, tel. {3})", myCompanyManager.firstName, myCompanyManager.lastName, myCompanyManager.age, myCompanyManager.phoneNumber);

    }
}

