using TicketApp.Internal.Util;
using Entity = TicketApp.Internal.Entity;
using Proto = TicketApp.Internal.Delivery.Grpc;
using Db = TicketApp.Internal.Repository.Connection;
using System;

namespace TicketApp.Internal.Converter {
    public class CategoryConverter {
        public static Entity.Category CategoryProtoToEntity(Proto.Category categoryProto) {
            Entity.Category categoryEntity = new Entity.Category {
                Name = categoryProto.Name
            };
            try {
                categoryEntity.Id = Guid.Parse(categoryProto.Id);
            } catch(Exception) {

            }
            return categoryEntity;
        }

        public static Proto.Category CategoryEntityToProto(Entity.Category categoryEntity) {
            return new Proto.Category {
                Id = categoryEntity.Id.ToString(),
                Name = categoryEntity.Name,
                CreatedAt = TimeConverter.DateToUnix(categoryEntity.CreatedAt),
                UpdatedAt = TimeConverter.DateToUnix(categoryEntity.UpdatedAt),
            };
        }
        public static Proto.Category[] CategoryEntitiesToProtos(Entity.Category[] categoryEntities) {
            Proto.Category[] categoryProtos = new Proto.Category[categoryEntities.Length];
            for(int i = 0; i < categoryEntities.Length; i++) 
                categoryProtos[i] = CategoryEntityToProto(categoryEntities[i]);
            return categoryProtos;
        }
        public static Db.Category CategoryEntityToModel(Entity.Category categoryEntity) {
            Db.Category categoryModel = new Db.Category {
                Id = categoryEntity.Id,
                Name = categoryEntity.Name,
                CreatedAt = categoryEntity.CreatedAt,
                UpdatedAt = categoryEntity.UpdatedAt
            };
            return categoryModel;
        }
        public static Entity.Category CategoryModelToEntity(Db.Category categoryModel) {
            return new Entity.Category {
                Id = categoryModel.Id,
                Name = categoryModel.Name,
                CreatedAt = categoryModel.CreatedAt,
                UpdatedAt = categoryModel.UpdatedAt
            };
        }
        public static Entity.Category[] CategoryModelsToEntities(Db.Category[] categoryModels) {
            Entity.Category[] categoryEntities = new Entity.Category[categoryModels.Length];
            for(int i = 0; i < categoryModels.Length; i++) 
                categoryEntities[i] = CategoryModelToEntity(categoryModels[i]);
            return categoryEntities;
        }
    }
}