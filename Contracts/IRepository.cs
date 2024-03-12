using Entities;

namespace Contracts
{
    public interface IRepository<T> where T : BaseEntity
    {
        public IEnumerable<T> GetAll();

        public T GetById(int id);

        public void Insert(T entity);

        public void Update(T entity);

        public void DeleteById(int id);


    }
}
