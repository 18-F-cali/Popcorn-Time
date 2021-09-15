using System.ComponentModel.DataAnnotations;
using System;

namespace PopcornTime.Core.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
