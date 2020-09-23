using Lib.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPM.IService
{
    public interface IUserService
    {
        IEnumerable<UserAccountRegistration> GetAll();
        UserAccountRegistration GetById(int id);
        UserAccountRegistration GetByEmail(string email);
        UserAccountRegistration Create(UserAccountRegistration user, string password);
        void Update(UserAccountRegistration user, string password = null);
        void Delete(int id);
        void DeleteMany(List<string> ids);
        void ChangePassword(int userId, string password, string newPassword);
        void ChangePassword(int id, string newpass);
        int GetUserCount();
        void ConfirmEmail(int userProfileId);
    }
}
