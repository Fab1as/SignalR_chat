using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entities
{
    public class BaseEntity<TKey>
    {
        [Required]
        [Key]
        public virtual TKey Id { get; set; }
    }
}
