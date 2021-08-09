using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LinqAddressBook
{
    public class AddresBookManager
    {
        DataTable dataTable;
        public  void createDataTable()
        {
            //creating datatable 
             dataTable = new DataTable();
            //Adding columns
            dataTable.Columns.Add("firstName", typeof(string));
            dataTable.Columns.Add("lastName", typeof(string));
            dataTable.Columns.Add("address", typeof(string));
            dataTable.Columns.Add("city", typeof(string));
            dataTable.Columns.Add("state", typeof(string));
            dataTable.Columns.Add("phoneNumber", typeof(double));
            dataTable.Columns.Add("zip", typeof(int));
            dataTable.Columns.Add("email", typeof(string));
            //Addings rows to corresponding fields
            dataTable.Rows.Add(new Object[]
                { "Vivek","G","Manthani","Karimnagar","Telangana",73388,50517,"vivekg11@gmail.com" });
            dataTable.Rows.Add(new Object[]
                {"Pavani","C","Kadapa","Seema","Ap",99514,78654,"pavani11@gmail.com"});
            dataTable.Rows.Add(new Object[]
            {"Aditya","S","Sironcha","Gdcl","Maharastra",9959934,89041,"Aditya7114@gmail.com"});

            //Displaying contacts in the datatable
           // DisplayTbale(dataTable);
        }

        public  void EditData(string name)
        {
            //creating object for AddressBookDataClass
            AddressBookData data = new AddressBookData();
            createDataTable();
            //Finding specific row based on given Name 
            var result = (from person in  dataTable.AsEnumerable() where person.Field<string>("firstName").Equals(name) select person).LastOrDefault();
            if(result != null)
            {
                //Edit the column you want to ......
                result["lastName"] = "Guntuku";
                Console.WriteLine("After Modification....");
                DisplayTbale(dataTable);
            }
            else
            {
                Console.WriteLine("No data Exists with given input..");
            }
        }

        public void DeleteContact(string name)
        {

            //creating object for AddressBookDataClass
            AddressBookData data = new AddressBookData();
            createDataTable();
            //Finding specific row based on given Name 
            var result = (from person in dataTable.AsEnumerable() where person.Field<string>("firstName").Equals(name) select person).LastOrDefault();
            if (result != null)
            {
                //Delete the column you want to ......
                result.Delete();
                Console.WriteLine("After Modification....");
                DisplayTbale(dataTable);
            }
            else
            {
                Console.WriteLine("No data Exists with given input..");
            }
        }
        public static void DisplayTbale(DataTable dataTable)
        {
            Console.WriteLine("Contacts in the table are..... ");
            //Iterating through rows
            foreach(DataRow row in dataTable.Rows)
            {
                foreach(var i in row.ItemArray)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine(".............");
            }
        }
    }
}
