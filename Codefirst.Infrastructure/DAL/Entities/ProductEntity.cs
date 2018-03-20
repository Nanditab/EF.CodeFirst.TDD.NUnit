﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codefirst.Infrastructure.DAL.Entities
{
   public class ProductEntity
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int CategoryID { get; set; }

        public CategoryEntity Category { get; set; }

        public byte[] Image { get; set; }

        public string ImageMIMEType { get; set; }

        public decimal Price { get; set; }

        public bool IsPublished { get; set; }
    }
}
