
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XamarinApp.Services
{
    public interface IService<T> where T: class
    {
        Task<IList<T>> GetAll();
    }
}
