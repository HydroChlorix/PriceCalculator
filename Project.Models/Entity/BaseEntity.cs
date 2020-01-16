using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Project.Models.Entity
{
    public abstract class BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid? CreatedUserId { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? ModifiedUserId { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
