using AuthApp.Internal.Entity;
using AuthApp.Internal.Util;
using Db = AuthApp.Internal.Repository.Connection;
using System;

namespace AuthApp.Internal.Repository { 
    public class UserWriter : IUserWriter {
        public User Create(User user) {
            using(var db = new Db.DbConnection()) {
                Db.User userModel = new Db.User {
                    Email=user.Email, 
                    FullName=user.FullName, 
                    Password=Hashes.GetSHA256Hash(user.Password)
                };
                db.Users.Add(userModel);
                db.SaveChanges();
                user.Id = userModel.Id;
                return user;
            }
        }
        public User Update(User user) {
            return new User();
        }
        public void DeleteById(Guid id) {
            
        }
    }
}