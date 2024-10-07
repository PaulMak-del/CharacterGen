using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    /**
     * Сущность "Моральная позиция". Содержит основную информацию о моральных позициях.
     */
    public class MoralPosition
    {
        /**
         * Идентификатор записи.
         */
        [Key]
        public Guid Id { get; set; }

        /**
         * Название моральной позиции.
         */
        public string Name { get; set; }

        // Navigation Properties
        public virtual ICollection<Character> Characters { get; set; }
    }
}