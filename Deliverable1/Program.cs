﻿using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please create a password containing a mmin of 7 chracters, maximun of 12 chracters, one upper and lower case letter and one special character");



            string password;

            password = Console.ReadLine();

            
            

            if (password.Length < 7)
            {
                Console.WriteLine("error");
            }

            if (password.Length > 12)
            {
                Console.WriteLine("error");
            }

            if (!password.Contains("!"))
            {
                Console.WriteLine("error");
            }

            //Need to fix my for each iteration

            foreach(char c in password)
            {
                bool isUp = false;
                bool isLow = false;

               if(password(c).IsUpper())
                {
                    isUp = true;
                }

               if(password(c).IsUpper())
                {
                    isLow = true;
                }

            }




            if (password.Contains("!") && password.Length >= 7 && password.Length <= 12 && isUp == true && isLow == true)
            {
                Console.WriteLine("Password Valid and accepted");
            }



        }
    }
}
