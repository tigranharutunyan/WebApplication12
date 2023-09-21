using WebApplication12.Data.Entity;

namespace WebApplication12.Data.Repository.Interfaces
{
    public interface IAnimalsReposiroy
    {
        void Add(Animals animal);
        List<Animals> GetAll();
        Animals Get(int id);
        void Delete(Animals animal);
        void SaveChanges();
    }
}
