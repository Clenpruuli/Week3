using System;

namespace LoginFormRefactornal
{
    class Program
    {
        static void Main(string[] args)
        {
            string Login,Password;
            Console.WriteLine("Logn: ");
            Login = Console.ReadLine();
            Console.WriteLine("Password ");
            Password = Console.ReadLine();

            if(Login == "admin" && Password == "pass1234")
            {
                Console.WriteLine("Welcome,Admin!");
            }
            else
            {
                Console.WriteLine("Login failed.Try again.");
            }


        }
    }
}
