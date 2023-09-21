﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    [Table("Reviews")]
    public class Review : BaseEntity
    {
        [Column(TypeName = "nvarchar(1000)")]
        public string ReviewerName { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        public string? Email { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }
        public int Rating { get; set; }

        [ForeignKey("Review-Product")]
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}
