using TicketApp.Internal.Repository;
using TicketApp.Internal.Entity;
using TicketApp.Internal.Payload;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using Grpc.Core;

namespace TicketApp.Internal.UseCase {
    public class CategoryUC : ICategoryUC {
        ICategoryReader categoryReader;
        ICategoryWriter categoryWriter;
        public CategoryUC(ICategoryReader categoryReader, ICategoryWriter categoryWriter) {
            this.categoryReader = categoryReader;
            this.categoryWriter = categoryWriter;
        }
        public Category Get(Category category) {
            return categoryReader.GetById(category.Id);
        }
        public ListCategoryResp List(ListCategoryReq req) {
            try {
                Category[] categories =  categoryReader.List(req);
                long totalCategories = categoryReader.CountCategories();
                return new ListCategoryResp{
                    categories = categories,
                    totalCategories = totalCategories
                };
            } catch (SqlException e) {
                throw new RpcException(new Status(StatusCode.InvalidArgument, "invalid parameter"), e.Message);
            }
        }
        public Category Create(Category category) {
            category.Id = default(Guid);
            category.CreatedAt = DateTime.Now;
            category.UpdatedAt = DateTime.Now;
            return categoryWriter.Create(category);
        }
        public Category Update(Category category) {
            try {
                Category categoryToUpate = categoryReader.GetById(category.Id);
                category.CreatedAt = categoryToUpate.CreatedAt;
                category.UpdatedAt = DateTime.Now;
                return categoryWriter.Update(category);
            } catch (InvalidOperationException e) {
                throw new RpcException(new Status(StatusCode.InvalidArgument, 
                    "failed to update db, please check if given ID is valid."), e.Message);
            }
        }
        public void Delete(Category category) {
            categoryWriter.DeleteById(category.Id);
        }
    }
}