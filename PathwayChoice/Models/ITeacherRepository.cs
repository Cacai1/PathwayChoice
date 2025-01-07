using PathwayChoice.Models;

namespace PathwayChoice.Models
{
    public interface ITeacherRepository
    {

        IQueryable<Teacher> Entertainers { get; }

        void Add<T>(T entity) where T : class;
        void Remove<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void SaveChanges();

    }
}
