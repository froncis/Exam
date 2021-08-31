using Exam.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Exam.Identity
{
    public class ExamIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public ExamIdentityDbContext(DbContextOptions<ExamIdentityDbContext> options) : base(options)
        {

        }
    }
}
