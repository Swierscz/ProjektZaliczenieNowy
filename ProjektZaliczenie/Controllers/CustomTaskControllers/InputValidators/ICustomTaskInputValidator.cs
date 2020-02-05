using ProjektZaliczenie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZaliczenie.Controllers.CustomTaskControllers.InputValidators
{
    public interface ICustomTaskInputValidator
    {
        TaskValidationMessage validate(CustomTask customTask);
    }
}
