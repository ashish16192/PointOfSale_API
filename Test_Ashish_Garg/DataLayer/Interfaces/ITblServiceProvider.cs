﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Ashish_Garg.Models;

namespace Test_Ashish_Garg.DataLayer.Interfaces
{
    internal interface ITblServiceProvider
    {
        ServicesResponse GetAllServiceProvider(string serviceName="Cleaning");
       
        
    }
}
