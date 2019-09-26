﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Core.Common
{
    public class InvalidCommandException : Exception
    {
        public string Details { get; }
        public InvalidCommandException(string message, string details) : base(message)
        {
            this.Details = details;
        }
    }
}
