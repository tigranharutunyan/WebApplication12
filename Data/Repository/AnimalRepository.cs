using System.Data;
using WebApplication12.Data.Entity;
using WebApplication12.Data.Repository.Interfaces;

namespace WebApplication12.Data.Repository
{
    public class AnimalRepository : IAnimalsReposiroy
    {
        public void Add(Animals animal)
        {
          throw new Exception();    
        }

        public void Delete(Animals animal)
        {
            throw new NotImplementedException();
        }

        public Animals Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Animals> GetAll()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
