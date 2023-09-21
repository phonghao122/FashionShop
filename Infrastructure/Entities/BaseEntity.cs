using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Enums;

namespace Infrastructure.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public EntityStatus Status { get; set; }
    }
}
