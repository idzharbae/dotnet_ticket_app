using AuthApp.Internal.Entity;
using System;

namespace AuthApp.Internal.Repository {
    public interface IUserReader{
        User GetById(Guid id);
        User GetByEmailAndPassword(string email, string password);
        User GetByEmail(string email);
    }
    public interface IUserWriter {
        User Create(User user);
        User Update(User user);
        void DeleteById(Guid id);
    }
}