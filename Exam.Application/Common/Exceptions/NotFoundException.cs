using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Application.Common.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string name , object key) : base($"{name} ({key}) is not found")
        {
        }
    }
}
