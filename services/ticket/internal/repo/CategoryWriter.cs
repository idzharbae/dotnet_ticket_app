using Db = TicketApp.Internal.Repository.Connection;
using TicketApp.Internal.Entity;
using TicketApp.Internal.Converter;
using System;
using Microsoft.EntityFrameworkCore;

namespace TicketApp.Internal.Repository { 
    public class CategoryWriter : ICategoryWriter {
        public Category Create(Category category){
            using(var db = new Db.DbConnection()){
                Db.Category categoryModel = CategoryConverter.CategoryEntityToModel(category);
                db.Categories.Add(categoryModel);
                db.SaveChanges();
                return CategoryConverter.CategoryModelToEntity(categoryModel);
            }
        }
        public Category Update(Category category){
            using(var db = new Db.DbConnection()){
                Db.Category categoryModel = CategoryConverter.CategoryEntityToModel(category);
                db.Categories.Update(categoryModel);
                db.SaveChanges();
                return CategoryConverter.CategoryModelToEntity(categoryModel);
            }
        }
        public void DeleteById(Guid id){
            using(var db = new Db.DbConnection()){
                Db.Category categoryModel = new Db.Category{Id = id};
                db.Entry(categoryModel).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}