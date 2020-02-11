using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZaliczenie.Controllers.CustomTaskControllers.InputValidators
{
    public class TaskValidationMessage
    {
        public bool IsValid { get; }
        public string Message { get; }

        public TaskValidationMessage(bool isValid)
        {
            this.IsValid = isValid;
            this.Message = "";
        }

        public TaskValidationMessage(bool isValid, string message)
        {
            this.IsValid = isValid;
            this.Message = message;
        }
    }
}
