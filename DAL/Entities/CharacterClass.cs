using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    /** Сущность "Класс" в БД. Описывает существующие классы персонажа, пр.: "Воин", "Колдун" и т.д. */
    public class CharacterClass
    {
        /** Идентификатор класса */
        [Key]
        public Guid Id { get; set; }

        /** Имя класса */
        public string Name { get; set; }

        // Navigation Properties
        public virtual ICollection<Character> Characters { get; set; }
    }
}
