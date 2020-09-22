using Microsoft.EntityFrameworkCore;
using SPM.DTO;

namespace SPM.DataContext
{
    public class SPMDbContext : DbContext
    {
        public SPMDbContext(DbContextOptions<SPMDbContext> options) : base(options) { }
        public DbSet<BookDTO> Book { get; set; }
        public DbSet<CourseDTO> Course { get; set; }
        public DbSet<CourseFacultyMappingDTO> CourseFacultyMapping { get; set; }
        public DbSet<DocumentDTO> Document { get; set; }
        public DbSet<FacultyDTO> Faculty { get; set; }
        public DbSet<FacultySpecializedMappingDTO> FacultySpecializedMapping { get; set; }
        public DbSet<RoleDTO> Role { get; set; }
        public DbSet<SpecializedDTO> Specialized { get; set; }
        public DbSet<SpecializedSubjectMappingDTO> SpecializedSubjectMapping { get; set; }
        public DbSet<SubjectDTO> Subject { get; set; }
        public DbSet<SubjectBookMappingDTO> SubjectBookMapping { get; set; }
        public DbSet<SubjectDocumentMappingDTO> SubjectDocumentMapping { get; set; }
        public DbSet<SystemMasterDataDTO> SystemMasterData { get; set; }
        public DbSet<UserDTO> User { get; set; }
        public DbSet<UserAddressDTO> UserAddress { get; set; }
        public DbSet<UserRoleDTO> UserRole { get; set; }
        public DbSet<UserSpecializedMappingDTO> UserSpecializedMapping { get; set; }
    }
}