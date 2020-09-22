using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProgramManagement.IService
{
    public interface IUserService
    {
        IEnumerable<UserAccountRegistration> GetAll();
        UserAccountRegistration GetById(Guid id);
        UserAccountRegistration GetByEmail(string email);
        UserAccountRegistration Create(UserAccountRegistration user, string password);
        void Update(UserAccountRegistration user, string password = null);
        void Delete(Guid id);
        void DeleteMany(List<string> ids);
        void ChangePassword(Guid userId, string password, string newPassword);
        void ChangePassword(Guid id, string newpass);

        IEnumerable<UserAccountStatus> GetUserAccountStatuses();
        IEnumerable<UserAccountType> GetUserAccountTypes();
        int GetMemberCount();

        void CreatePhoneOtpRecord(string phoneNumber, string otp);

        MemberSearchResult Search(MemberSearchParameter param);

        void ConfirmEmail(Guid userProfileId);
    }
}
