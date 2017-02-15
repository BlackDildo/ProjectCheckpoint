
namespace ProjectCheckpoint.Models.Interfaces
{
    public interface ISearchRepository<T> where T : class
    {
        T GetById(int id);
    }
}
