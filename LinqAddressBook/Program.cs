﻿using System;

namespace LinqAddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To AddressBook Table");
           // AddresBookManager.createDataTable();
            AddresBookManager manager = new AddresBookManager();
            manager.EditData("Vivek");
        }
    }
}
