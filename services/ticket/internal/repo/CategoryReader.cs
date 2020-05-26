using Db = TicketApp.Internal.Repository.Connection;
using Microsoft.EntityFrameworkCore;
using TicketApp.Internal.Entity;
using TicketApp.Internal.Payload;
using TicketApp.Internal.Converter;
using System.Linq;
using System.Collections.Generic;
using System;

namespace TicketApp.Internal.Repository { 
    public class CategoryReader : ICategoryReader {
        public Category GetById(Guid categoryId){
            using(var db = new Db.DbConnection()){
                Db.Category categoryModel = db.Categories.Where(c => c.Id == categoryId).First();
                return CategoryConverter.CategoryModelToEntity(categoryModel);
            }
        }
        public Category[] List(ListCategoryReq req){    
            using(var db = new Db.DbConnection()){        
                int limit = Math.Max(req.limit, 0);
                int offset = Math.Max((req.page-1)*limit, 0);
                
                var query = db.Categories.Skip(offset);
                if(limit > 0)
                    query = query.Take(limit);
                Db.Category[] categoryModels = query.ToArray();
                
                return CategoryConverter.CategoryModelsToEntities(categoryModels);
            }
        }

        public long CountCategories() {
            using(var db = new Db.DbConnection()){
                long counts = db.Categories.Count();
                return counts;
            }
        }
    }
}