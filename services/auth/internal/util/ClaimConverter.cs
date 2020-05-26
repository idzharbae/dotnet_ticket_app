using System.Collections.Generic;
using System.Security.Claims;
using System.Linq;
using AuthApp.Internal.Delivery.Grpc;
using System;
using Grpc.Core;

namespace AuthApp.Internal.Util {
    public class ClaimConverter {
        public static User ConvertClaimsToUserProto(List<Claim> claims) {
            try {
                return new User {
                    Id =  claims.First(c => c.Type == "id").Value,
                    FullName = claims.First(c => c.Type == "full_name").Value,
                    Email = claims.First(c => c.Type == ClaimTypes.Email).Value
                };   
            } catch (FormatException e) {
                throw new RpcException(new Status(StatusCode.InvalidArgument, "failed to parse token"), e.Message);
            } catch (InvalidOperationException e) {
                throw new RpcException(new Status(StatusCode.InvalidArgument, "failed to parse token"), e.Message);
            }
        }
    }
}