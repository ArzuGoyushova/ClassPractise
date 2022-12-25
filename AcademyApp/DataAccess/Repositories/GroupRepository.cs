using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class GroupRepository : IRepository<Group>
    {
        public bool Create(Group entity)
        {
            try
            {
                AppDbContext.Groups.Add(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Group entity)
        {
            return AppDbContext.Groups.Remove(entity);
        }

        public Group Get(Predicate<Group> filter = null)
        {
            return filter == null ? AppDbContext.Groups[0] : AppDbContext.Groups.Find(filter);
        }

        public List<Group> GetAll(Predicate<Group> filter = null)
        {
            return filter == null ? AppDbContext.Groups : AppDbContext.Groups.FindAll(filter);
        }

        public bool Update(Group entity)
        {
            try
            {
                Group existGroup=Get(group=>group.Id == entity.Id);
                if (existGroup != null)
                {
                    existGroup=entity;
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
