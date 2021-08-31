using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Application.Common
{
    public interface ILoggedInUserService
    {
        public string UserId { get; }
    }
}
