using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinApp.Service
{
    public interface IService<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> GetDetails(Func<T, bool> predicate);
    }
}
