using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Basket : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public bool? IsActive { get; set; }
        public ICollection<BasketItem>? BasketItems { get; set; }
    }
}
