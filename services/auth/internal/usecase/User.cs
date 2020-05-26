using AuthApp.Internal.Entity;
using AuthApp.Internal.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using Grpc.Core;

namespace AuthApp.Internal.UseCase {
    public class UserUC : IUserUC {
        IUserReader userReader;
        IUserWriter userWriter;
        public UserUC(IUserReader userReader, IUserWriter userWriter) {
            this.userReader = userReader;
            this.userWriter = userWriter;
        }
        public User Get(User user){
            try {
                if(!string.IsNullOrEmpty(user.Email)){
                    if(!string.IsNullOrEmpty(user.Password))
                        return this.userReader.GetByEmailAndPassword(user.Email, user.Password);
                    return this.userReader.GetByEmail(user.Email);
                }
                return this.userReader.GetById(user.Id);
            } catch (InvalidOperationException e) {
                throw new RpcException(new Status(StatusCode.InvalidArgument, "user not found"), e.Message);
            }
        }
        public User Create(User user){
            try {
                if (!user.ValidateEmail())
                    throw new RpcException(new Status(StatusCode.InvalidArgument, "Incorrect email format"), "");
                if (!user.ValidatePassword()) 
                    throw new RpcException(new Status(StatusCode.InvalidArgument, 
                        "password must contain at least one uppercase, one lowercase, and one number"), "");
                if (user.Password.Length < 8) 
                    throw new RpcException(new Status(StatusCode.InvalidArgument, 
                        "password must be at least 8 characters long"), "");
                
                return this.userWriter.Create(user);
            } catch (InvalidOperationException e) {
                throw new RpcException(new Status(StatusCode.InvalidArgument, "failed to save user to database"), 
                    e.Message);
            } catch (DbUpdateException e) {
                string errMessage = e.InnerException.Message.Contains("duplicate key")?
                    "email already exists" : "failed to save user to database";
                throw new RpcException(new Status(StatusCode.InvalidArgument, errMessage), 
                    e.InnerException.Message);
            }
        }
        public User Update(User user){
            return user;
        }
        public User Delete(User user){
            return user;
        }
    }
}