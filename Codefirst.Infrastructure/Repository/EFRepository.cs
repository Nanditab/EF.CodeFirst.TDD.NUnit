using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codefirst.Domain.DomainModel;
using Codefirst.Infrastructure.DAL.Entities;
using AutoMapper;
using Codefirst.Infrastructure.DAL.Store;
using AutoMapper.QueryableExtensions;

namespace Codefirst.Infrastructure.Repository
{
    public class EFRepository
    {
        static EFRepository()
        {
            //create mapping
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Product, ProductEntity>();
                cfg.CreateMap<ProductEntity, Product>();
                cfg.CreateMap<Category, CategoryEntity>();
                cfg.CreateMap<User, UserEntity>();
                cfg.CreateMap<UserEntity, User>();
                });
        }
        public ICollection<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();

            return categories;
        }

        public User AddUser(User user)
        {
            //convert domain model to entity
            var userEntity = Mapper.Map<UserEntity>(user);
            using (CodefirstContext db = new CodefirstContext())
            {
                db.Users.Add(userEntity);
                if(db.SaveChanges() > 0)
                {
                    return Mapper.Map<User>(userEntity);
                }
            }
            return null;
        }

        public List<User> GetUsers()
        {
            using (CodefirstContext db = new CodefirstContext())
            {
                return db.Users.ProjectTo<User>(Mapper.Configuration).ToList();
            }
        }
    }
}
