using ProjektZaliczenie.Controllers.CustomTaskControllers.InputValidators;
using ProjektZaliczenie.Models;
using System;
using Xunit;

namespace ProjektZaliczenieTests
{
    public class ValidatorTest
    {

        [Fact]
        public void GetValidationMessageIfInvalidInputProvided_CorrectInput_ReturnsNull() {
            CustomTask customTask = new CustomTask();
            customTask.Id = 1;
            customTask.Name = "Name";
            customTask.Description = "Some description";
            customTask.CreationTime = Convert.ToDateTime("2012-12-10T00:00:00");
            customTask.FinishedTime = Convert.ToDateTime("2014-12-10T00:00:00");

            TaskValidationMessage validationMessage = ValidatorProvider.GetValidationMessageIfInvalidInputProvided(customTask);
            Assert.Null(validationMessage);
        }

        [Fact]
        public void GetValidationMessageInInvalidInputProvider_NullName_ReturnsNotNull()
        {
            CustomTask customTask = new CustomTask();
            customTask.Id = 1;
            customTask.Description = "Description";

            TaskValidationMessage validationMessageBeforeNameSet = ValidatorProvider.GetValidationMessageIfInvalidInputProvided(customTask);
            Assert.NotNull(validationMessageBeforeNameSet);
        }

        [Fact]
        public void GetValidationMessageIfInvalidInputProvided_StartTimeInFuture_ReturnsNull() {
            CustomTask customTask = new CustomTask();
            customTask.Id = 1;
            customTask.CreationTime = Convert.ToDateTime("2040-12-10T00:00:00");

            TaskValidationMessage validationMessageBeforeNameSet = ValidatorProvider.GetValidationMessageIfInvalidInputProvided(customTask);
            Assert.NotNull(validationMessageBeforeNameSet);
        }

    }
}
