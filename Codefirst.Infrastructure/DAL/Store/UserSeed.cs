using Codefirst.Domain.DomainModel;
using Codefirst.Infrastructure.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codefirst.Infrastructure.DAL.Store
{
   public static class UserSeed
    {
        public static List<UserEntity> GetUsersForDBInitialize()
        {
            List<UserEntity> userList = new List<UserEntity>
            {
                new UserEntity{ FirstName="Rachel", LastName="Green", Email="Rachel.Green@somewhere.com", IsActive=true},
                new UserEntity{ FirstName="Monica", LastName="Geller", Email="Monica.Geller@somewhere.com", IsActive=true},
new UserEntity{ FirstName="Ross", LastName="Geller", Email="Ross.Geller@somewhere.com", IsActive=true},
new UserEntity{ FirstName="Chandler", LastName="Bing", Email="Chandler.Bing@somewhere.com", IsActive=true},
new UserEntity{ FirstName="Joey", LastName="Tribbiani", Email="Joey.Tribbiani@somewhere.com", IsActive=true},
new UserEntity{ FirstName="Phoebe", LastName="Buffay", Email="Phoebe.b@somewhere.com", IsActive=true}

            };

            return userList;
        }
    }
}
