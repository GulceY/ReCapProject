using Entities_.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities_.Concrete
{
    public class Customer:IEntity
    {
        public int UseId { get; set; }
        public string CompanyName { get; set; }
        public int CustomerId { get; set; }
    }
}
