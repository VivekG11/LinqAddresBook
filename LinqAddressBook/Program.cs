using System;

namespace LinqAddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To AddressBook Table");
           // AddresBookManager.createDataTable();
            AddresBookManager manager = new AddresBookManager();
            // manager.EditData("Vivek");
            //manager.DeleteContact("Kumar");
            // manager.RetrieveBasedOnCityOrState("Seema","Ap");
            // manager.RetrieveAlphabatically("Gdcl");
            manager.RetrieveCount("Aditya");
        }
    }
}
