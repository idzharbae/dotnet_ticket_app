// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protos/auth.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace AuthApp.Internal.Delivery.Grpc {
  public static partial class AuthGrpc
  {
    static readonly string __ServiceName = "AuthProto.AuthGrpc";

    static readonly grpc::Marshaller<global::AuthApp.Internal.Delivery.Grpc.LoginReq> __Marshaller_AuthProto_LoginReq = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AuthApp.Internal.Delivery.Grpc.LoginReq.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::AuthApp.Internal.Delivery.Grpc.LoginResp> __Marshaller_AuthProto_LoginResp = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AuthApp.Internal.Delivery.Grpc.LoginResp.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::AuthApp.Internal.Delivery.Grpc.Token> __Marshaller_AuthProto_Token = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AuthApp.Internal.Delivery.Grpc.Token.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::AuthApp.Internal.Delivery.Grpc.User> __Marshaller_AuthProto_User = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AuthApp.Internal.Delivery.Grpc.User.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::AuthApp.Internal.Delivery.Grpc.GetUserByIdReq> __Marshaller_AuthProto_GetUserByIdReq = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AuthApp.Internal.Delivery.Grpc.GetUserByIdReq.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::AuthApp.Internal.Delivery.Grpc.GetUserByEmailReq> __Marshaller_AuthProto_GetUserByEmailReq = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AuthApp.Internal.Delivery.Grpc.GetUserByEmailReq.Parser.ParseFrom);

    static readonly grpc::Method<global::AuthApp.Internal.Delivery.Grpc.LoginReq, global::AuthApp.Internal.Delivery.Grpc.LoginResp> __Method_Login = new grpc::Method<global::AuthApp.Internal.Delivery.Grpc.LoginReq, global::AuthApp.Internal.Delivery.Grpc.LoginResp>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Login",
        __Marshaller_AuthProto_LoginReq,
        __Marshaller_AuthProto_LoginResp);

    static readonly grpc::Method<global::AuthApp.Internal.Delivery.Grpc.Token, global::AuthApp.Internal.Delivery.Grpc.User> __Method_GetUserFromToken = new grpc::Method<global::AuthApp.Internal.Delivery.Grpc.Token, global::AuthApp.Internal.Delivery.Grpc.User>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetUserFromToken",
        __Marshaller_AuthProto_Token,
        __Marshaller_AuthProto_User);

    static readonly grpc::Method<global::AuthApp.Internal.Delivery.Grpc.GetUserByIdReq, global::AuthApp.Internal.Delivery.Grpc.User> __Method_GetUserById = new grpc::Method<global::AuthApp.Internal.Delivery.Grpc.GetUserByIdReq, global::AuthApp.Internal.Delivery.Grpc.User>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetUserById",
        __Marshaller_AuthProto_GetUserByIdReq,
        __Marshaller_AuthProto_User);

    static readonly grpc::Method<global::AuthApp.Internal.Delivery.Grpc.GetUserByEmailReq, global::AuthApp.Internal.Delivery.Grpc.User> __Method_GetUserByEmail = new grpc::Method<global::AuthApp.Internal.Delivery.Grpc.GetUserByEmailReq, global::AuthApp.Internal.Delivery.Grpc.User>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetUserByEmail",
        __Marshaller_AuthProto_GetUserByEmailReq,
        __Marshaller_AuthProto_User);

    static readonly grpc::Method<global::AuthApp.Internal.Delivery.Grpc.User, global::AuthApp.Internal.Delivery.Grpc.User> __Method_Register = new grpc::Method<global::AuthApp.Internal.Delivery.Grpc.User, global::AuthApp.Internal.Delivery.Grpc.User>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Register",
        __Marshaller_AuthProto_User,
        __Marshaller_AuthProto_User);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AuthApp.Internal.Delivery.Grpc.AuthReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AuthGrpc</summary>
    [grpc::BindServiceMethod(typeof(AuthGrpc), "BindService")]
    public abstract partial class AuthGrpcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::AuthApp.Internal.Delivery.Grpc.LoginResp> Login(global::AuthApp.Internal.Delivery.Grpc.LoginReq request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::AuthApp.Internal.Delivery.Grpc.User> GetUserFromToken(global::AuthApp.Internal.Delivery.Grpc.Token request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::AuthApp.Internal.Delivery.Grpc.User> GetUserById(global::AuthApp.Internal.Delivery.Grpc.GetUserByIdReq request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::AuthApp.Internal.Delivery.Grpc.User> GetUserByEmail(global::AuthApp.Internal.Delivery.Grpc.GetUserByEmailReq request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::AuthApp.Internal.Delivery.Grpc.User> Register(global::AuthApp.Internal.Delivery.Grpc.User request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AuthGrpcBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Login, serviceImpl.Login)
          .AddMethod(__Method_GetUserFromToken, serviceImpl.GetUserFromToken)
          .AddMethod(__Method_GetUserById, serviceImpl.GetUserById)
          .AddMethod(__Method_GetUserByEmail, serviceImpl.GetUserByEmail)
          .AddMethod(__Method_Register, serviceImpl.Register).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AuthGrpcBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Login, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::AuthApp.Internal.Delivery.Grpc.LoginReq, global::AuthApp.Internal.Delivery.Grpc.LoginResp>(serviceImpl.Login));
      serviceBinder.AddMethod(__Method_GetUserFromToken, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::AuthApp.Internal.Delivery.Grpc.Token, global::AuthApp.Internal.Delivery.Grpc.User>(serviceImpl.GetUserFromToken));
      serviceBinder.AddMethod(__Method_GetUserById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::AuthApp.Internal.Delivery.Grpc.GetUserByIdReq, global::AuthApp.Internal.Delivery.Grpc.User>(serviceImpl.GetUserById));
      serviceBinder.AddMethod(__Method_GetUserByEmail, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::AuthApp.Internal.Delivery.Grpc.GetUserByEmailReq, global::AuthApp.Internal.Delivery.Grpc.User>(serviceImpl.GetUserByEmail));
      serviceBinder.AddMethod(__Method_Register, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::AuthApp.Internal.Delivery.Grpc.User, global::AuthApp.Internal.Delivery.Grpc.User>(serviceImpl.Register));
    }

  }
}
#endregion
