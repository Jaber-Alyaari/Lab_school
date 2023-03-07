namespace Lab_school.repositories
{
    public interface IRepository<T> where T:class
    {
        T add(T d);
        T edit(int id);
        List<T> getall();

    }
}
