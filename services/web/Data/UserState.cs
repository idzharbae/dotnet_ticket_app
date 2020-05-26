using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web.Data;
using AuthGrpc = AuthApp.Internal.Delivery.Grpc;

namespace StateManagement {
    public class UserState {
        public User user {get; set;}
    }

}

 