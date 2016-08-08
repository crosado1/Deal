using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deal.repository.abstracts
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(int Id);
    }
}
