using EShop.Application.Interfaces;
using EShop.Domain.Entities;
using EShop.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;

namespace EShop.Infrastructure.Services;
public class UserService : IUserService
{
    private readonly EShopDbContext _db;
    public UserService()
    {
        _db = new EShopDbContext();
    }

    public int Create(User user)
    {
        _db.Add(user);
        _db.SaveChanges();
        return user.Id;
    }

    public bool Delete(int id)
    {
        User? userEntity = _db.Users.Find(id);
        if (userEntity == null)
            return false;
        _db.Users.Remove(userEntity);
        _db.SaveChanges();
        return true;
    }

    public IEnumerable<User> GetAll()
    {
        var users = _db.Users.AsNoTracking().AsEnumerable();
        return users;
    }

    public User GetById(int id)
    {
        var user = _db.Users.Find(id);
        return user;
    }

    public User Login(string userLogin, string password)
    {
        User? user = _db.Users.FirstOrDefault(x => x.EmailLogin.Equals(userLogin) &&
                                                 x.Password.Equals(password));
        return user;
    }

    public bool Update(User obj)
    {
        User? EntityUser = _db.Users.Find(obj.Id);
        if (EntityUser != null)
        {
            _db.Users.Update(obj);
            _db.SaveChanges();
            return true;
        }
        return false;


    }
}
