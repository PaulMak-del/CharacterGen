using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    /**
     * Сущность "Раса". Содержит основную информацию о расах персонажа, например: "Человек", "Эльф" или "Дворф"
     */
    public class Race
    {
        /** Идентификатор записи */
        [Key]
        public Guid Id { get; set; }

        /** Название расы */
        public string Name { get; set; }

        // Navigation Properties
        public virtual ICollection<Character> Characters { get; set; }
    }
}
