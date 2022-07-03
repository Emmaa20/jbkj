using System;
using System.Collections.Generic;

namespace Writing_The_Login_And_System_In_The_Terminal
{
    internal class Program
    {
        public static List<Person> persons { get; set; } = new List<Person>();
        static void Main(string[] args)
        {
            Console.WriteLine("Our available commands :");
            Console.WriteLine("/register");
            Console.WriteLine("/login");
            Console.WriteLine("/database");
            Console.WriteLine("/exit");

            while (true)
            {
                Console.WriteLine();
                Console.Write("Enter command : ");
                string command = Console.ReadLine();

                if (command == "/register")
                {
                    Console.Write("Please add person's name :");
                    string name = Console.ReadLine();
                    NewRegisterName(name);

                    Console.Write("Please add person's surname :");
                    string lastName = Console.ReadLine();
                    NewRegisterLastName(lastName);

                    Console.Write("Please add person's Email adress :");
                    string eMail = Console.ReadLine();
                    NewRegisterEmail(eMail);

                    Console.Write("Please add person's password:");
                    string password = Console.ReadLine();


                    Console.Write("Please add person's  tekrar password:");
                    string samePassword = Console.ReadLine();
                    NewRegisterSamePassword(password, samePassword);

                    Person person = AddNewPerson(name, lastName, eMail, password, samePassword);
                    persons.Add(person);
                    Console.WriteLine(person.GetFullName() + " - You successfully registered, now you can login with your new account!");

                }
                else if (command == "/login")
                {
                    Console.Write("Please add person's Email adress :");
                    string eMail = Console.ReadLine();
                    NewRegisterEmail(eMail);

                    Console.Write("Please add person's password:");
                    string password = Console.ReadLine();

                    Console.WriteLine("Welcome to your account ");

                }
                else if (command == "/database")
                {
                    Console.WriteLine("Persons in database : ");
                    ShowPerson();

                }
                else if (command == "/exit")
                {
                    Console.WriteLine("Bye-bye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Command not found, please enter command from list!");
                    Console.WriteLine();
                }
            }

            static void ShowPerson()
            {
                foreach (Person person in persons)
                {
                    Console.WriteLine(person.GetInfo());
                }
            }

            static void NewRegisterName(string name)
            {

                if (name.Length <= 30 && name.Length >= 3)
                {
                    Console.WriteLine(" ");

                }
                else
                {
                    Console.WriteLine("Name length should be min 3 max 30");

                }

            }

            static void NewRegisterLastName(string lastName)
            {
                if (lastName.Length <= 20 && lastName.Length >= 5)
                {
                    Console.WriteLine();

                }
                else
                {

                    Console.WriteLine("Name length should be min 5 max 20");

                }

            }

            static void NewRegisterEmail(string eMail)
            {

                for (int i = 0; i < eMail.Length; i++)
                {
                    if (eMail[i] != '@')
                    {
                        Console.WriteLine("@ must be in the email.");
                        break;


                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }
            static void NewRegisterSamePassword(string password, string samePassword)
            {
                if (password == samePassword)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("password is not the same");

                }

            }

            static Person AddNewPerson(string name, string lastname, string eMail, string password, string samePassword)
            {
                Person person = new Person(name, lastname, eMail, password, samePassword);
                persons.Add(person);
                return person;

            }

        }

        private static void GetInfo()
        {
            throw new NotImplementedException();
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }

        public string Password { get; set; }
        public string SamePassword { get; set; }

        public Person(string name, string lastName, string eMail, string password, string samePassword)
        {

            Name = name;
            LastName = lastName;
            EMail = eMail;
            Password = password;
            SamePassword = samePassword;
        }

        public string GetFullName()
        {
            return Name + " " + LastName;
        }

        public string GetInfo()
        {
            return Name + " " + LastName + " " + EMail /* + " " + Password */ ;
        }
    }
}