using System;
using System.Linq;
using System.Threading.Tasks;
using AuthGrpc = AuthApp.Internal.Delivery.Grpc;
using Grpc.Net.Client;
using Grpc.Core;

namespace web.Data
{
    public class AuthService {
        AuthGrpc.AuthGrpc.AuthGrpcClient authClient;
        public AuthService(AuthGrpc.AuthGrpc.AuthGrpcClient authClient) {
            this.authClient = authClient;
        }
        public AuthGrpc.LoginResp Login(User user) {
            return authClient.Login(new AuthGrpc.LoginReq{
                Email = user.Email,
                Password = user.Password
            });
        }
        public AuthGrpc.User Register(User user) {
            return authClient.Register(new AuthGrpc.User{
                Email = user.Email,
                Password = user.Password,
                FullName = user.FullName
            });
        }
        public AuthGrpc.User ValidateJwt(string jwt) {
            return authClient.GetUserFromToken(new AuthGrpc.Token{
                Token_ = jwt
            });
        }
        public AuthGrpc.User GetUserById(string id) {
            return authClient.GetUserById(new AuthGrpc.GetUserByIdReq{
                Id = id
            });
        }
    }
    public class ErrorModal {
        public string ModalDisplay = "none;";
        public string ModalClass = "";
        public bool ShowBackdrop = false;
        public RpcException exception;
        public void Open(RpcException e) {
            ModalDisplay = "block;";
            ModalClass = "Show";
            exception = e;
            ShowBackdrop = true;
        }
        public void Close() {
            ModalDisplay = "none";
            ModalClass = "";
            ShowBackdrop = false;
        }
    }
}
