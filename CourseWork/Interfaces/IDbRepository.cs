using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseWork.Persistance
{
    internal interface IDbRepository
    {
        DbContext Db { get; set; }

        bool TryLoadDb();
        Task SaveChanges();
        Task AddToList<T>(List<T> list, T value);
        Task RemoveFromList<T>(List<T> list, T value);
        Task RemoveFromListById<T>(List<T> list, int id);
        Task AddToDict<T>(Dictionary<string, T> dict, string key, T value);
        Task RemoveFromDict<T>(Dictionary<string, T> dict, string key);
        
    }
}
