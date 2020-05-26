using AuthApp.Internal.Repository.Connection;
using AuthApp.Internal.Repository;
using Microsoft.EntityFrameworkCore;

namespace AuthApp.Internal.App {
    
    public class Repos {
        public IUserReader userReader {get;}
        public IUserWriter userWriter {get;}
        public Repos(){
            userReader = new UserReader();
            userWriter = new UserWriter();
        }
    }
}