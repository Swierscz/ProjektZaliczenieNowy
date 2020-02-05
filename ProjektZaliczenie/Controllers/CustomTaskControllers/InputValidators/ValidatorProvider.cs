using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZaliczenie.Controllers.CustomTaskControllers.InputValidators
{
    public class ValidatorProvider
    {
        public static List<ICustomTaskInputValidator> GetCustomTaskValidators() {
            List<ICustomTaskInputValidator> validatorList = new List<ICustomTaskInputValidator>();
            validatorList.Add(new ValidatorIsNameNull());
            validatorList.Add(new ValidatorIsStartTimeInFuture());
            return validatorList;
        }
    }
}
