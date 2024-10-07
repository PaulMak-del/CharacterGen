
namespace DAL.Entities
{
    /**
     * Сущность "Характеристики". Содержит основную информацию о характеристиках персонажа.
     */
    public class Stats
    {
        /** Идентификатор записи */
        public Guid Id { get; set; }

        /**
         * Сила (Strength) - характеристика, определяющая физическую силу персонажа.
         */
        public int Strength { get; set; }

        /**
         * Ловкость (Dexterity) - характеристика, определяющая ловкость и координацию персонажа.
         */
        public int Dexterity { get; set; }

        /**
         * Телосложение (Constitution) - характеристика, определяющая выносливость и здоровье персонажа.
         */
        public int Constitution { get; set; }

        /**
         * Интеллект (Intelligence) - характеристика, определяющая интеллектуальные способности персонажа.
         */
        public int Intelligence { get; set; }

        /**
         * Мудрость (Wisdom) - характеристика, определяющая интуицию и мудрость персонажа.
         */
        public int Wisdom { get; set; }

        /**
         * Харизма (Charisma) - характеристика, определяющая обаяние и лидерские качества персонажа.
         */
        public int Charisma { get; set; }
    }
}