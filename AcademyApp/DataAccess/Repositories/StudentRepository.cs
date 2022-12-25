using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        public bool Create(Student entity)
        {
            try
            {
                AppDbContext.Students.Add(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Student entity)
        {
            return AppDbContext.Students.Remove(entity);
        }

        public Student Get(Predicate<Student> filter = null)
        {
            return filter == null ? AppDbContext.Students[0] : AppDbContext.Students.Find(filter);
        }

        public List<Student> GetAll(Predicate<Student> filter = null)
        {
            return filter == null ? AppDbContext.Students : AppDbContext.Students.FindAll(filter);
        }

        public bool Update(Student entity)
        {

            try
            {
                Student existStudent = Get(student => student.Id == entity.Id);
                if (existStudent != null)
                {
                    existStudent = entity;
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
