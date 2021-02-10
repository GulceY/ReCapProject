using Entities_.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities_.Concrete
{
    public class Brand:IEntity
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
