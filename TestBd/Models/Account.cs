using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TestBd.Models
{
    class Account
    {
        [Key]
        public Guid ContactId { get; set; }
        public string Name { get; set; }
        public DateTime CreateOn { get; set; }

    }
}
