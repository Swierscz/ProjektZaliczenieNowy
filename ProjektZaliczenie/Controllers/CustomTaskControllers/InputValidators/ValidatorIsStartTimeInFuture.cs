using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjektZaliczenie.Models;

namespace ProjektZaliczenie.Controllers.CustomTaskControllers.InputValidators
{
    public class ValidatorIsStartTimeInFuture : ICustomTaskInputValidator
    {
        public TaskValidationMessage validate(CustomTask customTask)
        {
            if (customTask.CreationTime > DateTime.Now)
                return new TaskValidationMessage(false, "Task creation time cannot be later than now");
            else
                return new TaskValidationMessage(true);
        }
    }
}
