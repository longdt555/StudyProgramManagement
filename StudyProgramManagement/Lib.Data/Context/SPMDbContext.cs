using Lib.Data.DTO;
using Microsoft.EntityFrameworkCore;

namespace Lib.Data.Context
{
    public class SPMDbContext : DbContext
    {
        public SPMDbContext(DbContextOptions<SPMDbContext> options) : base(options)
        {
        }
        public DbSet<BookDTO> Book { get; set; }
        public DbSet<CourseDTO> Course { get; set; }
        public DbSet<CourseFacultyMappingDTO> Course_Faculty_Mapping { get; set; }
        public DbSet<DocumentDTO> Document { get; set; }
        public DbSet<FacultyDTO> Faculty { get; set; }
        public DbSet<FacultySpecializedMappingDTO> Faculty_Specialized_Mapping { get; set; }
        public DbSet<RoleDTO> Role { get; set; }
        public DbSet<SpecializedDTO> Specialized { get; set; }
        public DbSet<SpecializedSubjectMappingDTO> Specialized_Subject_Mapping { get; set; }
        public DbSet<SubjectDTO> Subject { get; set; }
        public DbSet<SubjectBookMappingDTO> Subject_Book_Mapping { get; set; }
        public DbSet<SubjectDocumentMappingDTO> Subject_Document_Mapping { get; set; }
        public DbSet<SystemMasterDataDTO> System_MasterData { get; set; }
        public DbSet<UserDTO> User { get; set; }
        public DbSet<UserAddressDTO> User_Address { get; set; }
        public DbSet<UserRoleDTO> User_Role { get; set; }
        public DbSet<UserSpecializedMappingDTO> User_Specialized_Mapping { get; set; }
    }
}
