using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjektZaliczenie.Models;

namespace ProjektZaliczenie.Controllers.CustomTaskControllers.InputValidators
{
    public class ValidatorIsNameNull : ICustomTaskInputValidator
    {
        public TaskValidationMessage Validate(CustomTask customTask)
        {
            if (customTask.Name == null)
                return new TaskValidationMessage(false, "Task name cannot be null");
            else
                return new TaskValidationMessage(true);
        }
    }
}
