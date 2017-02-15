using ProjectCheckpoint.Models.Interfaces;
using System.Data.Entity;
using System;
using System.Linq;

namespace ProjectCheckpoint.Models.Repository
{
    public class UserRepository : IRepository<User>, ISearchRepository<User>
    {
        private DataContext dataContext;

        public UserRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void Create(User entity)
        {
            dataContext.User.Add(entity);
        }

        public void Delete(User entity)
        {
            dataContext.User.Remove(entity);
        }
        
        public void Update(User entity)
        {
            dataContext.Entry(entity).State = EntityState.Modified;
        }
        
        public User GetById(int id)
        {
            return dataContext.User.Where(user => user.UserId == id).First();
        }

        public bool IsExits(string login, string password)
        {            
            return dataContext.User.Any(user => user.Login == login && user.Password == password);         
        }
    }
}
