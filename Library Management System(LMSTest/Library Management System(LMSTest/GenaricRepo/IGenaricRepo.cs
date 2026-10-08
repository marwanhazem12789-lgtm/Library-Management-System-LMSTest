namespace Library_Management_System_LMSTest.GenaricRepo
{
    public interface IGenaricRepo<T> where T : class
    {
        List<T> GetAll();
        T GetById (int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
