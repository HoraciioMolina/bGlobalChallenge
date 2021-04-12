using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bGlobalChallgenge.Models.Entities
{
    public class EntityBase
    {
        [Key]
        public long Id { get; set; }
    }
}
