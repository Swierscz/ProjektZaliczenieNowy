using ProjektZaliczenie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZaliczenie.Controllers.CustomTaskControllers.InputValidators
{
    public class ValidatorProvider
    {

        private static List<ICustomTaskInputValidator> CustomTaskValidators
        {
            get
            {
                List<ICustomTaskInputValidator> validatorList = new List<ICustomTaskInputValidator>
            {
                new ValidatorIsNameNull(),
                new ValidatorIsStartTimeInFuture()
            };
                return validatorList;
            }
        }

        public static TaskValidationMessage GetValidationMessageIfInvalidInputProvided(CustomTask customTask)
        {
            return CustomTaskValidators
             .Select(message => message.Validate(customTask))
             .FirstOrDefault(validationMessage => validationMessage.IsValid == false);
        }


    }
}
