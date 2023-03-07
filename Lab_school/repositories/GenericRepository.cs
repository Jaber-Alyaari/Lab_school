using Lab_school.Models;

namespace Lab_school.repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly SchoolDBContext context;

        public GenericRepository(SchoolDBContext context)
        {
            this.context = context;
        }
        public T add(T entity)
        {
            var res=context.Add(entity);
            var rowcount=context.SaveChanges();
            return res.Entity as T;
        }

      

        public T edit(int id)
        {
            throw new NotImplementedException();
        }
           
        public List <T> getall()
        {
            var res=context.Set<T>().ToList();
            return res; 
        }
    }
}
