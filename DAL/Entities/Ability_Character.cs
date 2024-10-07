using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    /** Промежуточная таблица связи многие ко многим */
    public class Ability_Character
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Ability")]
        public Guid AbilityId { get; set; }
        public Ability Ability { get; set; }

        [ForeignKey("Character")]
        public Guid CharacterId { get; set; }
        public Character Character { get; set; }
    }
}
