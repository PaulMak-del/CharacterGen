using System;

namespace DAL.Entities
{
    /**
     * Сущность "Навыки". Содержит основную информацию о навыках персонажа.
     */
    public class Skills
    {
        /** Идентификатор записи */
        public Guid Id { get; set; }

        /**
         * Акробатика (Acrobatics) - навык, определяющий ловкость и координацию персонажа.
         */
        public int Acrobatics { get; set; }

        /**
         * Атлетика (Athletics) - навык, определяющий физическую силу и выносливость персонажа.
         */
        public int Athletics { get; set; }

        /**
         * Внимательность (Insight) - навык, определяющий умение замечать и понимать окружающую обстановку.
         */
        public int Insight { get; set; }

        /**
         * Интимидация (Intimidation) - навык, определяющий умение запугивать и деморализовать противников.
         */
        public int Intimidation { get; set; }

        /**
         * История (History) - навык, определяющий знания персонажа о прошлом и исторических событиях.
         */
        public int History { get; set; }

        /**
         * Ловкость рук (Sleight of Hand) - навык, определяющий умение манипулировать предметами и совершать ловкие действия.
         */
        public int SleightOfHand { get; set; }

        /**
         * Медицина (Medicine) - навык, определяющий знания персонажа о медицине и умение лечить раны.
         */
        public int Medicine { get; set; }

        /**
         * Магия (Arcana) - навык, определяющий знания персонажа о магии и умение использовать магические заклинания.
         */
        public int Arcana { get; set; }

        /**
         * Обман (Deception) - навык, определяющий умение обманывать и манипулировать другими.
         */
        public int Deception { get; set; }

        /**
         * Обработка животных (Animal Handling) - навык, определяющий умение обращаться с животными и понимать их поведение.
         */
        public int AnimalHandling { get; set; }

        /**
         * Переговоры (Persuasion) - навык, определяющий умение убеждать и влиять на других.
         */
        public int Persuasion { get; set; }

        /**
         * Природа (Nature) - навык, определяющий знания персонажа о природе и умение выживать в дикой природе.
         */
        public int Nature { get; set; }

        /**
         * Обнаружение (Perception) - навык, определяющий умение замечать и обнаруживать окружающую обстановку.
         */
        public int Perception { get; set; }

        /**
         * Религия (Religion) - навык, определяющий знания персонажа о религии и умение понимать религиозные концепции.
         */
        public int Religion { get; set; }

        /**
         * Социальные навыки (Social Skills) - навык, определяющий умение общаться и взаимодействовать с другими.
         */
        public int SocialSkills { get; set; }

        /**
         * Скрытность (Stealth) - навык, определяющий умение скрываться и передвигаться незаметно.
         */
        public int Stealth { get; set; }

        /**
         * Угадывание (Survival) - навык, определяющий умение выживать в дикой природе и находить еду и воду.
         */
        public int Survival { get; set; }

        /**
         * Расследование (Investigation) - навык, определяющий умение собирать и анализировать информацию.
         */
        public int Investigation { get; set; }

        /**
         * Выступление (Performance) - навык, определяющий умение выступать перед аудиторией и использовать различные формы выражения.
         */
        public int Performance { get; set; }

        // Navigation Properties
        public virtual ICollection<Character> Characters { get; set; }
    }
}