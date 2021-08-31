using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Application.Common.Exceptions
{
    public class ValidationException : ApplicationException
    {
        public List<string> ValidationErros { get; set; }
        public ValidationException(ValidationResult validationResult)
        {
            ValidationErros = new List<string>();

            foreach (var validationError in validationResult.Errors)
            {
                ValidationErros.Add(validationError.ErrorMessage);
            }
        }
    }
}
