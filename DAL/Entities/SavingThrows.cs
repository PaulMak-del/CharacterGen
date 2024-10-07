using System;

namespace DAL.Entities
{
    /**
     * Сущность "Спасброски". Содержит основную информацию о спасбросках персонажа.
     */
    public class SavingThrows
    {
        /** Идентификатор записи */
        public Guid Id { get; set; }

        /**
         * Сила (Strength) - спасбросок, определяющий физическую силу персонажа.
         */
        public int Strength { get; set; }

        /**
         * Ловкость (Dexterity) - спасбросок, определяющий ловкость и координацию персонажа.
         */
        public int Dexterity { get; set; }

        /**
         * Телосложение (Constitution) - спасбросок, определяющий выносливость и здоровье персонажа.
         */
        public int Constitution { get; set; }

        /**
         * Интеллект (Intelligence) - спасбросок, определяющий интеллектуальные способности персонажа.
         */
        public int Intelligence { get; set; }

        /**
         * Мудрость (Wisdom) - спасбросок, определяющий интуицию и мудрость персонажа.
         */
        public int Wisdom { get; set; }

        /**
         * Харизма (Charisma) - спасбросок, определяющий обаяние и лидерские качества персонажа.
         */
        public int Charisma { get; set; }
    }
}