using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entities
{
    public class ChatRoom : BaseEntity<Guid>
    {
        [Required]
        public string Name { get; set; }
    }
}
