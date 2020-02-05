using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZaliczenie.Controllers.CustomTaskControllers.InputValidators
{
    public class TaskValidationMessage
    {
        public bool isValid { get; }
        public string message { get; }

        public TaskValidationMessage(bool isValid) {
            this.isValid = isValid;
            this.message = "";
        }

        public TaskValidationMessage(bool isValid, string message) {
            this.isValid = isValid;
            this.message = message;
        }
    }
}
