﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA.Fourm.ConoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("User Name:");
            string userName = Console.ReadLine();
            Console.Write("Password:");
            string password = string.Empty;

            password = ReadPassword(password);
            bool isValid = Authenticate(userName, password);

            if (isValid)
            {
                //For Admin User 
                Console.WriteLine("---Menu---");
                Console.WriteLine("---Manage User---");
                Console.WriteLine("---Change Password---");
            }

            //Console.WriteLine("Hello world!");
            Console.ReadLine();
        }

        static bool Authenticate(string userName, string password)
        {
            bool isValid = true;

            if ((userName == "admin") && (password == "password"))
            {
                Console.WriteLine("Welcome " + userName);
            }
            else if ((userName == "user") && (password == "password"))
            {
                Console.WriteLine("welcome " + userName);
            }
            else
            {
                Console.WriteLine("Invalid Login");
                isValid = false;
            }

            return isValid;
        }

        private static string ReadPassword(string password)
        {
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    password += info.KeyChar;
                }
                info = Console.ReadKey(true);
            }
            return password;
        }
    }
}
