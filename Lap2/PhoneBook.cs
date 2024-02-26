using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2305m.Lap2
{
    internal class PhoneBook:phone
    {
        private List<Tuple<string, string>> phoneList;

        public PhoneBook()
        {
            phoneList = new List<Tuple<string, string>>();
        }

        public override void InsertPhone(string name, string phone)
        {
            var existingEntry = phoneList.FirstOrDefault(entry => entry.Item1 == name);
            if (existingEntry != null)
            {
                if (existingEntry.Item2 != phone)
                {
                    phoneList.Remove(existingEntry);
                    phoneList.Add(new Tuple<string, string>(name, phone));
                    Console.WriteLine($"Updated phone number for {name}");
                }
            }
            else
            {
                phoneList.Add(new Tuple<string, string>(name, phone));
                Console.WriteLine($"Inserted new entry for {name}");
            }
        }

        public override void RemovePhone(string name)
        {
            var entryToRemove = phoneList.FirstOrDefault(entry => entry.Item1 == name);
            if (entryToRemove != null)
            {
                phoneList.Remove(entryToRemove);
                Console.WriteLine($"Removed entry for {name}");
            }
        }

        public override void UpdatePhone(string name, string newPhone)
        {
            var existingEntry = phoneList.FirstOrDefault(entry => entry.Item1 == name);
            if (existingEntry != null)
            {
                phoneList.Remove(existingEntry);
                phoneList.Add(new Tuple<string, string>(name, newPhone));
                Console.WriteLine($"Updated phone number for {name}");
            }
        }

        public override void SearchPhone(string name)
        {
            var entry = phoneList.FirstOrDefault(e => e.Item1 == name);
            if (entry != null)
            {
                Console.WriteLine($"Phone number for {name}: {entry.Item2}");
            }
            else
            {
                Console.WriteLine($"No entry found for {name}");
            }
        }

        public override void Sort()
        {
            phoneList.Sort((x, y) => x.Item1.CompareTo(y.Item1));
            Console.WriteLine("Phone book sorted by name");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();

            phoneBook.InsertPhone("Alice", "123456");
            phoneBook.InsertPhone("Bob", "654321");
            phoneBook.InsertPhone("Charlie", "987654");

            phoneBook.SearchPhone("Alice");
            phoneBook.SearchPhone("Bob");

            phoneBook.UpdatePhone("Bob", "111111");
            phoneBook.SearchPhone("Bob");

            phoneBook.Sort();
        }
    }
}
