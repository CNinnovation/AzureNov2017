﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreSample.Services
{
    public class GreetingService : IGreetingService
    {
        public string Greet(string name) => $"Hello, {name}";
    }
}
