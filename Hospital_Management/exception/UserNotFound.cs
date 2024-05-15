﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management.exception
{
    internal class UserNotFound : ApplicationException
    {
        public UserNotFound() { }

        public UserNotFound(string message) : base(message) { }
    }
}
