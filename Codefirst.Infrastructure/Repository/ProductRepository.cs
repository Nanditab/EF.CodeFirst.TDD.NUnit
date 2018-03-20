using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codefirst.Domain.DomainModel;
namespace Codefirst.Infrastructure.Repository
{
    public class ProductRepository
    {
        public ICollection<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();

            return categories;
        }
    }
}
