using TicketApp.Internal.Util;
using Entity = TicketApp.Internal.Entity;
using Proto = TicketApp.Internal.Delivery.Grpc;
using Db = TicketApp.Internal.Repository.Connection;
using System;

namespace TicketApp.Internal.Converter {
    public class TicketConverter {
        public static Entity.Ticket TicketProtoToEntity(Proto.Ticket TicketProto) {
            Entity.Ticket TicketEntity = new Entity.Ticket {
                Name = TicketProto.Name,
                Description = TicketProto.Description,
                Status = TicketProto.Status
            };
            try {
                TicketEntity.Id = Parser.ParseGuid(TicketProto.Id);
                TicketEntity.OwnerId = Parser.ParseGuid(TicketProto.OwnerId);
                TicketEntity.AsigneeId = Parser.ParseGuid(TicketProto.AsigneeId);
                TicketEntity.CategoryId = Parser.ParseGuid(TicketProto.CategoryId);
            } catch(Exception) {

            }
            return TicketEntity;
        }

        public static Proto.Ticket TicketEntityToProto(Entity.Ticket TicketEntity) {
            return new Proto.Ticket {
                Id = TicketEntity.Id.ToString(),
                OwnerId = TicketEntity.OwnerId.ToString(),
                AsigneeId = TicketEntity.AsigneeId.ToString(),
                CategoryId = TicketEntity.CategoryId.ToString(),
                Name = TicketEntity.Name,
                Description = TicketEntity.Description,
                Status = TicketEntity.Status,
                CreatedAt = TimeConverter.DateToUnix(TicketEntity.CreatedAt),
                UpdatedAt = TimeConverter.DateToUnix(TicketEntity.UpdatedAt),
            };
        }
        public static Proto.Ticket[] TicketEntitiesToProtos(Entity.Ticket[] TicketEntities) {
            Proto.Ticket[] TicketProtos = new Proto.Ticket[TicketEntities.Length];
            for(int i = 0; i < TicketEntities.Length; i++) 
                TicketProtos[i] = TicketEntityToProto(TicketEntities[i]);
            return TicketProtos;
        }
        public static Db.Ticket TicketEntityToModel(Entity.Ticket TicketEntity) {
            Db.Ticket TicketModel = new Db.Ticket {
                Id = TicketEntity.Id,
                OwnerId = TicketEntity.OwnerId,
                AsigneeId = TicketEntity.AsigneeId,
                CategoryId = TicketEntity.CategoryId,
                Name = TicketEntity.Name,
                Description = TicketEntity.Description,
                Status = TicketEntity.Status,
                CreatedAt = TicketEntity.CreatedAt,
                UpdatedAt = TicketEntity.UpdatedAt,
            };
            return TicketModel;
        }
        public static Entity.Ticket TicketModelToEntity(Db.Ticket TicketModel) {
            return new Entity.Ticket {
                Id = TicketModel.Id,
                OwnerId = TicketModel.OwnerId,
                AsigneeId = TicketModel.AsigneeId,
                CategoryId = TicketModel.CategoryId,
                Name = TicketModel.Name,
                Description = TicketModel.Description,
                Status = TicketModel.Status,
                CreatedAt = TicketModel.CreatedAt,
                UpdatedAt = TicketModel.UpdatedAt,
            };
        }
        public static Entity.Ticket[] TicketModelsToEntities(Db.Ticket[] TicketModels) {
            Entity.Ticket[] TicketEntities = new Entity.Ticket[TicketModels.Length];
            for(int i = 0; i < TicketModels.Length; i++) 
                TicketEntities[i] = TicketModelToEntity(TicketModels[i]);
            return TicketEntities;
        }
    }
}