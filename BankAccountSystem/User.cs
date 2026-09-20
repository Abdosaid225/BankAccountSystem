using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{
    internal class User
    {
        public string name;
        public int id;
        private int Password;
        bool isLoggedIn = false;

        // Constructor
        public User(int userId, string userName, int userPassword)
        {
            this.id = userId;
            this.name = userName;
            this.Password = userPassword;

            Console.WriteLine("Enter your password:");
            int enteredPassword = int.Parse(Console.ReadLine());

            if (enteredPassword == Password)
            {
                isLoggedIn = true;
                Console.WriteLine($"User {name} logged in successfully.");
            }
            else
            {
                isLoggedIn = false;
                Console.WriteLine($"Incorrect password for user {name}. Login failed.");
            }

            if (isLoggedIn)
            {

                Console.WriteLine($"User created: ID={id}, Name={name}");

                if (isLoggedIn)
                {

                    Console.WriteLine($"User {name} is logged in.");

                }
                else
                {
                    Console.WriteLine($"User {name} is not logged in.");
                }
            }

            




        }



    }
}
