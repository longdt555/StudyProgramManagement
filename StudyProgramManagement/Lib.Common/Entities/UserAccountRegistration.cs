using Lib.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Common
{
    public class UserAccountRegistration : BaseEntity
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public bool ChangePasswordRequired { get; set; }
        public Guid? TenantId { get; set; }

        public Guid UserProfileId { get; set; }
        public UserAddress UserAddress { get; set; }
        public int CreateSource { get; set; }
        public bool IsEmailConfirmed { get; set; }
    }
}
