using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Application.Interfaces;
public interface IUserRepository<T>
{
    int Create(T user);
    IEnumerable<T> GetAll();
    T GetById(int id);
    bool Update(T obj);
    bool Delete(int id);

}
