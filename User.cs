using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Jaime_Fernandez
{
    class User
    {
        public delegate void VerifyEmail();

        public event VerifyEmail EmailVerified;

        public void OnEmailSent()
        {
             Console.WriteLine("Do you want to verify your email?: Y/N");
             string var = Console.ReadLine();
             if (var == "Y")
             {
                Console.WriteLine("Verification email sent");
             }
        }
    }
}
