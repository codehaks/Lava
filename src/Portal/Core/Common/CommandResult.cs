using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Portal.Core.Common
{
    public abstract class CommandResult
    {
        public bool Succeeded { get; }        
    }
}
