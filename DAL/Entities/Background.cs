using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    /**
     * Сущность "Происхождение". Содержит основную информацию о происхождении персонажа, например: "Благородный" 
     */
    public class Background
    {
        /** Идентификатор записи */
        [Key]
        public Guid Id { get; set; }

        /** Название происхождения */
        public string Name { get; set; }

        // Navigation Properties
        public virtual ICollection<Character> Characters { get; set; }
    }
}