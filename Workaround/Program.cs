using Business.Concrete;
using Entities.Concrete;

namespace Workaround;

internal class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person();
        person1.FirstName = "";
        person1.LastName = "";
        person1.NationalIdentity = 123;
        person1.DateOfBirthYear = 123;


        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);
    }
}
