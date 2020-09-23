using Lib.Common;
using SPM.DataContext;
using SPM.Helpers;
using SPM.IService;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProgramManagement.Services
{
    public class UserService : IUserService
    {
        private SPMDbContext _context;
        public UserService(SPMDbContext context)
        {
            context = _context;
        }
        public void ChangePassword(int userId, string password, string newPassword)
        {
            var user = _context.User.Include(x => x.Id).SingleOrDefault(x => x.Id == userId);
            if (user == null)
                throw new AppException("User not found");

            //if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
            //    throw new AppException("Wrong Password");

            //byte[] passwordHash, passwordSalt;
            //CreatePasswordHash(newPassword, out passwordHash, out passwordSalt);

            //user.PasswordHash = passwordHash;
            //user.PasswordSalt = passwordSalt;
            _context.SaveChanges();
        }
        private static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");
            if (storedHash.Length != 64) throw new ArgumentException("Invalid length of password hash (64 bytes expected).", "passwordHash");
            if (storedSalt.Length != 128) throw new ArgumentException("Invalid length of password salt (128 bytes expected).", "passwordHash");

            using (var hmac = new System.Security.Cryptography.HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i]) return false;
                }
            }

            return true;
        }
        public void ChangePassword(int id, string newpass)
        {
            var user = _context.User.SingleOrDefault(x => x.Id == id);
            if (user == null)
                throw new AppException("User not found");

            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(newpass, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            _context.SaveChanges();
        }
        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public void ConfirmEmail(int userProfileId)
        {
            throw new NotImplementedException();
        }

        public UserAccountRegistration Create(UserAccountRegistration user, string password)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteMany(List<string> ids)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserAccountRegistration> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserAccountRegistration GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public UserAccountRegistration GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int GetUserCount()
        {
            throw new NotImplementedException();
        }

        public void Update(UserAccountRegistration user, string password = null)
        {
            throw new NotImplementedException();
        }
    }
}
