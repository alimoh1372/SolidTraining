﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Examples
{
    public class EnglishLang : IHello
    {
        public string Say()
        {
            return "Hello";
        }
    }
}
