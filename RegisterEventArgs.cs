﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Jaime_Fernandez
{
    public class RegisterEventArgs : EventArgs
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string VerificationLink { get; set; }
    }
}
