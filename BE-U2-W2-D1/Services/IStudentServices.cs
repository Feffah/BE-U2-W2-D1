using BE_U2_W2_D1.Models.Entities;

namespace BE_U2_W2_D1.Services
{
    public interface IStudentServices
    {
        Task<List<Student>> GetAllStudents();
        Task<Student> GetStudentByIdAsync(Guid id);
        Task<bool> CreateAsync(Student student);
        Task<bool> UpdateAsync(Student student);
        Task<bool> DeleteAsync(Student student);
    }
}