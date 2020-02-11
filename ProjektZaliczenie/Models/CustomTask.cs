using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZaliczenie.Models
{
    public class CustomTask : IValidatableObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public DateTime CreationTime { get; set; }
        public DateTime FinishedTime { get; set; }
        [Required]
        [StringLength(20)]
        public string Description { get; set; }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (CreationTime > FinishedTime)
            {
                yield return new ValidationResult(
                    "CreationTime cannot be lower than FinishedTime"
                    );
            }
        }
    }
}
