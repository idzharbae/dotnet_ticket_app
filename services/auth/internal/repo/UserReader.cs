using AuthApp.Internal.Entity;
using Microsoft.EntityFrameworkCore;
using Db = AuthApp.Internal.Repository.Connection;
using System;
using System.Linq;
using AuthApp.Internal.Util;


namespace AuthApp.Internal.Repository { 
    public class UserReader : IUserReader {
        public User GetById(Guid Id) {
            using(var db = new Db.DbConnection()) {
                Db.User user = db.Users
                .Where(user => user.Id == Id)
                .First();
                return new User {
                    Id = user.Id, 
                    Email = user.Email, 
                    FullName = user.FullName
                };      
            }
        }
        public User GetByEmail(string email) {
            using(var db = new Db.DbConnection()) {
                Db.User user = db.Users
                .Where(user => user.Email == email)
                .First();
                return new User {
                    Id = user.Id, 
                    Email = user.Email, 
                    FullName = user.FullName
                };      
            }
        }
        public User GetByEmailAndPassword(string email, string password) {
            using(var db = new Db.DbConnection()) {
                Db.User user = db.Users
                .Where(user => user.Email == email)
                .Where(user => user.Password == Hashes.GetSHA256Hash(password))
                .First();
                return new User {
                    Id = user.Id, 
                    Email = user.Email, 
                    FullName = user.FullName
                };      
            }
        }
    }
}