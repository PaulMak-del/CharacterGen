using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    /**
     * Сущность "Способность". Содержит основную информацию о способностях персонажа, например: "Сила", "Ловкость" или "Интеллект"
     */
    public class Ability
    {
        /** Идентификатор записи */
        [Key]
        public Guid Id { get; set; }

        /** Название способности */
        public string Name { get; set; }

        /** Описание способности */
        public string Description { get; set; }
    }
}