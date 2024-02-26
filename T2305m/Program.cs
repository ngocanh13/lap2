using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2305m.Lap2;

namespace T2305m
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook(); 

            phoneBook.InsertPhone("ngocanh", "123456");
            phoneBook.InsertPhone("anh", "654321");
            phoneBook.InsertPhone("ngoc", "987654");

            phoneBook.SearchPhone("ngocanh");
            phoneBook.SearchPhone("anh");

            phoneBook.UpdatePhone("anh", "111111");
            phoneBook.SearchPhone("anh"); 

            
            phoneBook.Sort();
        }
    }
}
