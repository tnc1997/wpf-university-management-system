using System.Data.Entity;
using System.Linq;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public class EnrolmentService : ServiceBase<Enrolment>, IEnrolmentService
    {
        protected override DbSet<Enrolment> GetDbSet(ApplicationDbContext context)
        {
            return context.Enrolments;
        }

        protected override IQueryable<Enrolment> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context).Include(enrolment => enrolment.User).Include(enrolment => enrolment.Run);
        }
    }
}