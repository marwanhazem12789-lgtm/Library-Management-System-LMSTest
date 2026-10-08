using Library_Management_System_LMSTest.Models;

namespace Library_Management_System_LMSTest.GenaricRepo
{
    public class GenaricRepos<T> : IGenaricRepo<T> where T : class
    {
        private readonly Context _context;
        public GenaricRepos(Context _context)
        {
            this._context = _context;
        }


        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
