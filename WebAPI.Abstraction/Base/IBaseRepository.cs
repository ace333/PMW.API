using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Abstraction
{
    public interface IBaseRepository<TModel>
    {
        int GetLastId();
        void Insert(TModel item);
        TModel CreateNewItem();
    }
}
