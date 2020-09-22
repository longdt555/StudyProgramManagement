using Lib.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProgramManagement.IService
{
    public interface ICourseService
    {
        IEnumerable<UserAccountRegistration> GetAllCourses();
        UserAccountRegistration GetById(int id);
        UserAccountRegistration Create(UserAccountRegistration user);
        void Update(UserAccountRegistration user, string password = null);
        void Delete(int id);
        void DeleteMany(List<string> ids);
        int GetUserCount();
    }
}
