﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _V_Semestr.Configuration
{
    public class SmtpSettings
    {
       public string From { get; set; } 
       public string Port { get; set; } 
       public string Server { get; set; } 
       public string Username { get; set; } 
       public string Password { get; set; } 
    }
}
