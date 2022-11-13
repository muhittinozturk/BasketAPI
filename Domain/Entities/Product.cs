using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product : BaseEntity
    {
        public string? ProductName { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public Guid CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
