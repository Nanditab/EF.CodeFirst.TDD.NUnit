using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Codefirst.Infrastructure.DAL.Store
{
   public class DatabaseIntialization
    {
       public enum EFInitializerType
        {
            DropCreateDatabaseIfModelChanges,
            DropCreateDatabaseAlways
        }
        public static void Initialize(EFInitializerType type)
        {
            switch (type)
            {
                case EFInitializerType.DropCreateDatabaseIfModelChanges:
                    Database.SetInitializer(new ProductDropDatabaseIfChangedInitializer());
                    break;
                case EFInitializerType.DropCreateDatabaseAlways:
                    Database.SetInitializer(new ProductAlwaysDropDatabaseInitializercs());
                    break;                
            }           
            ProductContext db = new ProductContext();
            db.Database.Initialize(false);
            db.Dispose();
        }
    }
}
