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
        public User UpdateUser(User user)
        {
            
            using (CodefirstContext db = new CodefirstContext())
            {
                var userEntity = db.Users.FirstOrDefault( u=> u.ID == user.ID);
                if (userEntity != null)
                {
                    userEntity.FirstName = user.FirstName;
                    userEntity.LastName = user.LastName;
                    userEntity.Email = user.Email;
                    userEntity.IsActive = user.IsActive;
                    if (db.SaveChanges() > 0)
                    {
                        return Mapper.Map<User>(userEntity);
                    }
                }
                return null;
            }
        }

        public User AddUser(User user)
        {
            //convert domain model to entity
            if (user.ID == 0)
            {
                var userEntity = Mapper.Map<UserEntity>(user);
                using (CodefirstContext db = new CodefirstContext())
                {
                   
                        db.Users.Add(userEntity);
                    if (db.SaveChanges() > 0)
                    {
                        return Mapper.Map<User>(userEntity);
                    }
                }
                return null;
            }
            else
            {
                return UpdateUser(user);
            }
            
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
