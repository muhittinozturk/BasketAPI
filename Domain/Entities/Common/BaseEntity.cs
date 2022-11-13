using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Common
{
    public class BaseEntity
    {
        [Key]
        public Guid UUID { get; set; } 
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}