
using BE_U2_W2_D1.Models.Entities;
using BE_U2_W2_D1.Services;
using Microsoft.EntityFrameworkCore;


namespace BE_U2_W2_D1.Services
{
    public class StudentServices : IStudentServices
    {
        private readonly StudentDbContext _context;

        public StudentServices(StudentDbContext context)
        {
            _context = context;
        }


        //GET ALL STUDENTS
        public async Task<List<Student>> GetAllStudents()
        {
            return await _context.Students.ToListAsync();
        }

        //GET BY ID
        public async Task<Student> GetStudentByIdAsync(Guid id)
        {
            return await _context.Students.FindAsync(id);
        }

        //CREATE STUDENT
        public async Task<bool> CreateAsync(Student student)
        {
            await _context.Students.AddAsync(student);
            return await _context.SaveChangesAsync() > 0;

        }
        //MODIFY
        public async Task<bool> UpdateAsync(Student student)
        {
            _context.Students.Update(student);
            return await _context.SaveChangesAsync() > 0;
        }

        // DELETE
        public async Task<bool> DeleteAsync(Student student)
        {
            _context.Students.Remove(student);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}