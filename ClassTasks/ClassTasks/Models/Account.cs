using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTasks.Models
{
    internal class Account
    {
        

        public void Login(string username, string password)
        {


            if (username == "cavid123" && password == "Cavid1993")
            {
                Console.WriteLine("Login successful");
            }
            else
            {
                Console.WriteLine("email or password is incorrect");
            }


        }
    }
}
